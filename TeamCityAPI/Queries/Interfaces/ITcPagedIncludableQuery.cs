using TeamCityAPI.Models.Common;

namespace TeamCityAPI.Queries.Interfaces;

public interface ITcPagedIncludableQuery : ITcPagedQuery, IBaseIncludableQuery
{
    
}

public interface ITcPagedIncludableQuery<TEntity, out TProperty> : IBaseIncludableQuery<TEntity, TProperty>, ITcPagedIncludableQuery, ITcPagedQuery<TEntity> where TEntity : Page
{
       
}