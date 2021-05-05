using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class ExpirationreminderSmsSetup
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public int? Sms { get; set; }
    }
}
