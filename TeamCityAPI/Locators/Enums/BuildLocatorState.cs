using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace TeamCityAPI.Locators.Enums
{
    [GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum BuildLocatorState
    {
        [EnumMember(Value = @"queued")]
        Queued = 0,
    
        [EnumMember(Value = @"running")]
        Running = 1,
    
        [EnumMember(Value = @"finished")]
        Finished = 2,
    
        [EnumMember(Value = @"any")]
        Any = 3,
    
    }
}