using System.Reflection;
using TeamCityAPI.Locators.Common;
using TeamCityAPI.Models.Common;
using TeamCityAPI.Queries.Common;
using TeamCityAPI.Queries.Interfaces;

namespace TeamCityAPI.Queries
{
    // public class TcIncludableQuery : TcQuery, ITcIncludableQuery
    // {
    //     public TcIncludableQuery(TeamCityClient client) : base(client)
    //     {
    //     }
    //
    // }
    internal class TcIncludableQuery<TEntity, TProperty> : TcBaseIncludableQuery<TEntity, TProperty>, ITcIncludableQuery<TEntity, TProperty> where TEntity : TcModel
    {
        Locator ITcQuery.Locator { get; set; }
        public TcIncludableQuery(ITcQuery tcQuery, PropertyInfo property, IncludeType? includeType = null) : base(tcQuery, property, includeType)
        {
            ((ITcQuery) this).Locator = tcQuery.Locator;
        }

        internal TcIncludableQuery(ITcIncludableQuery tcIncludableQuery, PropertyInfo property, IncludeType? includeType) : base(tcIncludableQuery, property, includeType)
        {
            ((ITcQuery) this).Locator = tcIncludableQuery.Locator;
        }

        public override async Task<TEntity> GetAsync()
        {
            return await ((ITcQuery<TEntity>) this).RequestMethod(GetLocator(), GetFieldsUri());
        }

        public ITcQuery<TEntity> WithLocator(Locator locator)
        {
            ((ITcQuery<TEntity>) this).Locator = locator;
            return this;
        }
        
        private string GetFieldsUri() => $"{String.Join(",", ((ITcQuery) this).Fields.Select(f => f.ToString()))}";

        private string GetLocator()
        {
            return ((ITcQuery<TEntity>) this).Locator?.ToString();
        }
        
        public override string ToString() => $"locator={GetLocator()}&fields={GetFieldsUri()}";
    }
}