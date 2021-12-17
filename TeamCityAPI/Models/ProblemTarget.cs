namespace TeamCityAPI
{
    /// <summary>Represents an investigation target.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ProblemTarget 
    {
        [Newtonsoft.Json.JsonProperty("anyProblem", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AnyProblem { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tests", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Tests Tests { get; set; }
    
        [Newtonsoft.Json.JsonProperty("problems", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Problems Problems { get; set; }
    
    
    }
}