using System.Collections;
using TeamCityAPI.Locators.Common;

namespace TeamCityAPI.Models.Common;

public abstract class Page : TcModel
{
    internal TeamCityClient Client;
    private PagedLocator PagedLocator { get; } = new PagedLocator() {Count = 100, Start = 0};

    public Page()
    {
        
    }
    public Page(TeamCityClient client, PagedLocator pagedLocator)
    {
        PagedLocator = pagedLocator;
        Client = client;
    }
}

public abstract class Page<T> : Page, IAsyncEnumerable<Page<T>>  where T : TcModel
{
    public Page()
    {
        
    }
    
    public Page(TeamCityClient client, PagedLocator pagedLocator) : base(client, pagedLocator)
    {
    }

    [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? Count { get; set; }
    
    [Newtonsoft.Json.JsonProperty("nextHref", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string NextHref { get; set; }
    
    [Newtonsoft.Json.JsonProperty("prevHref", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string PrevHref { get; set; }

    public async Task<Page<T>> GetNextAsync()
    {
        var page = await Client.GetPage<Page<T>>(NextHref, GetType());
        page.Client = Client;
        return page;
    }

    public async Task<Page<T>> GetPrevAsync()
    {
        var page = await Client.GetPage<Page<T>>(PrevHref, GetType());
        page.Client = Client;
        return page;
    }
    
    public abstract ICollection<T> Value { get; }

    public IAsyncEnumerator<Page<T>> GetAsyncEnumerator(CancellationToken cancellationToken = new CancellationToken())
    {
        return new PageEnumerator<T>(this);
    }
}

public class PageEnumerator<T> : IAsyncEnumerator<Page<T>> where T : TcModel
{
    public PageEnumerator(Page<T> current)
    {
        Current = current;
    }

    public ValueTask DisposeAsync()
    {
        return default;
    }

    public async ValueTask<bool> MoveNextAsync()
    {
        Current = await Current.GetNextAsync();
        if (Current == null)
            return false;
        if (Current.Count == 0)
            return false;
        return true;
    }

    public Page<T> Current { get; private set; }
}