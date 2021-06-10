using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfLcMaster
    {
        public int Id { get; set; }
        public string CompanySn { get; set; }
        public string LcNo { get; set; }
        public int Categoryid { get; set; }
        public int? Purposeid { get; set; }
        public string IssuingBankid { get; set; }
        public string ContractNoPono { get; set; }
        public DateTime IssuanceDate { get; set; }
        public DateTime? ShippingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public double? LcfullAmount { get; set; }
        public int? Lctype { get; set; }
        public string BeneficiaryName { get; set; }
        public int ProjectId { get; set; }
        public double? ProjectAmount { get; set; }
        public int SectorId { get; set; }
        public string Notes { get; set; }
        public string SwiftCopy { get; set; }
        public DateTime? LastDateofShip { get; set; }
        public DateTime? DateofExpiry { get; set; }
        public string Incoterms { get; set; }
        public int? IncotermsId { get; set; }
        public int? Draft { get; set; }
        public string FinalDestination { get; set; }
        public string GoodsDescription { get; set; }
        public int? Qty { get; set; }
        public double? Priceperunit { get; set; }
        public double? TotalPrice { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? Accountnoid { get; set; }
        public int? Operatingnoid { get; set; }
        public int? Draftfromid { get; set; }
        public int? Status { get; set; }
        public string Currencycode { get; set; }
        public int? Forcestatus { get; set; }
    }
}
