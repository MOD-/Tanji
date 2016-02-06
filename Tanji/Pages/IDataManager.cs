using Sulakore.Communication;

namespace Tanji.Pages
{
    public interface IDataManager
    {
        HConnection Connection { get; }

        void AddDataHandler(IDataHandler dataHandler);
        void RemoveDataHandler(IDataHandler dataHandler);
    }
}