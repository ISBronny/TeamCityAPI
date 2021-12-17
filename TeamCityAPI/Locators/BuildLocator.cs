namespace TeamCityAPI
{
    /// <summary>Represents a locator string for filtering Build entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class BuildLocator : Locator
    {
        /// <summary>Project (direct or indirect parent) locator.</summary>
        [Newtonsoft.Json.JsonProperty("affectedProject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProjectLocator AffectedProject { get; set; }
    
        /// <summary>Agent locator.</summary>
        [Newtonsoft.Json.JsonProperty("agent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AgentLocator Agent { get; set; }
    
        /// <summary>typeId of agent used to execute build.</summary>
        [Newtonsoft.Json.JsonProperty("agentTypeId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AgentTypeId { get; set; }
    
        /// <summary>State can be any.</summary>
        [Newtonsoft.Json.JsonProperty("any", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Any { get; set; }
    
        [Newtonsoft.Json.JsonProperty("artifactDependency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ArtifactDependency { get; set; }
    
        /// <summary>Branch locator.</summary>
        [Newtonsoft.Json.JsonProperty("branch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BranchLocator Branch { get; set; }
    
        /// <summary>Build type locator.</summary>
        [Newtonsoft.Json.JsonProperty("buildType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildTypeLocator BuildType { get; set; }
    
        /// <summary>Is canceled.</summary>
        [Newtonsoft.Json.JsonProperty("canceled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Canceled { get; set; }
    
        /// <summary>Agent locator.</summary>
        [Newtonsoft.Json.JsonProperty("compatibleAgent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AgentLocator CompatibleAgent { get; set; }
    
        /// <summary>Is composite.</summary>
        [Newtonsoft.Json.JsonProperty("composite", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Composite { get; set; }
    
        /// <summary>For paginated calls, how many entities to return per page.</summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Count { get; set; }
    
        /// <summary>If true, applies default filter which returns only "normal" builds (finished builds which are not canceled, not failed-to-start, not personal, and on default branch (in branched build configurations)).</summary>
        [Newtonsoft.Json.JsonProperty("defaultFilter", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DefaultFilter { get; set; }
    
        /// <summary>Is failed to start.</summary>
        [Newtonsoft.Json.JsonProperty("failedToStart", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? FailedToStart { get; set; }
    
        /// <summary>Requires either date or build dimension.</summary>
        [Newtonsoft.Json.JsonProperty("finishDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FinishDate { get; set; }
    
        /// <summary>Is finished.</summary>
        [Newtonsoft.Json.JsonProperty("finished", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Finished { get; set; }
    
        /// <summary>Is hanging.</summary>
        [Newtonsoft.Json.JsonProperty("hanging", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Hanging { get; set; }
    
        /// <summary>Is history build.</summary>
        [Newtonsoft.Json.JsonProperty("history", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? History { get; set; }
    
        /// <summary>Entity ID.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }
    
        /// <summary>Supply multiple locators and return a union of the results.</summary>
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Item { get; set; }
    
        /// <summary>Limit processing to the latest `&lt;lookupLimit&gt;` entities.</summary>
        [Newtonsoft.Json.JsonProperty("lookupLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LookupLimit { get; set; }
    
        [Newtonsoft.Json.JsonProperty("number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Number { get; set; }
    
        /// <summary>Is a personal build.</summary>
        [Newtonsoft.Json.JsonProperty("personal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Personal { get; set; }
    
        /// <summary>Is pinned.</summary>
        [Newtonsoft.Json.JsonProperty("pinned", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Pinned { get; set; }
    
        /// <summary>Project (direct parent) locator.</summary>
        [Newtonsoft.Json.JsonProperty("project", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProjectLocator Project { get; set; }
    
        [Newtonsoft.Json.JsonProperty("property", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BuildLocatorProperty? Property { get; set; }
    
        /// <summary>Is queued.</summary>
        [Newtonsoft.Json.JsonProperty("queued", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Queued { get; set; }
    
        /// <summary>Requires either date or build dimension.</summary>
        [Newtonsoft.Json.JsonProperty("queuedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string QueuedDate { get; set; }
    
        /// <summary>Is running.</summary>
        [Newtonsoft.Json.JsonProperty("running", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Running { get; set; }
    
        [Newtonsoft.Json.JsonProperty("snapshotDependency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SnapshotDependency { get; set; }
    
        /// <summary>For paginated calls, from which entity to start rendering the page.</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Start { get; set; }
    
        /// <summary>Requires either date or build dimension.</summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StartDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BuildLocatorState? State { get; set; }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; }
    
        /// <summary>Tag locator.</summary>
        [Newtonsoft.Json.JsonProperty("tag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TagLocator Tag { get; set; }
    
        /// <summary>ID of a build or build promotion.</summary>
        [Newtonsoft.Json.JsonProperty("taskId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TaskId { get; set; }
    
        /// <summary>User locator.</summary>
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UserLocator User { get; set; }
    
    
    }
}