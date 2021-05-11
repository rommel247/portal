
using System.ComponentModel.DataAnnotations;

namespace portal.api.Shared.Dto
{
    public class SiteDto
    {
        public int Id { get; set; }
        [Display(Name = "Code")]
        public string SiteCode { get; set; }
        [Display(Name = "Site Name")]
        public string SiteName { get; set; }
        [Display(Name = "Login Mode")]
        public string LoginMode { get; set; }
        public string Stime { get; set; }
        public string RequiredWorkedHrs { get; set; }
        [Display(Name = "Site Arabic Name")]
        public string SiteNameAr { get; set; }
        [Display(Name = "Default Payroll Email")]
        public string PayrollEmail { get; set; }
        public string Etime { get; set; }
    }
}
