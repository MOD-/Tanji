using System.Windows.Forms;

using Sulakore.Habbo.Web;

namespace Tanji.Dialogs
{
    public partial class VariablesFrm : Form
    {
        public HGameData GameData { get; }

        public VariablesFrm(HGameData gameData)
        {
            InitializeComponent();
            GameData = gameData;
        }
    }
}