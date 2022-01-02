namespace TeamCityAPI.Models
{
    /// <summary>Represents a compatibility relation between the agent and build configuration.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Compatibility 
    {
        [Newtonsoft.Json.JsonProperty("compatible", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Compatible { get; set; }
    
        [Newtonsoft.Json.JsonProperty("agent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Agent Agent { get; set; }
    
        [Newtonsoft.Json.JsonProperty("buildType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildType BuildType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("unmetRequirements", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Requirements UnmetRequirements { get; set; }
    
    
    }
}