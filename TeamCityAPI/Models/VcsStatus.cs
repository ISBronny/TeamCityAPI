namespace TeamCityAPI
{
    /// <summary>Represents links to the last or previous VCS root check.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class VcsStatus 
    {
        [Newtonsoft.Json.JsonProperty("current", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public VcsCheckStatus Current { get; set; }
    
        [Newtonsoft.Json.JsonProperty("previous", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public VcsCheckStatus Previous { get; set; }
    
    
    }
}