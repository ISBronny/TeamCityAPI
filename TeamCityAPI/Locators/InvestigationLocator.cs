namespace TeamCityAPI
{
    /// <summary>Represents a locator string for filtering Investigation entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class InvestigationLocator : Locator
    {
        /// <summary>Project (direct or indirect parent) locator.</summary>
        [Newtonsoft.Json.JsonProperty("affectedProject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProjectLocator AffectedProject { get; set; }
    
        [Newtonsoft.Json.JsonProperty("assignee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Assignee { get; set; }
    
        /// <summary>Project (direct parent) locator.</summary>
        [Newtonsoft.Json.JsonProperty("assignmentProject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProjectLocator AssignmentProject { get; set; }
    
        /// <summary>Build type locator.</summary>
        [Newtonsoft.Json.JsonProperty("buildType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildTypeLocator BuildType { get; set; }
    
        /// <summary>For paginated calls, how many entities to return per page.</summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Count { get; set; }
    
        /// <summary>Supply multiple locators and return a union of the results.</summary>
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Item { get; set; }
    
        /// <summary>Limit processing to the latest `&lt;lookupLimit&gt;` entities.</summary>
        [Newtonsoft.Json.JsonProperty("lookupLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LookupLimit { get; set; }
    
        /// <summary>Problem locator.</summary>
        [Newtonsoft.Json.JsonProperty("problem", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProblemLocator Problem { get; set; }
    
        [Newtonsoft.Json.JsonProperty("reporter", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reporter { get; set; }
    
        [Newtonsoft.Json.JsonProperty("resolution", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InvestigationLocatorResolution? Resolution { get; set; }
    
        /// <summary>yyyyMMddTHHmmss+ZZZZ</summary>
        [Newtonsoft.Json.JsonProperty("sinceDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SinceDate { get; set; }
    
        /// <summary>For paginated calls, from which entity to start rendering the page.</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Start { get; set; }
    
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InvestigationLocatorState? State { get; set; }
    
        /// <summary>Test locator.</summary>
        [Newtonsoft.Json.JsonProperty("test", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TestLocator Test { get; set; }
    
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InvestigationLocatorType? Type { get; set; }
    
    
    }
}