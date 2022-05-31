using System;
using System.Linq;
using System.Reflection;

namespace MarkDownGenerator;

public class Helper
{
    public static Type[] GetClassesFromNamespace(Assembly assembly, string @namespace)
    {
        return 
            assembly.GetTypes()
                .Where(t => string.Equals(t.Namespace, @namespace, StringComparison.Ordinal))
                .Where(t=>t.IsClass)
                .ToArray();
    }
    
    public static Type[] GetEnumsFromNamespace(Assembly assembly, string @namespace)
    {
        return 
            assembly.GetTypes()
                .Where(t => string.Equals(t.Namespace, @namespace, StringComparison.Ordinal))
                .Where(t=>t.IsEnum)
                .ToArray();
    }
}