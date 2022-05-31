using System.IO;
using System.Linq;
using System.Reflection;
using Grynwald.MarkdownGenerator;
using MarkDownGenerator;
using TeamCityAPI.Locators;
using TeamCityAPI.Models;
using File = System.IO.File;

var document = new MdDocument();

// add a heading and a paragraph to the root block

var assembly = typeof(Agent).Assembly;
var modelsNamespace = typeof(Agent).Namespace;

document.Root.Add(new MdHeading(1, "List of all models supplied by TeamCity REST API"));
//Classes
document.Root.Add(new MdHeading(2, "Classes"));
foreach (var @class in Helper.GetClassesFromNamespace(assembly, modelsNamespace))
{
    document.Root.Add(new MdHeading(3, @class.Name));
    document.Root.Add(MdUtils.CreateClassTable(@class));
}

//Enums
document.Root.Add(new MdHeading(2, "Enums"));
foreach (var @class in Helper.GetEnumsFromNamespace(assembly, modelsNamespace))
{
    document.Root.Add(new MdHeading(3, @class.Name));
    document.Root.Add(MdUtils.CreateEnumTable(@class));
}

document.Save(File.CreateText(Path.Combine(Directory.GetCurrentDirectory(), "Models.md")).BaseStream);


//Locators
 document = new MdDocument();

modelsNamespace = typeof(AgentLocator).Namespace;

document.Root.Add(new MdHeading(1, "List of all locators supplied by TeamCity REST API"));
//Classes
document.Root.Add(new MdHeading(2, "Locators"));
foreach (var @class in Helper.GetClassesFromNamespace(assembly, modelsNamespace))
{
    document.Root.Add(new MdHeading(3, @class.Name));
    document.Root.Add(MdUtils.CreateClassTable(@class));
}

document.Save(File.CreateText(Path.Combine(Directory.GetCurrentDirectory(), "Locators.md")).BaseStream);
