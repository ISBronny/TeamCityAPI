using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;
using TeamCityAPI;
using TeamCityAPI.Query;

namespace TeamCityAPITests
{
    public class LocatorTest : BaseTest
    {
        [Test]
        public async Task SimpleLocatorTest()
        {
            var investigations = await Client.Investigations
                .Include(x=>x.Investigation, IncludeType.Short)
                .WithLocator(new InvestigationLocator()
                {
                    State = InvestigationLocatorState.Taken,
                    Count = 7
                })
                .GetAsync();
            
            Assert.AreEqual(7,investigations.Count);
            Assert.AreEqual(7,investigations.Investigation.Count);
            Assert.That(investigations.Investigation.Select(x=>x.State), 
                Is.All.EqualTo(InvestigationState.TAKEN));
        }
    }
}