using TeamCityAPI.Models.Common;

namespace TeamCityAPI.Queries.Interfaces;

public interface ITcPagedIncludableQuery : ITcPagedQuery
{
    
}

public interface ITcPagedIncludableQuery<TEntity, out TProperty> : ITcPagedIncludableQuery, ITcPagedQuery<TEntity> where TEntity : Page
{
       
}