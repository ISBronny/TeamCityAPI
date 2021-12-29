using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using TeamCityAPI;
using TeamCityAPI.Query;

namespace TeamCityAPITests
{
    public class IncludeTest : BaseTest
    {
        [Test]
        public async Task SimpleInclude()
        {
            var builds = await Client.Builds
                .Include(x => x.Build)
                .ThenInclude(x => x.Agent)
                .WithLocator(new BuildLocator() {Count = 10})
                .GetAsync();
            
            Assert.AreEqual(10, builds.Count);
            Assert.AreEqual(10, builds.Build.Count);
            Assert.That(builds.Build.Select(b=>b.Agent), Is.All.Not.Null);
        }
        [Test]
        public async Task LongIncludeWithLocator()
        {
            var query = Client.Builds
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
                    Count = 50,
                });
            
            var res = await query.GetAsync();

            Assert.AreEqual(5, res.Count);
            Assert.AreEqual(5, res.Build.Count);
            Assert.That(res.Build.Select(x => x.Agent.Name), Is.All.EqualTo("intellij-linux-blade-076-vm-13"));
        }

        [Test]
        public async Task ShortInclude()
        {
            var query = Client.TestOccurrences
                .Include(x => x.TestOccurrence, IncludeType.Short)
                .WithLocator(new TestOccurrenceLocator()
                {
                    Count = 5,
                    Build = new BuildLocator { Id = 156770153}
                });
            var tests = await query.GetAsync();

            Assert.AreEqual(5, tests.Count);
            Assert.AreEqual(5, tests.TestOccurrence.Count);
            Assert.That(tests.TestOccurrence.Select(t => t.Build), Is.All.Null);
            Assert.That(tests.TestOccurrence.Select(t => t.Invocations), Is.All.Null);
            Assert.That(tests.TestOccurrence.Select(t => t.Metadata), Is.All.Null);
            Assert.That(tests.TestOccurrence.Select(t => t.Mute), Is.All.Null);
            Assert.That(tests.TestOccurrence.Select(t => t.FirstFailed), Is.All.Null);
        }
    }
}