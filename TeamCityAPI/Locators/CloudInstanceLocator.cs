namespace TeamCityAPI
{
    /// <summary>Represents a locator string for filtering CloudInstance entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class CloudInstanceLocator : Locator
    {
        /// <summary>Project (direct or indirect parent) locator.</summary>
        [Newtonsoft.Json.JsonProperty("affectedProject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProjectLocator AffectedProject { get; set; }
    
        /// <summary>Agent locator.</summary>
        [Newtonsoft.Json.JsonProperty("agent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AgentLocator Agent { get; set; }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        /// <summary>Cloud image locator.</summary>
        [Newtonsoft.Json.JsonProperty("instance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CloudImageLocator Instance { get; set; }
    
        /// <summary>Supply multiple locators and return a union of the results.</summary>
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Item { get; set; }
    
        [Newtonsoft.Json.JsonProperty("networkAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NetworkAddress { get; set; }
    
        /// <summary>Cloud profile locator.</summary>
        [Newtonsoft.Json.JsonProperty("profile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CloudProfileLocator Profile { get; set; }
    
        /// <summary>Project locator.</summary>
        [Newtonsoft.Json.JsonProperty("project", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProjectLocator Project { get; set; }
    
        [Newtonsoft.Json.JsonProperty("property", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CloudInstanceLocatorProperty? Property { get; set; }
    
    
    }
}