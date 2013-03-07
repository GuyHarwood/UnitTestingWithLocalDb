namespace poc.webapi.Infrastructure
{
    public interface ICommandChannel
    {
        void Send(Command command);
    }
}