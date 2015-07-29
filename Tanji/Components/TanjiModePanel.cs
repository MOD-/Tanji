/* Copyright

    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    Habbo Hotel Packet(Logger/Manipulator)
    Copyright (C) 2015 ArachisH

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.

    See License.txt in the project root for license information.
*/

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

using Tanji.Utilities;

namespace Tanji.Components
{
    [DesignerCategory("Code")]
    public class TanjiModePanel : Control
    {
        private readonly Color[] _glowColors;

        private int _modeWidth;
        private Rectangle _automaticRegion, _manualRegion;
        private Color _automaticGlowColor, _manualGlowColor;

        public event EventHandler ModeChanged;
        protected virtual void OnModeChanged(EventArgs e)
        {
            ModeChanged?.Invoke(this, e);
        }

        private bool _isManual = false;
        [DefaultValue(false)]
        public bool IsManual
        {
            get { return _isManual; }
            set
            {
                if (!Enabled || _isManual == value) return;

                _isManual = value;
                _manualGlowColor = _glowColors[_isManual ? 1 : 0];
                _automaticGlowColor = _glowColors[_isManual ? 0 : 1];

                Invalidate();
                OnModeChanged(EventArgs.Empty);
            }
        }

        public TanjiModePanel()
        {
            SetStyle((ControlStyles)2050, true);
            DoubleBuffered = true;

            _glowColors = new[] { Color.Silver, Color.FromArgb(243, 63, 63) };

            _automaticGlowColor = _glowColors[1];
            _manualGlowColor = _glowColors[0];

            Size = new Size(330, 33);
            Font = new Font("Segoe UI", 15);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            var autoDrawRegion = new Rectangle(_automaticRegion.X, Height - 2, _modeWidth, 2);
            e.Graphics.FillRectangle(_automaticGlowColor, autoDrawRegion);

            var manualDrawRegion = new Rectangle(_manualRegion.X, Height - 2, _modeWidth, 2);
            e.Graphics.FillRectangle(_manualGlowColor, manualDrawRegion);

            if (!Enabled)
            {
                Color darkenColor = Color.FromArgb(30, Color.Black);
                e.Graphics.FillRectangle(darkenColor, autoDrawRegion);
                e.Graphics.FillRectangle(darkenColor, manualDrawRegion);
            }

            Color foreColor = Color.Black;
            e.Graphics.DrawString("Manual", Font, foreColor, _manualRegion, StringAlignment.Center);
            e.Graphics.DrawString("Automatic", Font, foreColor, _automaticRegion, StringAlignment.Center);

            base.OnPaint(e);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            _modeWidth = (Width / 2) - 15;

            _automaticRegion = new Rectangle(12, 0, _modeWidth, Height);
            _manualRegion = new Rectangle(_modeWidth + 18, 0, _modeWidth, Height);

            base.OnSizeChanged(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            bool clickedAutomatic = _automaticRegion.Contains(e.Location);
            bool clickedManual = _manualRegion.Contains(e.Location);
            if (!clickedAutomatic && !clickedManual) return;

            base.OnMouseDown(e);
            IsManual = clickedManual;
        }
    }
}