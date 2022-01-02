using TeamCityAPI.Models.Common;

namespace TeamCityAPI.Queries.Interfaces
{
    public interface ITcIncludableQuery : ITcQuery
    {
        
    }
    public interface ITcIncludableQuery<TEntity, out TProperty> : ITcIncludableQuery, ITcQuery<TEntity> where TEntity : TcModel
    {
       
    }
}