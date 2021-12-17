namespace TeamCityAPI.Query
{
    public class TcQuerySettings
    {
        public IncludeType DefaultIncludeType { get; set; } = IncludeType.Short;
    }
    
    public enum IncludeType
    {
        Long,
        Short,
        None
    }
}