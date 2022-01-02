namespace TeamCityAPI.Locators.Common;

public class PagedLocator : Locator
{
    /// <summary>For paginated calls, how many entities to return per page.</summary>
    [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? Count { get; set; }
    
    /// <summary>For paginated calls, from which entity to start rendering the page.</summary>
    [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int? Start { get; set; }
}