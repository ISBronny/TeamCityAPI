namespace TeamCityAPI.Models
{
    /// <summary>Represents the dependency/queue settings with which this build has been started.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class BuildTriggeringOptions 
    {
        [Newtonsoft.Json.JsonProperty("cleanSources", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CleanSources { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cleanSourcesInAllDependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CleanSourcesInAllDependencies { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rebuildAllDependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? RebuildAllDependencies { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rebuildFailedOrIncompleteDependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? RebuildFailedOrIncompleteDependencies { get; set; }
    
        [Newtonsoft.Json.JsonProperty("queueAtTop", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? QueueAtTop { get; set; }
    
        [Newtonsoft.Json.JsonProperty("freezeSettings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? FreezeSettings { get; set; }
    
        [Newtonsoft.Json.JsonProperty("tagDependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? TagDependencies { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rebuildDependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildTypes RebuildDependencies { get; set; }
    
    
    }
}