namespace TeamCityAPI
{
    /// <summary>Represents a locator string for filtering Problem entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ProblemLocator : Locator
    {
        /// <summary>Project (direct or indirect parent) locator.</summary>
        [Newtonsoft.Json.JsonProperty("affectedProject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProjectLocator AffectedProject { get; set; }
    
        /// <summary>Build locator.</summary>
        [Newtonsoft.Json.JsonProperty("build", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildLocator Build { get; set; }
    
        /// <summary>For paginated calls, how many entities to return per page.</summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Count { get; set; }
    
        /// <summary>Is currently failing.</summary>
        [Newtonsoft.Json.JsonProperty("currentlyFailing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CurrentlyFailing { get; set; }
    
        /// <summary>Is currently investigated.</summary>
        [Newtonsoft.Json.JsonProperty("currentlyInvestigated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CurrentlyInvestigated { get; set; }
    
        /// <summary>Is currently muted.</summary>
        [Newtonsoft.Json.JsonProperty("currentlyMuted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CurrentlyMuted { get; set; }
    
        /// <summary>Entity ID.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("identity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Identity { get; set; }
    
        /// <summary>Supply multiple locators and return a union of the results.</summary>
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Item { get; set; }
    
        /// <summary>Limit processing to the latest `&lt;lookupLimit&gt;` entities.</summary>
        [Newtonsoft.Json.JsonProperty("lookupLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LookupLimit { get; set; }
    
        /// <summary>For paginated calls, from which entity to start rendering the page.</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Start { get; set; }
    
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }
    
    
    }
}