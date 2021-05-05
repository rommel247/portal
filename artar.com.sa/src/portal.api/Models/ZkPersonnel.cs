using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class ZkPersonnel
    {
        public string PersonnelId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }
        public string DepartmentNumber { get; set; }
        public string DepartmentName { get; set; }
        public string Gender { get; set; }
        public string _10fpqty { get; set; }
        public string _9fpqty { get; set; }
        public string VeinQuantity { get; set; }
        public string FaceQty { get; set; }
        public string PlamVeinQty { get; set; }
    }
}
