using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class DirectManager
    {
        public int DepartmentId { get; set; }
        public string EmailAdd { get; set; }
        public string DirectManagerId { get; set; }
        public string Title { get; set; }
        public string ArabicFullname { get; set; }
        public string EmailCc { get; set; }
        public int Id { get; set; }
        public string FullnameEn { get; set; }
        public string EmailBcc { get; set; }
    }
}
