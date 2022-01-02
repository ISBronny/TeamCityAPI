using TeamCityAPI.Models.Common;

namespace TeamCityAPI.Models
{
    /// <summary>Represents a paginated list of VcsRoot entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class VcsRoots : Page<VcsRoot>
    {
        public override ICollection<VcsRoot> Value => VcsRoot;
        
        [Newtonsoft.Json.JsonProperty("vcs-root", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<VcsRoot> VcsRoot { get; set; }
    
    
    }
}