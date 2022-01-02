using TeamCityAPI.Models.Common;

namespace TeamCityAPI.Models
{
    /// <summary>Represents a paginated list of TestOccurrence entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class TestOccurrences : Page<TestOccurrence>
    {
        public override ICollection<TestOccurrence> Value => TestOccurrence;

        [Newtonsoft.Json.JsonProperty("testOccurrence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TestOccurrence> TestOccurrence { get; set; }
    
        [Newtonsoft.Json.JsonProperty("testCounters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TestCounters TestCounters { get; set; }
    
        [Newtonsoft.Json.JsonProperty("failed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Failed { get; set; }
    
        [Newtonsoft.Json.JsonProperty("muted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Muted { get; set; }
    
        [Newtonsoft.Json.JsonProperty("passed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Passed { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ignored", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Ignored { get; set; }
    
        [Newtonsoft.Json.JsonProperty("newFailed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NewFailed { get; set; }
    
    
    }
}