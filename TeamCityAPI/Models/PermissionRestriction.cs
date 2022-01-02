namespace TeamCityAPI.Models
{
    /// <summary>Represents permission restrictions of an authentication token.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class PermissionRestriction 
    {
        [Newtonsoft.Json.JsonProperty("isGlobalScope", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsGlobalScope { get; set; }
    
        [Newtonsoft.Json.JsonProperty("project", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Project Project { get; set; }
    
        [Newtonsoft.Json.JsonProperty("permission", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Permission Permission { get; set; }
    
    
    }
}