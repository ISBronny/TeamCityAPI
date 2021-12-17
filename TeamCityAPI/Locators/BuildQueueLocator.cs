namespace TeamCityAPI
{
    /// <summary>Represents a locator string for filtering Build entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class BuildQueueLocator : Locator
    {
        /// <summary>Agent locator.</summary>
        [Newtonsoft.Json.JsonProperty("agent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AgentLocator Agent { get; set; }
    
        /// <summary>Build type locator.</summary>
        [Newtonsoft.Json.JsonProperty("buildType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildTypeLocator BuildType { get; set; }
    
        /// <summary>For paginated calls, how many entities to return per page.</summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Count { get; set; }
    
        /// <summary>Entity ID.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }
    
        /// <summary>Supply multiple locators and return a union of the results.</summary>
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Item { get; set; }
    
        /// <summary>Is personal.</summary>
        [Newtonsoft.Json.JsonProperty("personal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Personal { get; set; }
    
        /// <summary>Agent pool locator.</summary>
        [Newtonsoft.Json.JsonProperty("pool", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AgentPoolLocator Pool { get; set; }
    
        /// <summary>Project locator.</summary>
        [Newtonsoft.Json.JsonProperty("project", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProjectLocator Project { get; set; }
    
        /// <summary>For paginated calls, from which entity to start rendering the page.</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Start { get; set; }
    
        [Newtonsoft.Json.JsonProperty("taskId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TaskId { get; set; }
    
        /// <summary>User locator.</summary>
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UserLocator User { get; set; }
    
    
    }
}