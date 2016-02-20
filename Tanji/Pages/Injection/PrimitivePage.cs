using System.Windows.Forms;

using Sulakore.Protocol;

namespace Tanji.Pages.Injection
{
    public class PrimitivePage : TanjiSubPage<InjectionPage>
    {
        public PrimitivePage(InjectionPage parent, TabPage tab)
            : base(parent, tab)
        {
            UI.PTInjectionMenu.InputBox = UI.PTPacketTxt;
        }

        private void PTPacketTxt_TextChanged(object sender, System.EventArgs e)
        {
            var packet = new HMessage(UI.PTPacketTxt.Text);
            UI.ITPacketTxt.Text = packet.ToString();

            UI.PTPacketInfoLbl.Text =
                $"Header: {packet.Header}, Length: {packet.Length}";

            UI.PTCorruptedValueLbl.Text =
                packet.IsCorrupted.ToString();

            UI.PTCorruptedValueLbl.ForeColor = (packet.IsCorrupted ?
                UI.PacketLoggerUI.IncomingHighlight :
                UI.PacketLoggerUI.OutgoingHighlight);
        }

        protected override void OnTabSelecting(TabControlCancelEventArgs e)
        {
            UI.ITPacketTxt.Enabled = false;
            UI.PTPacketTxt.Text = UI.ITPacketTxt.Text;
            UI.PTPacketTxt.TextChanged += PTPacketTxt_TextChanged;

            base.OnTabSelecting(e);
        }
        protected override void OnTabDeselecting(TabControlCancelEventArgs e)
        {
            UI.ITPacketTxt.Enabled = true;
            UI.PTPacketTxt.TextChanged -= PTPacketTxt_TextChanged;

            base.OnTabDeselecting(e);
        }
    }
}