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
        public async void DepartmentController_Get_ValidReturn()
        {

            //Arrange
            List<DepartmentDto> departmentList = new List<DepartmentDto>();
            departmentList.Add(new DepartmentDto
            {
                DepartmentId = 1,
                DepartmentName = "",
                Mode = 1,
                SiteCode = ""
            });
            IEnumerable<DepartmentDto> expectedIEnumerableDepartmentList = departmentList;

            _mockDepartmentService.Setup(x => x.GetAllDepartmentAsync()).ReturnsAsync(expectedIEnumerableDepartmentList);
            var departmentcontroller = new DepartmentController(_mockDepartmentService.Object);
            var result = await departmentcontroller.Get() ;
            Assert.NotEmpty(result);
            Assert.True(result.Any());
            //

        }
    }

    
}
