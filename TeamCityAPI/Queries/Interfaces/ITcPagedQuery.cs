using TeamCityAPI.Locators.Common;
using TeamCityAPI.Models.Common;

namespace TeamCityAPI.Queries.Interfaces;

public interface ITcPagedQuery : IBaseQuery
{
    internal PagedLocator Locator { get; set; }
}
public interface ITcPagedQuery<TEntity> : ITcPagedQuery, IBaseQuery<TEntity> where TEntity : Page
{
    public ITcPagedQuery<TEntity> WithLocator(PagedLocator locator);
    public Task<TEntity> GetAsync(int perPage = 100);
}