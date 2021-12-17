using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TeamCityAPI.Query
{
    public interface ITcQuery
    {
        internal TeamCityClient Client { get; set; }
        internal List<Field> Fields { get; set; }
        internal Field CurrentField { get; set; }
    }

    public interface ITcQuery<TEntity> : ITcQuery where TEntity : class
    {
        internal Locator Locator { get; set; }
        internal Func<string,string,Task<TEntity>> RequestMethod { get; set; }
        public ITcQuery<TEntity> WithLocator(Locator locator);
        public Task<TEntity> GetAsync();
    }

    // internal static class ITcQueryExtensions
    // {
    //     public static TeamCityClient GetClient(this ITcQuery iTcQuery)
    //     {
    //         return iTcQuery.Client;
    //     }
    //     public static List<Field> GetFields(this ITcQuery iTcQuery)
    //     {
    //         return iTcQuery.Fields;
    //     }
    //     public static Field GetCurrentField(this ITcQuery iTcQuery)
    //     {
    //         return iTcQuery.CurrentField;
    //     }
    // }
}