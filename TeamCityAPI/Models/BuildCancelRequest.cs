namespace TeamCityAPI.Models
{
    /// <summary>Represents a cancel request for the specific build.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class BuildCancelRequest 
    {
        [Newtonsoft.Json.JsonProperty("comment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Comment { get; set; }
    
        [Newtonsoft.Json.JsonProperty("readdIntoQueue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ReaddIntoQueue { get; set; }
    
    
    }
}