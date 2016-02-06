using Sulakore.Communication;

namespace Tanji.Pages
{
    public interface IDataHandler
    {
        bool IsHandlingOutgoing { get; }
        bool IsHandlingIncoming { get; }

        void HandleOutgoing(InterceptedEventArgs e);
        void HandleIncoming(InterceptedEventArgs e);
    }
}