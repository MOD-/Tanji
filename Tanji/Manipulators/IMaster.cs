using System;
using System.Windows.Forms;

using Tanji.Utilities;

using Sulakore.Habbo;
using Sulakore.Habbo.Web;
using Sulakore.Communication;

using Tangine.Habbo;

namespace Tanji.Manipulators
{
    public interface IMaster
    {
        KeyboardHook Hook { get; }
        HGameData GameData { get; }
        HConnection Connection { get; }

        HGame Game { get; set; }
        HHotel Hotel { get; set; }

        void Log(string message);
        void Log(Exception exception);
        void AssignQuickAction(Keys keyData, Action action);
    }
}