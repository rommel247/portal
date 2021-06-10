using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfReqApprovalView
    {
        public int Id { get; set; }
        public int Sectorid { get; set; }
        public string Sector { get; set; }
        public DateTime Dateofrequest { get; set; }
        public double? Amountrequest { get; set; }
        public DateTime? Dateofrepayment { get; set; }
        public double? Sectorlimit { get; set; }
        public double? Overlimitamount { get; set; }
        public string Createdby { get; set; }
        public double Utilized { get; set; }
        public double? Availableforuse { get; set; }
        public string Remarks { get; set; }
        public string Username { get; set; }
        public int? Requestid { get; set; }
        public string FmApproval { get; set; }
        public DateTime? FmDatelog { get; set; }
        public string SmApproval { get; set; }
        public DateTime? SgmDatelog { get; set; }
        public string Status { get; set; }
        public string Limitstatus { get; set; }
        public string Approvalusername { get; set; }
        public string Position { get; set; }
    }
}
