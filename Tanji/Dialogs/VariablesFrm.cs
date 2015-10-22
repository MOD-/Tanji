/*
    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    This file is part of Tanji.
    Copyright (C) 2015 ArachisH
    
    This code is licensed under the GNU General Public License.
    See License.txt in the project root for license information.
*/

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