namespace TeamCityAPI
{
    /// <summary>Represents a build configuration run policy and included build configurations.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class CompatibilityPolicy 
    {
        [Newtonsoft.Json.JsonProperty("policy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Policy { get; set; }
    
        [Newtonsoft.Json.JsonProperty("buildTypes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildTypes BuildTypes { get; set; }
    
    
    }
}