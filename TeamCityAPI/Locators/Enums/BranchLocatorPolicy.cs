namespace TeamCityAPI
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum BranchLocatorPolicy
    {
        [System.Runtime.Serialization.EnumMember(Value = @"VCS_BRANCHES")]
        VCS_BRANCHES = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACTIVE_VCS_BRANCHES")]
        ACTIVE_VCS_BRANCHES = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"HISTORY_BRANCHES")]
        HISTORY_BRANCHES = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACTIVE_HISTORY_BRANCHES")]
        ACTIVE_HISTORY_BRANCHES = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACTIVE_HISTORY_AND_ACTIVE_VCS_BRANCHES")]
        ACTIVE_HISTORY_AND_ACTIVE_VCS_BRANCHES = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ALL_BRANCHES")]
        ALL_BRANCHES = 5,
    
    }
}