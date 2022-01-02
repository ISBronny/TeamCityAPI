namespace TeamCityAPI.Models
{
    /// <summary>Represents test metadata (package, method, class, and so on).</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ParsedTestName 
    {
        [Newtonsoft.Json.JsonProperty("testPackage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TestPackage { get; set; }
    
        [Newtonsoft.Json.JsonProperty("testSuite", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TestSuite { get; set; }
    
        [Newtonsoft.Json.JsonProperty("testClass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TestClass { get; set; }
    
        [Newtonsoft.Json.JsonProperty("testShortName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TestShortName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("testNameWithoutPrefix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TestNameWithoutPrefix { get; set; }
    
        [Newtonsoft.Json.JsonProperty("testMethodName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TestMethodName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("testNameWithParameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TestNameWithParameters { get; set; }
    
    
    }
}