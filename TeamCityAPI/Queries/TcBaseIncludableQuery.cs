using System.Reflection;
using TeamCityAPI.Models.Common;
using TeamCityAPI.Queries.Common;
using TeamCityAPI.Queries.Interfaces;

namespace TeamCityAPI.Queries;

abstract class TcBaseIncludableQuery<TEntity, TProperty> : TcBaseQuery<TEntity>, IBaseIncludableQuery where TEntity : TcModel
    {
        public TcBaseIncludableQuery(IBaseQuery tcQuery, PropertyInfo property, IncludeType? includeType = null) 
            : base(tcQuery.Client, ((IBaseQuery<TEntity>)tcQuery).RequestMethod)
        {
            ((IBaseIncludableQuery) this).Fields = tcQuery.Fields;
            var field = new Field(property);
            if (((IBaseQuery) this).Fields.All(f => f.Name != field.Name))
            {
                ((IBaseQuery) this).Fields.Add(field);
                ((IBaseQuery) this).CurrentField = field;
            }
            else
            {
                ((IBaseQuery) this).CurrentField = ((IBaseQuery) this).Fields.Single(f => f.Name == field.Name);
            }

            AddFieldsLoading(includeType ?? ((IBaseQuery) this).Client.Settings.DefaultIncludeType);
        }
        
        internal TcBaseIncludableQuery(IBaseIncludableQuery tcIncludableQuery, PropertyInfo property,
            IncludeType? includeType) 
            : base(tcIncludableQuery.Client, ((IBaseQuery<TEntity>)tcIncludableQuery).RequestMethod)
        {
            ((IBaseIncludableQuery) this).Fields = tcIncludableQuery.Fields;
            ((IBaseIncludableQuery) this).CurrentField = tcIncludableQuery.CurrentField;
            var field = new Field(property);
            if (((IBaseQuery) this).CurrentField.Fields.All(f => f.Name != field.Name))
            {
                ((IBaseQuery) this).CurrentField.Add(field);
                ((IBaseQuery) this).CurrentField = field;
            }
            else
            {
                ((IBaseQuery) this).CurrentField = ((IBaseQuery) this).CurrentField.Fields.Single(f => f.Name == field.Name);
            }
            
            AddFieldsLoading(includeType ?? ((IBaseQuery) this).Client.Settings.DefaultIncludeType);
        }

        private void AddFieldsLoading(IncludeType includeType)
        {
            switch (includeType)
            {
                case IncludeType.Short:
                    ((IBaseQuery) this).CurrentField.Add(Field.Short);
                    break;
                case IncludeType.Long:
                    ((IBaseQuery) this).CurrentField.Add(Field.Long);
                    break;
            }
        }

        public abstract override Task<TEntity> GetAsync();
    }