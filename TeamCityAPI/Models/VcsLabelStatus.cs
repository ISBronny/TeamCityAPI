namespace TeamCityAPI
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum VcsLabelStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"none")]
        None = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"set")]
        Set = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"is being set")]
        Is_being_set = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"failed")]
        Failed = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"disabled for the vcs root")]
        Disabled_for_the_vcs_root = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"not supported yet for the vcs")]
        Not_supported_yet_for_the_vcs = 5,
    
    }
}