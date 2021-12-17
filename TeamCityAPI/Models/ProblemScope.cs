namespace TeamCityAPI
{
    /// <summary>Represents an investigation scope.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ProblemScope 
    {
        [Newtonsoft.Json.JsonProperty("project", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Project Project { get; set; }
    
        [Newtonsoft.Json.JsonProperty("buildTypes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildTypes BuildTypes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("buildType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildType BuildType { get; set; }
    
    
    }
}