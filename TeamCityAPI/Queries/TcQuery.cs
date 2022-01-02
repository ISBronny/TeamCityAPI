using TeamCityAPI.Locators.Common;
using TeamCityAPI.Models.Common;
using TeamCityAPI.Queries.Interfaces;

namespace TeamCityAPI.Queries
{
    internal class TcQuery<TEntity> : TcBaseQuery<TEntity>, ITcQuery<TEntity> where TEntity : TcModel
    {
        Locator ITcQuery.Locator { get; set; }
        Func<string, string, Task<TEntity>> IBaseQuery<TEntity>.RequestMethod { get; set; }
       
        public TcQuery(TeamCityClient client, Func<string, string, Task<TEntity>> requestMethod) : base(client, requestMethod)
        {
        }

        public ITcQuery<TEntity> WithLocator(Locator locator)
        {
            ((ITcQuery<TEntity>) this).Locator = locator;
            return this;
        }

        public override async Task<TEntity> GetAsync()
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