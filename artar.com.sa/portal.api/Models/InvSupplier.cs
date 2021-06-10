using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class InvSupplier
    {
        public int SuppId { get; set; }
        public string SuppDesc { get; set; }
        public string SuppName { get; set; }
        public string SuppNumber { get; set; }
        public string SuppDatabase { get; set; }
        public string SuppNotes { get; set; }
    }
}
