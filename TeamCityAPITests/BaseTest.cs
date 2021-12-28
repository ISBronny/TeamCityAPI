using System;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using NUnit.Framework;
using TeamCityAPI;
using Environment = System.Environment;

namespace TeamCityAPITests
{
    [TestFixture]
    public class BaseTest
    {
        protected TeamCityClient Client;
        
        [SetUp]
        public void Setup()
        {
            var path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName,
                "appsettings.json");
            string json;
            using (StreamReader sr = new(path))
            {
                json = sr.ReadToEnd();
            }
            dynamic appSettings = JsonConvert.DeserializeObject(json) ?? throw new InvalidOperationException();
            Client = new("https://buildserver.labs.intellij.net");
            Client.UseToken(appSettings?["token"].ToString());
        }
    }
}