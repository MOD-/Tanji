using Tangine.Habbo;

using Sulakore.Modules;
using Sulakore.Habbo.Web;

namespace Tangine
{
    public interface ITService : IModule
    {
        void ModifyClient(HGame game);
        void ModifyGameData(HGameData gameData);
    }
}