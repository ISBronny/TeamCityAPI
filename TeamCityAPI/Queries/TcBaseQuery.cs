using TeamCityAPI.Models.Common;
using TeamCityAPI.Queries.Common;
using TeamCityAPI.Queries.Interfaces;

namespace TeamCityAPI.Queries;

internal abstract class TcBaseQuery : IBaseQuery
{
    TeamCityClient IBaseQuery.Client { get; set; }
    List<Field> IBaseQuery.Fields { get; set; } = new List<Field>();
    Field IBaseQuery.CurrentField { get; set; }


    public TcBaseQuery(TeamCityClient client)
    {
        ((IBaseQuery) this).Client = client;
        //((ITcQuery) this).Settings = settings ?? new TcQuerySettings();
            
        switch ( ((IBaseQuery) this).Client.Settings.DefaultIncludeType)
        {
            case IncludeType.Short:
                ((IBaseQuery) this).Fields.Add(Field.Short);
                break;
            case IncludeType.Long:
                ((IBaseQuery) this).Fields.Add(Field.Long);
                break;
        }
    }
}
internal abstract class TcBaseQuery<TEntity> : TcBaseQuery, IBaseQuery<TEntity> where TEntity : TcModel
{
        
    Func<string, string, Task<TEntity>> IBaseQuery<TEntity>.RequestMethod { get; set; }
    public TcBaseQuery(TeamCityClient client, Func<string,string,Task<TEntity>> requestMethod) : base(client)
    {
        ((IBaseQuery<TEntity>) this).RequestMethod = requestMethod;
    }

    public abstract Task<TEntity> GetAsync();
    

    private string GetFieldsUri() => $"{String.Join(",", ((IBaseQuery) this).Fields.Select(f => f.ToString()))}";
    

}