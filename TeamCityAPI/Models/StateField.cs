namespace TeamCityAPI.Models
{
    /// <summary>Represents a project state field (as of now, limited to the read-only state of project).</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class StateField 
    {
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Value { get; set; }
    
        [Newtonsoft.Json.JsonProperty("inherited", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Inherited { get; set; }
    
    
    }
}