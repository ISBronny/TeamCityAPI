namespace TeamCityAPI.Models
{
    /// <summary>Represents the specific file change (in the scope of the commit).</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class FileChange 
    {
        [Newtonsoft.Json.JsonProperty("before-revision", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BeforeRevision { get; set; }
    
        [Newtonsoft.Json.JsonProperty("after-revision", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AfterRevision { get; set; }
    
        [Newtonsoft.Json.JsonProperty("changeType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChangeType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("changeTypeComment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChangeTypeComment { get; set; }
    
        [Newtonsoft.Json.JsonProperty("file", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string File { get; set; }
    
        [Newtonsoft.Json.JsonProperty("relative-file", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RelativeFile { get; set; }
    
        [Newtonsoft.Json.JsonProperty("directory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Directory { get; set; }
    
    
    }
}