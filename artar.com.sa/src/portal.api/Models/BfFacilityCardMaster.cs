using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfFacilityCardMaster
    {
        public int Id { get; set; }
        public int? Bankid { get; set; }
        public DateTime Validfrom { get; set; }
        public DateTime Validto { get; set; }
        public bool? IsInactive { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Createdby { get; set; }
        public DateTime? DateModified { get; set; }
        public string Modifyby { get; set; }
        public bool? Def { get; set; }
        public string BankLetters { get; set; }
    }
}
