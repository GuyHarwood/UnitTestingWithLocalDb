namespace poc.webapi.Infrastructure
{
    public abstract class Command
    {
        protected abstract bool Validate();
    }
}