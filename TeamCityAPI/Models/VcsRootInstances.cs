using TeamCityAPI.Models.Common;

namespace TeamCityAPI.Models
{
    /// <summary>Represents a paginated list of VcsRootInstance entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class VcsRootInstances : Page<VcsRootInstance>
    {
        public override ICollection<VcsRootInstance> Value => VcsRootInstance;
    
        [Newtonsoft.Json.JsonProperty("vcs-root-instance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<VcsRootInstance> VcsRootInstance { get; set; }
    
    
    }
}