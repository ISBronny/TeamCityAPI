namespace TeamCityAPI.Query
{
    public interface ITcIncludableQuery : ITcQuery
    {
        
    }
    public interface ITcIncludableQuery<TEntity, out TProperty> : ITcIncludableQuery, ITcQuery<TEntity> where TEntity : class
    {
       
    }
}