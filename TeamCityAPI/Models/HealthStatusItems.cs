namespace TeamCityAPI.Models
{
    /// <summary>Represents a paginated list of HealthItem entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class HealthStatusItems 
    {
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Count { get; set; }
    
        [Newtonsoft.Json.JsonProperty("healthItem", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<HealthItem> HealthItem { get; set; }
    
        [Newtonsoft.Json.JsonProperty("href", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Href { get; set; }
    
        [Newtonsoft.Json.JsonProperty("nextHref", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NextHref { get; set; }
    
        [Newtonsoft.Json.JsonProperty("prevHref", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PrevHref { get; set; }
    
    
    }
}