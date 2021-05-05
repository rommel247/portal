using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class RequisitionDataEntryPersonnel
    {
        public int Id { get; set; }
        public string Primaryname { get; set; }
        public string Emailto { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Company { get; set; }
    }
}
