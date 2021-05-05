using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class Requisition
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public int? Purchasecategoryid { get; set; }
        public string Purchasecategory { get; set; }
        public int? Purchasedetailsid { get; set; }
        public string Purchasedetails { get; set; }
        public string Notes { get; set; }
        public DateTime Datecreation { get; set; }
        public DateTime DatetimeCreation { get; set; }
        public string Username { get; set; }
        public DateTime? DatetimeLastmodify { get; set; }
        public string Lastmodifyby { get; set; }
        public decimal? CurrentPrice { get; set; }
        public string CurrentDirectmanagercode { get; set; }
        public int? Iswithdrawed { get; set; }
        public DateTime? DateOfWithdrawal { get; set; }
        public int ReqNo { get; set; }
        public DateTime? Posteddate { get; set; }
        public int? Qty { get; set; }
        public decimal? Price { get; set; }
        public string Currency { get; set; }
        public int? HideAssetHistory { get; set; }
        public int? Completed { get; set; }
        public DateTime? Datecompletion { get; set; }
    }
}
