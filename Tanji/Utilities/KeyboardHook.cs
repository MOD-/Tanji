using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Tanji.Utilities
{
    public class KeyboardHook : NativeWindow, IDisposable
    {
        private readonly Dictionary<uint, Dictionary<Keys, int>> _registeredKeys;

        private const int WM_HOTKEY = 0x0312;

        public event EventHandler<KeyPressedEventArgs> KeyPressed;
        public virtual void OnKeyPressed(KeyPressedEventArgs e)
        {
            KeyPressed?.Invoke(this, e);
        }

        public bool IsDisposed { get; private set; }

        public KeyboardHook()
        {
            _registeredKeys = new Dictionary<uint, Dictionary<Keys, int>>();

            CreateHandle(new CreateParams());
        }

        public void RegisterHotkey(Keys hotkey)
        {
            if (IsDisposed)
                throw new ObjectDisposedException(nameof(Handle));

            lock (_registeredKeys)
            {
                uint modifier = GetModifier(ref hotkey);

                if (!_registeredKeys.ContainsKey(modifier))
                    _registeredKeys[modifier] = new Dictionary<Keys, int>();

                var id = (int)DateTime.Now.Ticks;
                if (!_registeredKeys[modifier].ContainsKey(hotkey))
                {
                    _registeredKeys[modifier][hotkey] = id;

                    NativeMethods.RegisterHotKey(Handle,
                        id, modifier, (uint)hotkey);
                }
            }
        }
        public void UnregisterHotkey(Keys hotkey)
        {
            if (IsDisposed)
                throw new ObjectDisposedException(nameof(Handle));

            lock (_registeredKeys)
            {
                uint modifier = GetModifier(ref hotkey);
                if (!_registeredKeys.ContainsKey(modifier)) return;
                if (!_registeredKeys[modifier].ContainsKey(hotkey)) return;

                NativeMethods.UnregisterHotKey(Handle,
                    _registeredKeys[modifier][hotkey]);

                _registeredKeys[modifier].Remove(hotkey);
            }
        }

        private Keys GetModifier(uint modifierCode)
        {
            switch (modifierCode)
            {
                case 1: return Keys.Alt;
                case 2: return Keys.Control;
                case 4: return Keys.Shift;

                default:
                throw new ArgumentException("Invalid modifier code: " + modifierCode);
            }
        }
        private uint GetModifier(ref Keys hotkey)
        {
            Keys modifier = (hotkey & Keys.Modifiers);
            hotkey &= ~modifier;

            switch (modifier)
            {
                case Keys.Alt: return 1;

                case Keys.Control:
                case Keys.ControlKey:
                case Keys.LControlKey:
                case Keys.RControlKey: return 2;

                case Keys.Shift:
                case Keys.ShiftKey:
                case Keys.LShiftKey:
                case Keys.RShiftKey: return 4;

                default:
                throw new ArgumentException("Invalid modifier key: " + modifier);
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_HOTKEY)
            {
                var param = (int)m.LParam;
                var key = (Keys)(param >> 16 & 0xFFFF);
                var modifierCode = (uint)(param & 0xFFFF);

                key |= GetModifier(modifierCode);
                OnKeyPressed(new KeyPressedEventArgs(key));
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (IsDisposed) return;
            if (disposing)
            {
                foreach (Dictionary<Keys, int> keys in _registeredKeys.Values)
                {
                    foreach (int identifier in keys.Values)
                    {
                        NativeMethods.UnregisterHotKey(
                            Handle, identifier);
                    }
                }

                _registeredKeys.Clear();
                DestroyHandle();
            }
            IsDisposed = true;
        }
    }
}