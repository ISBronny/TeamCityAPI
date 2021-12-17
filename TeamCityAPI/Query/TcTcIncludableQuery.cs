using System.Linq;
using System.Reflection;

namespace TeamCityAPI.Query
{
    // public class TcIncludableQuery : TcQuery, ITcIncludableQuery
    // {
    //     public TcIncludableQuery(TeamCityClient client) : base(client)
    //     {
    //     }
    //
    // }
    internal class TcTcIncludableQuery<TEntity, TProperty> : TcQuery<TEntity>, ITcIncludableQuery<TEntity, TProperty> where TEntity : class
    {
        public TcTcIncludableQuery(ITcQuery tcQuery, PropertyInfo property) 
            : base(tcQuery.Client, ((ITcQuery<TEntity>)tcQuery).RequestMethod)
        {
            ((ITcIncludableQuery) this).Fields = tcQuery.Fields;
            var field = new Field(property);
            if (((ITcQuery) this).Fields.All(f => f.Name != field.Name))
            {
                ((ITcQuery) this).Fields.Add(field);
                ((ITcQuery) this).CurrentField = field;
            }
            else
            {
                ((ITcQuery) this).CurrentField = ((ITcQuery) this).Fields.Single(f => f.Name == field.Name);
            }
        }
        internal TcTcIncludableQuery(ITcIncludableQuery tcIncludableQuery, PropertyInfo property) 
            : base(tcIncludableQuery.Client, ((ITcQuery<TEntity>)tcIncludableQuery).RequestMethod)
        {
            ((ITcIncludableQuery) this).Fields = tcIncludableQuery.Fields;
            ((ITcIncludableQuery) this).CurrentField = tcIncludableQuery.CurrentField;
            var field = new Field(property);
            if (((ITcQuery) this).CurrentField.Fields.All(f => f.Name != field.Name))
            {
                ((ITcQuery) this).CurrentField.Add(field);
                ((ITcQuery) this).CurrentField = field;
            }
            else
            {
                ((ITcQuery) this).CurrentField = ((ITcQuery) this).CurrentField.Fields.Single(f => f.Name == field.Name);
            }
        }
    }
}