namespace TeamCityAPI
{
    /// <summary>Represents a paginated list of ProblemOccurrence entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ProblemOccurrences 
    {
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Count { get; set; }
    
        [Newtonsoft.Json.JsonProperty("href", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Href { get; set; }
    
        [Newtonsoft.Json.JsonProperty("nextHref", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NextHref { get; set; }
    
        [Newtonsoft.Json.JsonProperty("prevHref", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PrevHref { get; set; }
    
        [Newtonsoft.Json.JsonProperty("problemOccurrence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ProblemOccurrence> ProblemOccurrence { get; set; }
    
        [Newtonsoft.Json.JsonProperty("passed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Passed { get; set; }
    
        [Newtonsoft.Json.JsonProperty("failed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Failed { get; set; }
    
        [Newtonsoft.Json.JsonProperty("newFailed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NewFailed { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ignored", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Ignored { get; set; }
    
        [Newtonsoft.Json.JsonProperty("muted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Muted { get; set; }
    
    
    }
}