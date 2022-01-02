using TeamCityAPI.Models.Common;

namespace TeamCityAPI.Queries.Interfaces;

public interface IBaseIncludableQuery : IBaseQuery
{
        
}

public interface IBaseIncludableQuery<TEntity, out TProperty> : IBaseIncludableQuery, IBaseQuery<TEntity> where TEntity : TcModel
{
       
}