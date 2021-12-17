namespace TeamCityAPI
{
    /// <summary>Represents a server health item.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class HealthItem 
    {
        [Newtonsoft.Json.JsonProperty("identity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("severity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HealthItemSeverity? Severity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("healthCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public HealthCategory HealthCategory { get; set; }
    
    
    }
}