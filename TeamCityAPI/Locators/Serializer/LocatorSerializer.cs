using System.Reflection;
using Newtonsoft.Json;
using TeamCityAPI.Locators.Common;

namespace TeamCityAPI.Locators.Serializer
{
    public class LocatorSerializer
    {
        public static string Serialize(Locator locator)
        {
            List<string> locators = new List<string>();

            var properties = locator.GetType().GetProperties();
            foreach (var property in properties)
            {
                var value = property.GetValue(locator);
                if (value == null)
                    continue;
                
                var propertyName = property.GetCustomAttribute<JsonPropertyAttribute>()
                    ?.PropertyName;
                
                if (property.PropertyType.IsClass && property.PropertyType.IsSubclassOf(typeof(Locator)))
                {
                    locators.Add($"{propertyName}:({Serialize((Locator) value)})");
                }
                else if(IsNullableEnum(property.PropertyType))
                {
                    var jsonSerializerSettings = new JsonSerializerSettings();
                    jsonSerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
                    var enumStr = JsonConvert.SerializeObject(value, Nullable.GetUnderlyingType(property.PropertyType), jsonSerializerSettings);
                    locators.Add($"{propertyName}:{enumStr.Trim('\"')}");
                } 
                else
                {
                    locators.Add($"{propertyName}:{value}");
                }
            }
            return string.Join(",", locators);
        }
        
        private static bool IsNullableEnum(System.Type type)
        {
            System.Type? u = Nullable.GetUnderlyingType(type);
            return (u != null) && u.IsEnum;
        }
    }
}