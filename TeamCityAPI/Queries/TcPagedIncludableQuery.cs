using System.Reflection;
using TeamCityAPI.Locators.Common;
using TeamCityAPI.Models.Common;
using TeamCityAPI.Queries.Common;
using TeamCityAPI.Queries.Interfaces;

namespace TeamCityAPI.Queries;

internal class TcPagedIncludableQuery<TEntity, TProperty> : TcBaseIncludableQuery<TEntity, TProperty>, ITcPagedIncludableQuery<TEntity, TProperty> where TEntity : Page
{
    PagedLocator ITcPagedQuery.Locator { get; set; } = new() {Count = 100, Start = 0};
    public TcPagedIncludableQuery(ITcPagedQuery tcQuery, PropertyInfo property, IncludeType? includeType = null) : base(tcQuery, property, includeType)
    {
        ((ITcPagedQuery) this).Locator = tcQuery.Locator;
    }

    internal TcPagedIncludableQuery(ITcPagedIncludableQuery tcIncludableQuery, PropertyInfo property, IncludeType? includeType) : base(tcIncludableQuery, property, includeType)
    {
        ((ITcPagedQuery) this).Locator = tcIncludableQuery.Locator;
    }

    public ITcPagedQuery<TEntity> WithLocator(PagedLocator locator)
    {
        ((ITcPagedQuery<TEntity>) this).Locator = locator;
        return this;
    }

    public override async Task<TEntity> GetAsync()
    {
        return await ((ITcPagedQuery<TEntity>) this).RequestMethod(GetLocator(), GetFieldsUri());
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