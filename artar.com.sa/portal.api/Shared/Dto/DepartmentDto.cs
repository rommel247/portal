using System.ComponentModel.DataAnnotations;

namespace portal.api.Shared.Dto
{
    public class DepartmentDto
    {
        [Display(Name = "Id")]
        public int DepartmentId { get; set; }
        [Display(Name = "Code")]
        public string SiteCode { get; set; }
        [Display(Name = "Name")]
        public string DepartmentName { get; set; }
        public int? Mode { get; set; }
    }
}
