using Tanji.Properties;

using System.Drawing;
using System.Windows.Forms;

namespace Tanji.Components
{
    public class TanjiForm : Form
    {
        public TanjiForm()
        {
            BackColor = Color.White;
            Icon = Resources.Tanji_128;
        }
    }
}