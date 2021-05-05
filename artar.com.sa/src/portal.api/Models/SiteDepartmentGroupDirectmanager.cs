using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class SiteDepartmentGroupDirectmanager
    {
        public int Id { get; set; }
        public string EmailTo { get; set; }
        public string EmailCc { get; set; }
        public string EmailBcc { get; set; }
        public string Title { get; set; }
        public string FullnameEn { get; set; }
        public string FullnameAr { get; set; }
        public string Directmanagercode { get; set; }
        public string ReplyTo { get; set; }
        public string Language { get; set; }
        public string Payrollemail { get; set; }
    }
}
