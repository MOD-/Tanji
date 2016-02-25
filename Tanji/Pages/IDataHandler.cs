using Sulakore.Communication;

namespace Tanji.Pages
{
    public interface IDataHandler
    {
        bool IsHandlingOutgoing { get; }
        bool IsHandlingIncoming { get; }

        void HandleOutgoing(DataInterceptedEventArgs e);
        void HandleIncoming(DataInterceptedEventArgs e);
    }
}