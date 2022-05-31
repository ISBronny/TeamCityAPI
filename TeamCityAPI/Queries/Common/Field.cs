using System.Reflection;

namespace TeamCityAPI.Queries.Common
{
    internal class Field
    {
        public static Field Short => new Field("$short");
        public static Field Long => new Field("$long");
        private Field(string name)
        {
            Name = name;
        }
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