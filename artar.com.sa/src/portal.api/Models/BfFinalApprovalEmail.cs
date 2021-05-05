using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class BfFinalApprovalEmail
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Username { get; set; }
        public string Emailaddress { get; set; }
    }
}
