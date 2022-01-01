using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamCityAPI.Serializer;

namespace TeamCityAPI.Query
{
    internal class TcQuery : ITcQuery
    {
        TeamCityClient ITcQuery.Client { get; set; }
        List<Field> ITcQuery.Fields { get; set; } = new List<Field>();
        Field ITcQuery.CurrentField { get; set; }


        public TcQuery(TeamCityClient client)
        {
            ((ITcQuery) this).Client = client;
            //((ITcQuery) this).Settings = settings ?? new TcQuerySettings();
            
            switch ( ((ITcQuery) this).Client.Settings.DefaultIncludeType)
            {
                case IncludeType.Short:
                    ((ITcQuery) this).Fields.Add(Field.Short);
                    break;
                case IncludeType.Long:
                    ((ITcQuery) this).Fields.Add(Field.Long);
                    break;
            }
        }
    }
    internal class TcQuery<TEntity> : TcQuery, ITcQuery<TEntity> where TEntity : class
    {
        Locator ITcQuery<TEntity>.Locator { get; set; }
        Func<string, string, Task<TEntity>> ITcQuery<TEntity>.RequestMethod { get; set; }
        public TcQuery(TeamCityClient client, Func<string,string,Task<TEntity>> requestMethod) : base(client)
        {
            ((ITcQuery<TEntity>) this).RequestMethod = requestMethod;
        }

        public ITcQuery<TEntity> WithLocator(Locator locator)
        {
            ((ITcQuery<TEntity>) this).Locator = locator;
            return this;
        }

        public async Task<TEntity> GetAsync()
        {
            return await ((ITcQuery<TEntity>) this).RequestMethod(GetLocator(), GetFieldsUri());
        }

        private string GetFieldsUri() => $"{String.Join(",", ((ITcQuery) this).Fields.Select(f => f.ToString()))}";

        private string GetLocator()
        {
            return ((ITcQuery<TEntity>) this).Locator?.ToString();
        }
        
        public override string ToString() => $"locator={GetLocator()}&fields={GetFieldsUri()}";

    }
    
}