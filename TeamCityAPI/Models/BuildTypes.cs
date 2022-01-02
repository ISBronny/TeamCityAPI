using TeamCityAPI.Models.Common;

namespace TeamCityAPI.Models
{
    /// <summary>Represents a paginated list of BuildType entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class BuildTypes : Page<BuildType>
    {
        public override ICollection<BuildType> Value => BuildType;
    
        [Newtonsoft.Json.JsonProperty("buildType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BuildType> BuildType { get; set; }
    
    
    }
}