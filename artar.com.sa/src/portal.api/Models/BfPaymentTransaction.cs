using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfPaymentTransaction
    {
        public int Id { get; set; }
        public int LoanmasterId { get; set; }
        public double Loanamount { get; set; }
        public DateTime Dateofpayment { get; set; }
        public double? Totalinterestexp { get; set; }
        public int? Loancategoryid { get; set; }
        public string Loancategory { get; set; }
        public int? Loanpurposeid { get; set; }
        public string Loanpurpose { get; set; }
        public string Sector { get; set; }
        public int? Sectorid { get; set; }
        public double? Treasurymargin { get; set; }
        public double? Treasuryprofitloan { get; set; }
        public double? Chargedcostsector { get; set; }
        public int? Lifetime { get; set; }
        public DateTime? Grantingdate { get; set; }
        public DateTime? Repaymentdate { get; set; }
        public double? Lifetimebankinterest { get; set; }
        public double? Lifetimeprofit { get; set; }
        public double? Lifetimechargesector { get; set; }
        public double? Creditlimit { get; set; }
        public string Projectnameid { get; set; }
        public string Projectname { get; set; }
        public string Notes { get; set; }
        public string Lettercopy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Creator { get; set; }
        public string Companysn { get; set; }
        public string Transactionname { get; set; }
        public int Sourceid { get; set; }
    }
}
