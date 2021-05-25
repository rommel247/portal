using System.Collections.Generic;
using System.Linq;
using Xunit;
using Moq;
using portal.api.Shared.Interface;
using portal.api.Shared.Dto;
using portal.api.Controllers;

namespace portal.test
{

    public class SiteControllerTests
    {
        private readonly Mock<ISiteService> _mock;
        public SiteControllerTests()
        {
            _mock = new Mock<ISiteService>();
        }

        [Fact]
        public async void GetAllSiteAsync_ReturnValidResponse()
        {
            //Arrange
            List<SiteDto> sitelist = new List<SiteDto>();
            sitelist.Add(new SiteDto
            {
                Id = 1,
                Etime = string.Empty,
                LoginMode = "",
                PayrollEmail = string.Empty,
                RequiredWorkedHrs = "",
                SiteCode = "HQ",
                SiteName = string.Empty,
                Stime = string.Empty,
                SiteNameAr = string.Empty
            });
            IEnumerable<SiteDto> expectedListofSites = sitelist;
            _mock.Setup(x => x.GetAllSiteAsync()).ReturnsAsync(expectedListofSites);
            var sitecontroller = new SiteController(_mock.Object);

            //Act
            var result = await sitecontroller.GetAllSiteAsync();

            //Assert
            Assert.NotEmpty(result);
            Assert.True(result.Any());
        }
    }
}