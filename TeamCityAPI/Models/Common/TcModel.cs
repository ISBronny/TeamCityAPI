namespace TeamCityAPI.Models.Common;

public abstract class TcModel
{
    [Newtonsoft.Json.JsonProperty("href", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Href { get; set; }
}