namespace TeamCityAPI.Models
{
    /// <summary>Represents build customizations (artifact dependency overrides, custom parameters or changesets).</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Customizations 
    {
        [Newtonsoft.Json.JsonProperty("parameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }
    
        [Newtonsoft.Json.JsonProperty("changes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Changes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("artifactDependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> ArtifactDependencies { get; set; }
    
    
    }
}