using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class ExpirationreminderSmsSetupView2
    {
        public int Userid { get; set; }
        public string UserName { get; set; }
        public int? UserGroup { get; set; }
        public int? SubModuleId { get; set; }
        public int? Sms { get; set; }
    }
}
