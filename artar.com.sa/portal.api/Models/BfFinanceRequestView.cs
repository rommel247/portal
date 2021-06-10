using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfFinanceRequestView
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
        public string LastApproval { get; set; }
        public DateTime? LastApprovalDate { get; set; }
        public string LastApprovalUa { get; set; }
        public string FmApprovalUa { get; set; }
        public string SgmApprovalUa { get; set; }
        public string HoldingApproval { get; set; }
        public DateTime? HoldingPaydate { get; set; }
        public string HoldingApprovalUa { get; set; }
        public string HoldingRemarks { get; set; }
        public int? Withdraw { get; set; }
        public DateTime? Datewithdraw { get; set; }
        public string WithdrawUa { get; set; }
    }
}
