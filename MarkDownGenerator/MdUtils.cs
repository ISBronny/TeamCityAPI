using System;
using System.Linq;
using Grynwald.MarkdownGenerator;
using Microsoft.VisualBasic;

namespace MarkDownGenerator;

public static class MdUtils
{
    public static MdTable CreateClassTable(Type type)
    {
        var properties = type.GetProperties().Select(x => new { Name = x.Name, Type = GetTypeName(x.PropertyType)});
        var table = new MdTable(
            new MdTableRow("Property", "Type"),
            properties.Select(x=>new MdTableRow(x.Name, x.Type.ToString())).ToArray()
            );

        return table;
    }
    
    public static MdTable CreateEnumTable(Type type)
    {
        var values = Enum.GetValues(type);
        var names = Enum.GetNames(type);
        var table = new MdTable(
            new MdTableRow("Name", "Value")
        );
        int i = 0;
        foreach (int value in values)
        {
            
            table.Add(new MdTableRow(names[i++], value.ToString()));
        }
        

        return table;
    }

    private static string GetTypeName(Type type)
    {
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
        {
            return Nullable.GetUnderlyingType(type)!.Name + "?";
        }
        
        if (type.IsGenericType)
        {
            return new string($"{type.Name}<{string.Join(',', type.GetGenericArguments().Select(x => x.Name))}>".Where(c =>
                    !@"/\`1234567890".ToCharArray().Contains(c)).ToArray());
        }

        return type.Name;
    }
    
    
}