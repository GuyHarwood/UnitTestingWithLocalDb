namespace poc.webapi.Infrastructure
{
    public interface IQueryHandler<in TQuery, out TResult> where TQuery : QueryBase
    {
        TResult Handle(TQuery query);
    }
}