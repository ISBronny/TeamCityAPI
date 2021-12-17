namespace TeamCityAPI
{
    /// <summary>Represents a progress estimate of this build.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ProgressInfo 
    {
        [Newtonsoft.Json.JsonProperty("percentageComplete", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PercentageComplete { get; set; }
    
        [Newtonsoft.Json.JsonProperty("elapsedSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ElapsedSeconds { get; set; }
    
        [Newtonsoft.Json.JsonProperty("estimatedTotalSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? EstimatedTotalSeconds { get; set; }
    
        [Newtonsoft.Json.JsonProperty("leftSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? LeftSeconds { get; set; }
    
        [Newtonsoft.Json.JsonProperty("currentStageText", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CurrentStageText { get; set; }
    
        [Newtonsoft.Json.JsonProperty("outdated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Outdated { get; set; }
    
        [Newtonsoft.Json.JsonProperty("probablyHanging", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ProbablyHanging { get; set; }
    
        [Newtonsoft.Json.JsonProperty("lastActivityTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastActivityTime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("outdatedReasonBuild", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Build OutdatedReasonBuild { get; set; }
    
    
    }
}