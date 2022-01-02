namespace TeamCityAPI.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ChangeExtendedStatus 
    {
        [Newtonsoft.Json.JsonProperty("cancelled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Cancelled { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pending", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pending { get; set; }
    
        [Newtonsoft.Json.JsonProperty("critical", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Critical { get; set; }
    
        [Newtonsoft.Json.JsonProperty("newTestsFailed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NewTestsFailed { get; set; }
    
        [Newtonsoft.Json.JsonProperty("successfull", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Successfull { get; set; }
    
        [Newtonsoft.Json.JsonProperty("compilationError", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CompilationError { get; set; }
    
        [Newtonsoft.Json.JsonProperty("notCritical", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NotCritical { get; set; }
    
        [Newtonsoft.Json.JsonProperty("runningSuccessfully", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RunningSuccessfully { get; set; }
    
    
    }
}