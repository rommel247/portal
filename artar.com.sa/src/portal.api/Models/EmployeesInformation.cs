using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class EmployeesInformation
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeNameA { get; set; }
        public string EmployeeNameEng { get; set; }
        public string CompanyCode { get; set; }
        public string Division { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string EmployeeStatusDesc { get; set; }
        public DateTime? HiringDate { get; set; }
    }
}
