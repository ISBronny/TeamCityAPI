namespace TeamCityAPI.Models
{
    /// <summary>Represents build customization settings of a trigger</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class BuildTriggerCustomization 
    {
        [Newtonsoft.Json.JsonProperty("enforceCleanCheckout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? EnforceCleanCheckout { get; set; }
    
        [Newtonsoft.Json.JsonProperty("enforceCleanCheckoutForDependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? EnforceCleanCheckoutForDependencies { get; set; }
    
        [Newtonsoft.Json.JsonProperty("parameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Properties Parameters { get; set; }
    
    
    }
}