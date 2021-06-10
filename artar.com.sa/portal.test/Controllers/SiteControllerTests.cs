using System.Collections.Generic;
using System.Linq;
using Xunit;
using Moq;
using portal.api.Shared.Interface;
using portal.api.Shared.Dto;
using portal.api.Controllers;
using portal.test.Repository;
using portal.api.Shared.Parameters;
namespace portal.test
{

    public class SiteControllerTests : GenericData
    {
        private readonly Mock<ISiteService> _mock;
        public SiteControllerTests()
        {
            _mock = new Mock<ISiteService>();
        }

        [Fact]
        public async void GetAllSiteAsync_ReturnValidResponse()
        {
    
            var siteInfo = Site();            
            IEnumerable<SiteDto> expectedListofSites = Site();
            _mock.Setup(x => x.GetAllSiteAsync()).ReturnsAsync(expectedListofSites);
            var sitecontroller = new SiteController(_mock.Object);

            //Act
            var result = await sitecontroller.GetAllSiteAsync();

            //Assert
            Assert.NotEmpty(result);
            Assert.True(result.Any());
        }

        [Fact]
        public async void GetSiteByIdAsync()
        {
            IEnumerable<SiteDto> expectedList = Site();
            _mock.Setup(x => x.GetSiteByIdAsync(expectedList.First().Id)).ReturnsAsync(expectedList);
            var sitecontroller = new SiteController(_mock.Object);

            //Act
            var result = await sitecontroller.GetSiteIdAsync(expectedList.First().Id);

            //Assert
            Assert.NotEmpty(result);
            Assert.True(result.Any());
            var firstOfSite = result.FirstOrDefault();
            Assert.NotNull(firstOfSite.SiteCode);
            Assert.True(firstOfSite.Id>0);
            Assert.NotNull(firstOfSite.SiteName);
            Assert.NotNull(firstOfSite.LoginMode);

        }
        [Fact]
        public async void CreateSite_ReturnMorethanOne()
        {
            var param = new CreateSiteParameter
            {
                SiteCode = "HQ",
                SiteName = "Sample Site",
                SiteNameAr = "Sample Site",
                LoginMode = "FILO",
                RequiredWorkedHrs = "0800",
                Etime = "18:00",
                PayrollEmail = "sample@domain.com",
                Stime = "08:00"
            };
            _mock.Setup(x => x.CreateAsync(param)).ReturnsAsync(1);
            var sitecontroller = new SiteController(_mock.Object);

            var result = await sitecontroller.Create(param);
            Assert.True(result.Value>0);
        }
    }
}