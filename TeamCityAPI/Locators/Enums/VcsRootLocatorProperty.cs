namespace TeamCityAPI
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    public enum VcsRootLocatorProperty
    {
        [System.Runtime.Serialization.EnumMember(Value = @"exists")]
        Exists = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"not-exists")]
        NotExists = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"equals")]
        Equals = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"does-not-equal")]
        DoesNotEqual = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"starts-with")]
        StartsWith = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"contains")]
        Contains = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"does-not-contain")]
        DoesNotContain = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ends-with")]
        EndsWith = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"any")]
        Any = 8,
    
        [System.Runtime.Serialization.EnumMember(Value = @"matches")]
        Matches = 9,
    
        [System.Runtime.Serialization.EnumMember(Value = @"does-not-match")]
        DoesNotMatch = 10,
    
        [System.Runtime.Serialization.EnumMember(Value = @"more-than")]
        MoreThan = 11,
    
        [System.Runtime.Serialization.EnumMember(Value = @"no-more-than")]
        NoMoreThan = 12,
    
        [System.Runtime.Serialization.EnumMember(Value = @"less-than")]
        LessThan = 13,
    
        [System.Runtime.Serialization.EnumMember(Value = @"no-less-than")]
        NoLessThan = 14,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ver-more-than")]
        VerMoreThan = 15,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ver-no-more-than")]
        VerNoMoreThan = 16,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ver-less-than")]
        VerLessThan = 17,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ver-no-less-than")]
        VerNoLessThan = 18,
    
    }
}