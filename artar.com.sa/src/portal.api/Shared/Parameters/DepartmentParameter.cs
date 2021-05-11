
namespace portal.api.Shared.Parameters
{
    //command parameter
    public abstract class DepartmentParameter
    {       
        public string SiteCode { get; set; }
        public string DepartmentName { get; set; }
        public int? Mode { get; set; }
        public string Title { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
    }
    public class CreateDepartmentParameter : DepartmentParameter { }

    public class UpdateDepartmentParameter : DepartmentParameter
    {
        public int DepartmentId { get; set; }
    }


}
