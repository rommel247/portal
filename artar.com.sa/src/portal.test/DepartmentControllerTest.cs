using Xunit;
using Moq;
using portal.api.Shared.Interface;
using portal.api.Shared.Parameters;
using portal.api.Controllers;
using portal.api.Shared.Dto;
using System.Collections.Generic;
using System.Linq;
namespace portal.test
{

    public class DepartmentControllerTest
    {
        private readonly Mock<IDepartmentService> _mockDepartmentService;
        public DepartmentControllerTest()
        {
            _mockDepartmentService = new Mock<IDepartmentService>();
        }

        //test command parameters validation
        [Fact]
        public async void GetAll_ReturnListOfDeparments()
        {

            //Arrange
            List<DepartmentDto> departmentList = new List<DepartmentDto>();
            departmentList.Add(new DepartmentDto
            {
                DepartmentId = 1,
                DepartmentName = "Test DepartmentName",
                Mode = 1,
                SiteCode = "HQ"
            });
            IEnumerable<DepartmentDto> expectedIEnumerableDepartmentList = departmentList;

            _mockDepartmentService.Setup(x => x.GetAllDepartmentAsync()).ReturnsAsync(expectedIEnumerableDepartmentList);
            var departmentcontroller = new DepartmentController(_mockDepartmentService.Object);

            //Act
            var result = await departmentcontroller.Get();

            //Assert
            Assert.NotEmpty(result);
            Assert.True(result.Any());
        }

        [Fact]
        public async void GetById_ReturnListOfDeparments_WithFilter()
        {

            //Arrange
            List<DepartmentDto> departmentList = new List<DepartmentDto>();

            for (int x = 1; x <= 5; x++)
            {
                departmentList.Add(new DepartmentDto
                {
                    DepartmentId = x,
                    DepartmentName = $"Test DepartmentName No. {x}",
                    Mode = 1,
                    SiteCode = "HQ"
                });
            }
            IEnumerable<DepartmentDto> expectedIEnumerableDepartmentList = departmentList;
            var expectedresult = expectedIEnumerableDepartmentList.Where(x => x.DepartmentId == 2);
            _mockDepartmentService.Setup(x => x.GetDepartmentByIdAsync(2)).ReturnsAsync(expectedresult);
            var departmentcontroller = new DepartmentController(_mockDepartmentService.Object);

            //Act
            var result = await departmentcontroller.GetById(2);

            //Assert
            Assert.NotEmpty(result);
            Assert.True(result.Any());
        }

        [Fact]
        public async void CreateDepartment_ReturnMorethanOne ()
        {
            var parameter = new CreateDepartmentParameter
            {
                SiteCode = "TestSiteCode",
                FullName = "Test Site Code",
                Title = "Test Title",
                DepartmentName = "Test Department",
                Email = "email@domain.com",
                Mode = 1,
                Cc = "",
                Bcc = ""
            };
            _mockDepartmentService.Setup(x => x.CreateAsync(parameter)).ReturnsAsync(1);
            var departmentcontroller = new DepartmentController(_mockDepartmentService.Object);

            var result = await departmentcontroller.Create(parameter);
            Assert.Equal(1, result.Value);
        }
    }


}
