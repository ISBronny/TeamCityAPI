using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using TeamCityAPI.Locators;
using TeamCityAPI.Models.Common;
using TeamCityAPI.Queries;

namespace TeamCityAPITests
{
    public class PageTest : BaseTest
    {
        [Test]
        public async Task SimpleTest()
        {
            var builds = await Client.Builds
                .Include(x=>x.Build)
                .GetAsync(5);
            await ForeachTest(builds, page =>
            {
                Assert.AreEqual(5, page.Count);
                Assert.AreEqual(5, page.Value.Count);
            });
        }

        [Test]
        public async Task PageIncludeLocator()
        {
            var query = Client.Builds
                .Include(x => x.Build)
                    .ThenInclude(x => x.Agent)
                        .ThenInclude(x => x.Name)
                .WithLocator(new BuildLocator()
                {
                    Agent = new AgentLocator() {Name = "intellij-linux-blade-076-vm-13"},
                    Count = 2,
                });
            
            var res = await query.GetAsync();
            
            await ForeachTest(res, page =>
            {
                Assert.AreEqual(2, page.Count);
                Assert.AreEqual(2, page.Value.Count);
                Assert.That(page.Value.Select(x => x.Agent.Name), Is.All.EqualTo("intellij-linux-blade-076-vm-13"));
            });
        }

        private async Task ForeachTest<T>(Page<T> page, Action<Page<T>> constraint) where T : TcModel
        {
            int counter = 0;
            await foreach (var nextPage in page)
            {
                if(++counter >= 5)
                    break;
                constraint(nextPage);
            }
        }
    }
}