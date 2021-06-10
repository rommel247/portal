using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class Sim
    {
        public string Idno { get; set; }
        public string ShortCode { get; set; }
        public string RefCode { get; set; }
        public string ServiceProvider { get; set; }
        public int? ServiceType { get; set; }
        public string Crno { get; set; }
        public bool? International { get; set; }
        public bool? Roaming { get; set; }
        public string Internet { get; set; }
        public bool? GenType { get; set; }
        public string MobileSerialNo { get; set; }
        public string MobileDescription { get; set; }
        public string Simserialno { get; set; }
        public string Sim2serialno { get; set; }
        public string Sim3serialno { get; set; }
        public string Pin1 { get; set; }
        public string Pin12 { get; set; }
        public string Pin13 { get; set; }
        public string Pin2 { get; set; }
        public string Pin22 { get; set; }
        public string Pin23 { get; set; }
        public string Puk1 { get; set; }
        public string Puk12 { get; set; }
        public string Puk13 { get; set; }
        public string Puk2 { get; set; }
        public string Puk22 { get; set; }
        public string Puk23 { get; set; }
        public string ServiceAccount { get; set; }
        public string BillAccount { get; set; }
        public string Package { get; set; }
        public bool? BlackberryService { get; set; }
        public decimal? CreditLimit { get; set; }
        public string FaxNo { get; set; }
        public string RefNo { get; set; }
        public string PhoneType { get; set; }
        public bool? MobileCall { get; set; }
        public int? ConnectionType { get; set; }
        public string BySpeed { get; set; }
        public bool? Status { get; set; }
        public string AssignedTo { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string EmpId { get; set; }
        public DateTime? DateReceived { get; set; }
        public bool? Locked { get; set; }
        public string AccountingNote { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public DateTime? DateActivated { get; set; }
        public DateTime? DateDeactivated { get; set; }
        public DateTime? LastDateModified { get; set; }
        public string Username { get; set; }
        public string DeptName { get; set; }
        public int Id { get; set; }
        public string Remarks { get; set; }
        public DateTime? BillDate { get; set; }
        public DateTime? DistributionDate { get; set; }
        public int? Ispaid { get; set; }
        public string Paidby { get; set; }
        public DateTime? PaidDate { get; set; }

        public virtual Company CompanyNavigation { get; set; }
        public virtual SimDepartment DepartmentNavigation { get; set; }
        public virtual Location LocationNavigation { get; set; }
    }
}
