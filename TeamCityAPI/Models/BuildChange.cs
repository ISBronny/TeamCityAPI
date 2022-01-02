namespace TeamCityAPI.Models
{
    /// <summary>Represents links to the next or previous build.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class BuildChange 
    {
        [Newtonsoft.Json.JsonProperty("nextBuild", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Build NextBuild { get; set; }
    
        [Newtonsoft.Json.JsonProperty("prevBuild", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Build PrevBuild { get; set; }
    
    
    }
}