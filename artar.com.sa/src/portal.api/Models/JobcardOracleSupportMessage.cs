using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class JobcardOracleSupportMessage
    {
        public int Id { get; set; }
        public int Ticketfkid { get; set; }
        public DateTime Datecreation { get; set; }
        public string Notes { get; set; }
        public string Username { get; set; }
        public string Attachment { get; set; }
        public string Action { get; set; }
        public string Support { get; set; }
    }
}
