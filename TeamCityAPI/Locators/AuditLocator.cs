namespace TeamCityAPI
{
    /// <summary>Represents a locator string for filtering AuditEvent entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class AuditLocator : Locator
    {
        /// <summary>Use `$help` to get the full list of supported actions.</summary>
        [Newtonsoft.Json.JsonProperty("action", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Action { get; set; }
    
        /// <summary>Related project locator.</summary>
        [Newtonsoft.Json.JsonProperty("affectedProject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProjectLocator AffectedProject { get; set; }
    
        /// <summary>Related build type or template locator.</summary>
        [Newtonsoft.Json.JsonProperty("buildType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildTypeLocator BuildType { get; set; }
    
        /// <summary>For paginated calls, how many entities to return per page.</summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Count { get; set; }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        /// <summary>Supply multiple locators and return a union of the results.</summary>
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Item { get; set; }
    
        /// <summary>Limit processing to the latest `&lt;lookupLimit&gt;` entities.</summary>
        [Newtonsoft.Json.JsonProperty("lookupLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LookupLimit { get; set; }
    
        /// <summary>For paginated calls, from which entity to start rendering the page.</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Start { get; set; }
    
        [Newtonsoft.Json.JsonProperty("systemAction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SystemAction { get; set; }
    
        /// <summary>Locator of user who caused the audit event.</summary>
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UserLocator User { get; set; }
    
    
    }
}