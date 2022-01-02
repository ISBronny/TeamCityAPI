using TeamCityAPI.Models.Common;

namespace TeamCityAPI.Models
{
    /// <summary>Represents a paginated list of Agent entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Agents : Page<Agent>
    {
        public override ICollection<Agent> Value => Agent;
    
        [Newtonsoft.Json.JsonProperty("agent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Agent> Agent { get; set; }
    
    
    }
}