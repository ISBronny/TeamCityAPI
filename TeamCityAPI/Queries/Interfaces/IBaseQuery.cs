using TeamCityAPI.Models.Common;
using TeamCityAPI.Queries.Common;

namespace TeamCityAPI.Queries.Interfaces;

public interface IBaseQuery
{
    internal TeamCityClient Client { get; set; }
    internal List<Field> Fields { get; set; }
    internal Field CurrentField { get; set; }
}

public interface IBaseQuery<TEntity> : IBaseQuery where TEntity : TcModel
{
    internal Func<string, string, Task<TEntity>> RequestMethod { get; set; }
    public Task<TEntity> GetAsync();
}