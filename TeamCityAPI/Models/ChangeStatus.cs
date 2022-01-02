namespace TeamCityAPI.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ChangeStatus 
    {
        [Newtonsoft.Json.JsonProperty("runningBuilds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RunningBuilds { get; set; }
    
        [Newtonsoft.Json.JsonProperty("failedBuilds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? FailedBuilds { get; set; }
    
        [Newtonsoft.Json.JsonProperty("finishedBuilds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? FinishedBuilds { get; set; }
    
        [Newtonsoft.Json.JsonProperty("successfulBuilds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SuccessfulBuilds { get; set; }
    
        [Newtonsoft.Json.JsonProperty("extendedStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ChangeExtendedStatus ExtendedStatus { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pendingBuildTypes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PendingBuildTypes { get; set; }
    
    
    }
}