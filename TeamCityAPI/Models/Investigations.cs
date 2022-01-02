using TeamCityAPI.Models.Common;

namespace TeamCityAPI.Models
{
    /// <summary>Represents a paginated list of Investigation entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Investigations : Page<Investigation>
    {
        public override ICollection<Investigation> Value => Investigation;
    
        [Newtonsoft.Json.JsonProperty("investigation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Investigation> Investigation { get; set; }
    
    
    }
}