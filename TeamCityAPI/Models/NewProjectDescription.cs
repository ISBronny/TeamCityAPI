namespace TeamCityAPI.Models
{
    /// <summary>Represents a project stub.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class NewProjectDescription 
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
    
        [Newtonsoft.Json.JsonProperty("sourceProjectLocator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceProjectLocator { get; set; }
    
        [Newtonsoft.Json.JsonProperty("sourceProject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Project SourceProject { get; set; }
    
        [Newtonsoft.Json.JsonProperty("parentProject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Project ParentProject { get; set; }
    
    
    }
}