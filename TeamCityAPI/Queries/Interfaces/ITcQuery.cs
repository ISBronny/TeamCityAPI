using TeamCityAPI.Locators.Common;
using TeamCityAPI.Models.Common;

namespace TeamCityAPI.Queries.Interfaces
{
    public interface ITcQuery : IBaseQuery
    {
        internal Locator Locator { get; set; }
    }

    public interface ITcQuery<TEntity> : ITcQuery, IBaseQuery<TEntity> where TEntity : TcModel
    {
        public ITcQuery<TEntity> WithLocator(Locator locator);
    }
}