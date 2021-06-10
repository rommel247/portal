using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLoanMaster
    {
        public int Id { get; set; }
        public string CompanySn { get; set; }
        public int Bankid { get; set; }
        public string LoanNo { get; set; }
        public double? LoanAmount { get; set; }
        public DateTime? Startingdate { get; set; }
        public DateTime? EndingDate { get; set; }
        public double? SiborRate { get; set; }
        public int LoanCategoryId { get; set; }
        public int LoanPurposeId { get; set; }
        public int SectorId { get; set; }
        public int? LifeTimeDays { get; set; }
        public DateTime GrandtingDate { get; set; }
        public int ProjectNameId { get; set; }
        public string Notes { get; set; }
        public string LetterCopy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Creator { get; set; }
        public string Modify { get; set; }
        public DateTime? DateModified { get; set; }
        public string Transaction { get; set; }
        public double? TotalInterest { get; set; }
        public double? InterestExp { get; set; }
        public double? FacilityRate { get; set; }
        public double? TreasuryMargin { get; set; }
        public double? TreasuryProfit { get; set; }
        public double? ChargedCost { get; set; }
        public double? LifeTimeBankInterest { get; set; }
        public double? LifeTimeProfit { get; set; }
        public double? LifeTimeCharged { get; set; }
        public double? CreditLimit { get; set; }
        public DateTime? Repaymentdate { get; set; }
        public string Createdby { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? FacilityCardKey { get; set; }
        public string Bankletters { get; set; }
        public int AccountNo { get; set; }
        public int? Operatingnoid { get; set; }
        public int? Beneficiarysectorid { get; set; }
        public string Lcno { get; set; }
    }
}
