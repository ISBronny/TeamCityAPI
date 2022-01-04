using TeamCityAPI.Locators.Common;
using TeamCityAPI.Models.Common;
using TeamCityAPI.Queries.Interfaces;

namespace TeamCityAPI.Queries;

internal class TcPagedQuery<TEntity> : TcBaseQuery<TEntity>, ITcPagedQuery<TEntity> where TEntity : Page
{
    PagedLocator ITcPagedQuery.Locator { get; set; } = new() {Count = 100, Start = 0};
    
    public TcPagedQuery(TeamCityClient client, Func<string, string, Task<TEntity>> requestMethod) : base(client, requestMethod)
    {
        
    }
    public ITcPagedQuery<TEntity> WithLocator(PagedLocator locator)
    {
        ((ITcPagedQuery<TEntity>) this).Locator = locator;
        return this;
    }

    public override async Task<TEntity> GetAsync()
    {
        var page = await ((ITcPagedQuery<TEntity>) this).RequestMethod(GetLocator(), GetFieldsUri());
        page.Client = ((IBaseQuery) this).Client;
        return page;
    }
    public async Task<TEntity> GetAsync(int perPage)
    {
        if (perPage <= 0) 
            throw new ArgumentOutOfRangeException(nameof(perPage));
        
        ((ITcPagedQuery<TEntity>) this).Locator.Count = perPage;
        var page = await ((ITcPagedQuery<TEntity>) this).RequestMethod(GetLocator(), GetFieldsUri());
        page.Client = ((IBaseQuery) this).Client;
        return page;
    }
    private string GetFieldsUri() => $"{String.Join(",", ((ITcPagedQuery) this).Fields.Select(f => f.ToString()))}";

    private string GetLocator()
    {
        return ((ITcPagedQuery<TEntity>) this).Locator?.ToString();
    }
        
    public override string ToString() => $"locator={GetLocator()}&fields={GetFieldsUri()}";
}