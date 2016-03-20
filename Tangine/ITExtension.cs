using Sulakore.Communication;

namespace Tangine
{
    public interface ITExtension : ITService
    {
        HTriggers Triggers { get; }

        void HandleOutgoing(DataInterceptedEventArgs e);
        void HandleIncoming(DataInterceptedEventArgs e);
    }
}