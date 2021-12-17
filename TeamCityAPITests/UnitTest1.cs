using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using TeamCityAPI;
using TeamCityAPI.Query;
using TeamCityAPI.Serializer;

namespace TeamCityAPITests
{
    public class Tests
    {
        private TeamCityClient _client;
        
        [SetUp]
        public void Setup()
        {
            _client = new("https://buildserver.labs.intellij.net");
            _client.UseToken("eyJ0eXAiOiAiVENWMiJ9.UTB3bW9hZzFkRmxIWXU5X0tXSm9pYmVjcDlB.MmY3ZGFmZmMtNzlmNS00MTVlLTk0NjEtYWVkODNiZmEwODQ4");
        }

        [Test]
        public async Task Test1()
        {
            var builds = await _client.GetAllBuildsAsync("count:10", "$long");
            Assert.AreEqual(10, builds.Build.Count);
        }

        [Test]
        public async Task Test2()
        {
            var query = _client.Builds
                .Include(b => b.Build)
                    .ThenInclude(x => x.Artifacts)
                .Include(x => x.Build)
                    .ThenInclude(x => x.Agent)
                .Include(x => x.Build)
                    .ThenInclude(x => x.Comment)
                        .ThenInclude(x => x.Text)
                .Include(x => x.Build)
                    .ThenInclude(x => x.Agent)
                        .ThenInclude(x => x.Name)
                .WithLocator(new BuildLocator()
                {
                    Agent = new AgentLocator() {Name = "intellij-linux-blade-076-vm-13"},
                    Count = 5
                });
            
            var res = await query.GetAsync();

            Assert.AreEqual(5, res.Build.Count);
            Assert.That(res.Build.Select(x => x.Agent.Name), Is.All.EqualTo("intellij-linux-blade-076-vm-13"));
        }

        [Test]
        public void LocatorSerializeTest()
        {
            Locator locator = new BuildLocator()
            {
                Agent = new AgentLocator() { Name = "agent227"},
                Count = 23,
                State = BuildLocatorState.Running
            };

            Assert.AreEqual("agent:(name:agent227),count:23,state:running", LocatorSerializer.Serialize(locator));
        }

    }
}

