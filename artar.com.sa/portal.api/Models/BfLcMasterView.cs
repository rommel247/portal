using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLcMasterView
    {
        public int Id { get; set; }
        public string CompanySn { get; set; }
        public string LcNo { get; set; }
        public int Categoryid { get; set; }
        public string CategoryName { get; set; }
        public int? Purposeid { get; set; }
        public string Purpose { get; set; }
        public string Bankid { get; set; }
        public string ContractNoPono { get; set; }
        public DateTime Issuancedate { get; set; }
        public DateTime? Shippingdate { get; set; }
        public DateTime Endingdate { get; set; }
        public double? LcfullAmount { get; set; }
        public int? Lctypeid { get; set; }
        public string Lctypes { get; set; }
        public string BeneficiaryName { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public double? ProjectAmount { get; set; }
        public int SectorId { get; set; }
        public string Sector { get; set; }
        public string Notes { get; set; }
        public string SwiftCopy { get; set; }
        public DateTime? LastDateofShip { get; set; }
        public DateTime? DateofExpiry { get; set; }
        public string Incoterms { get; set; }
        public int? Draft { get; set; }
        public string FinalDestination { get; set; }
        public string GoodsDescription { get; set; }
        public int? Qty { get; set; }
        public double? Priceperunit { get; set; }
        public double? Totalprice { get; set; }
        public string CreatedBy { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public double? RemainingAmount { get; set; }
        public double PartialRepayment { get; set; }
        public int Incotermsid { get; set; }
        public int? Accountnoid { get; set; }
        public string BankLetters { get; set; }
        public string BankNames { get; set; }
        public int? Operatingnoid { get; set; }
        public int? Draftfromid { get; set; }
        public DateTime? Duedate { get; set; }
        public int? Status { get; set; }
        public string Currencycode { get; set; }
        public int? Forcestatus { get; set; }
    }
}
