namespace TeamCityAPI.Models
{
    /// <summary>Represents license state details (available build configurations, agents, etc.).</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class LicensingData 
    {
        [Newtonsoft.Json.JsonProperty("licenseUseExceeded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? LicenseUseExceeded { get; set; }
    
        [Newtonsoft.Json.JsonProperty("maxAgents", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxAgents { get; set; }
    
        [Newtonsoft.Json.JsonProperty("unlimitedAgents", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? UnlimitedAgents { get; set; }
    
        [Newtonsoft.Json.JsonProperty("maxBuildTypes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxBuildTypes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("unlimitedBuildTypes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? UnlimitedBuildTypes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("buildTypesLeft", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BuildTypesLeft { get; set; }
    
        [Newtonsoft.Json.JsonProperty("serverLicenseType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LicensingDataServerLicenseType? ServerLicenseType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("serverEffectiveReleaseDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ServerEffectiveReleaseDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("agentsLeft", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AgentsLeft { get; set; }
    
        [Newtonsoft.Json.JsonProperty("licenseKeys", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LicenseKeys LicenseKeys { get; set; }
    
    
    }
}