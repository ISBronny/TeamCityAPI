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
    internal class TcIncludableQuery<TEntity, TProperty> : TcQuery<TEntity>, ITcIncludableQuery<TEntity, TProperty> where TEntity : class
    {
        public TcIncludableQuery(ITcQuery tcQuery, PropertyInfo property, IncludeType? includeType = null) 
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

            AddFieldsLoading(includeType ?? ((ITcQuery) this).Client.Settings.DefaultIncludeType);
        }
        internal TcIncludableQuery(ITcIncludableQuery tcIncludableQuery, PropertyInfo property,
            IncludeType? includeType) 
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
            
            AddFieldsLoading(includeType ?? ((ITcQuery) this).Client.Settings.DefaultIncludeType);
        }

        private void AddFieldsLoading(IncludeType includeType)
        {
            switch (includeType)
            {
                case IncludeType.Short:
                    ((ITcQuery) this).CurrentField.Add(Field.Short);
                    break;
                case IncludeType.Long:
                    ((ITcQuery) this).CurrentField.Add(Field.Long);
                    break;
            }
        }
    }
}