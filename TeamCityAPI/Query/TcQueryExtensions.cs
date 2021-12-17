using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace TeamCityAPI.Query
{
    public static class TcQueryExtensions
    {
        public static ITcIncludableQuery<TEntity, TProperty> ThenInclude<TEntity, TPreviousProperty, TProperty>(
            this ITcIncludableQuery<TEntity, IEnumerable<TPreviousProperty>> source,
            Expression<Func<TPreviousProperty, TProperty>> navigationPropertyPath, 
            IncludeType? includeType = null)
            where TEntity : class
        {
            var propInfo = GetPropertyInfo(navigationPropertyPath);
            TcIncludableQuery<TEntity, TProperty> tcIncludableQuery = new(source, propInfo, includeType);
            return tcIncludableQuery;
        }
        
        public static ITcIncludableQuery<TEntity, TProperty> ThenInclude<TEntity, TPreviousProperty, TProperty>(
            this ITcIncludableQuery<TEntity, TPreviousProperty> source,
            Expression<Func<TPreviousProperty, TProperty>> navigationPropertyPath, 
            IncludeType? includeType = null)
            where TEntity : class
        {
            var propInfo = GetPropertyInfo(navigationPropertyPath);
            TcIncludableQuery<TEntity, TProperty> tcIncludableQuery = new(source, propInfo, includeType);
            return tcIncludableQuery;
        }

        public static ITcIncludableQuery<TEntity, TProperty> Include<TEntity, TProperty>(
            this ITcQuery<TEntity> source,
            Expression<Func<TEntity, TProperty>> navigationPropertyPath, 
            IncludeType? includeType = null)
            where TEntity : class
        {
            var propInfo = GetPropertyInfo(navigationPropertyPath);
            TcIncludableQuery<TEntity, TProperty> tcIncludableQuery = new(source, propInfo, includeType);
            return tcIncludableQuery;
        }

        private static PropertyInfo GetPropertyInfo<TEntity, TProperty>(Expression<Func<TEntity, TProperty>> navigationPropertyPath)
        {
             
            System.Type type = typeof(TEntity);

            MemberExpression member = navigationPropertyPath.Body as MemberExpression;
            if (member == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a method, not a property.",
                    navigationPropertyPath.ToString()));

            PropertyInfo propInfo = member.Member as PropertyInfo;
            if (propInfo == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a field, not a property.",
                    navigationPropertyPath.ToString()));

            if (type != propInfo.ReflectedType &&
                !type.IsSubclassOf(propInfo.ReflectedType))
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a property that is not from type {1}.",
                    navigationPropertyPath.ToString(),
                    type));

            return propInfo;
        }
    }
}