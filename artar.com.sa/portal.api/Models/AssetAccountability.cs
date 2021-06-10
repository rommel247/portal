using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class AssetAccountability
    {
        public string Idno { get; set; }
        public string RefNo { get; set; }
        public string Company { get; set; }
        public string Category { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedFrom { get; set; }
        public DateTime? TransferDateFrom { get; set; }
        public int? SalaryGroup { get; set; }
        public DateTime? DateAssigned { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string Supplier { get; set; }
        public decimal? CostAmount { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SerialNo { get; set; }
        public string Condition { get; set; }
        public bool? Status { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Hdd { get; set; }
        public string GraphicCard { get; set; }
        public string Notes { get; set; }
        public string Itnotes { get; set; }
        public bool? NotesLocked { get; set; }
        public bool? Locked { get; set; }
        public bool? Transfered { get; set; }
        public DateTime? LastDateModified { get; set; }
        public string Username { get; set; }
        public string Remarks { get; set; }
        public string Attachment { get; set; }
        public bool? Oos { get; set; }
        public string BravoScode { get; set; }
        public string BravoNo { get; set; }
        public string BravoPackage { get; set; }
        public string BravoGroup { get; set; }
        public int? TemporaryUser { get; set; }
        public int? AssetStatus { get; set; }
        public string AssetStatusNotes { get; set; }

        public virtual BravoPackage BravoPackageNavigation { get; set; }
        public virtual AssetCategory CategoryNavigation { get; set; }
        public virtual SimDepartment DepartmentNavigation { get; set; }
        public virtual Location LocationNavigation { get; set; }
        public virtual AssetSupplier SupplierNavigation { get; set; }
    }
}
