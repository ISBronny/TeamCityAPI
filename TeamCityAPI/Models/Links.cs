﻿namespace TeamCityAPI.Models
{
    /// <summary>Represents a list of Link entities.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Links 
    {
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Count { get; set; }
    
        [Newtonsoft.Json.JsonProperty("link", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Link> Link { get; set; }
    
    
    }
}