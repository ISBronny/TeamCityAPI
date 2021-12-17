namespace TeamCityAPI
{
    /// <summary>Represents a revision related to a VCS change.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Revision 
    {
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Version { get; set; }
    
        [Newtonsoft.Json.JsonProperty("internalVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InternalVersion { get; set; }
    
        [Newtonsoft.Json.JsonProperty("vcsBranchName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VcsBranchName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("vcs-root-instance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public VcsRootInstance VcsRootInstance { get; set; }
    
        [Newtonsoft.Json.JsonProperty("checkout-rules", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CheckoutRules { get; set; }
    
    
    }
}