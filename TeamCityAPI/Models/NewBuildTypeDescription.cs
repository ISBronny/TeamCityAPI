namespace TeamCityAPI
{
    /// <summary>Represents a build configuration stub.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class NewBuildTypeDescription 
    {
        [Newtonsoft.Json.JsonProperty("copyAllAssociatedSettings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CopyAllAssociatedSettings { get; set; }
    
        [Newtonsoft.Json.JsonProperty("projectsIdsMap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Properties ProjectsIdsMap { get; set; }
    
        [Newtonsoft.Json.JsonProperty("buildTypesIdsMap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Properties BuildTypesIdsMap { get; set; }
    
        [Newtonsoft.Json.JsonProperty("vcsRootsIdsMap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Properties VcsRootsIdsMap { get; set; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("sourceBuildTypeLocator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceBuildTypeLocator { get; set; }
    
        [Newtonsoft.Json.JsonProperty("sourceBuildType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildType SourceBuildType { get; set; }
    
    
    }
}