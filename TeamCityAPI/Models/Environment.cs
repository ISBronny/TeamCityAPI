namespace TeamCityAPI.Models
{
    /// <summary>Represents the details of the agent's OS.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Environment 
    {
        [Newtonsoft.Json.JsonProperty("osType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OsType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("osName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OsName { get; set; }
    
    
    }
}