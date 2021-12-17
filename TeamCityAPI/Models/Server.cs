namespace TeamCityAPI
{
    /// <summary>Represents various details of this server including the installation version.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Server 
    {
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Version { get; set; }
    
        [Newtonsoft.Json.JsonProperty("versionMajor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? VersionMajor { get; set; }
    
        [Newtonsoft.Json.JsonProperty("versionMinor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? VersionMinor { get; set; }
    
        [Newtonsoft.Json.JsonProperty("startTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StartTime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("currentTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CurrentTime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("buildNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildNumber { get; set; }
    
        [Newtonsoft.Json.JsonProperty("buildDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("internalId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InternalId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("role", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Role { get; set; }
    
        [Newtonsoft.Json.JsonProperty("webUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WebUrl { get; set; }
    
        [Newtonsoft.Json.JsonProperty("projects", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Href Projects { get; set; }
    
        [Newtonsoft.Json.JsonProperty("vcsRoots", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Href VcsRoots { get; set; }
    
        [Newtonsoft.Json.JsonProperty("builds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Href Builds { get; set; }
    
        [Newtonsoft.Json.JsonProperty("users", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Href Users { get; set; }
    
        [Newtonsoft.Json.JsonProperty("userGroups", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Href UserGroups { get; set; }
    
        [Newtonsoft.Json.JsonProperty("agents", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Href Agents { get; set; }
    
        [Newtonsoft.Json.JsonProperty("buildQueue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Href BuildQueue { get; set; }
    
        [Newtonsoft.Json.JsonProperty("agentPools", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Href AgentPools { get; set; }
    
        [Newtonsoft.Json.JsonProperty("investigations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Href Investigations { get; set; }
    
        [Newtonsoft.Json.JsonProperty("mutes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Href Mutes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("artifactsUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ArtifactsUrl { get; set; }
    
    
    }
}