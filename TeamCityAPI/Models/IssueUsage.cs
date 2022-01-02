namespace TeamCityAPI.Models
{
    /// <summary>Represents a relation between the issue and the Changes entity.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class IssueUsage 
    {
        [Newtonsoft.Json.JsonProperty("issue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Issue Issue { get; set; }
    
        [Newtonsoft.Json.JsonProperty("changes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Changes Changes { get; set; }
    
    
    }
}