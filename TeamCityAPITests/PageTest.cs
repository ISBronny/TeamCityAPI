using System.Threading.Tasks;
using NUnit.Framework;

namespace TeamCityAPITests
{
    public class PageTest : BaseTest
    {
        [Test]
        public async Task SimpleTest()
        {
            var builds = await Client.Builds.GetAsync(5);
            int counter = 0;
            await foreach (var page in builds)
            {
                if(++counter >= 20)
                    break;
                Assert.AreEqual(5, page.Count);
            }
        }
    }
}