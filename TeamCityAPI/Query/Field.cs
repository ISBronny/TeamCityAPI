using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TeamCityAPI.Query
{
    public class Field
    {
        public Field(PropertyInfo property)
        {
            Name = property.GetCustomAttribute<Newtonsoft.Json.JsonPropertyAttribute>()?.PropertyName ??
                   throw new InvalidOperationException();
        }

        public string Name { get; set; }
        public List<Field> Fields { get; set; } = new();

        public void Add(Field field)
        {
            if(Fields.All(f => f.Name != field.Name))
                Fields.Add(field);
        } 

        public override string ToString() => Fields.Count > 0 
            ? Name + $"({String.Join(",", Fields.Select(f => f.ToString()))})" 
            : Name;
    }
}