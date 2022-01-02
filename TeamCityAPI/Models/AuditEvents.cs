using TeamCityAPI.Models.Common;

namespace TeamCityAPI.Models
{
    /// <summary>Represents a paginated list of AuditEvent entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class AuditEvents : Page<AuditEvent>
    {
        public override ICollection<AuditEvent> Value => AuditEvent;
    
        [Newtonsoft.Json.JsonProperty("auditEvent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AuditEvent> AuditEvent { get; set; }
    
    
    }
}