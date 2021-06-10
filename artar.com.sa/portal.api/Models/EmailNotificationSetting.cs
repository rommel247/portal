using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class EmailNotificationSetting
    {
        public int Id { get; set; }
        public string NotificationName { get; set; }
        public string EmailTo { get; set; }
        public string EmailCc { get; set; }
        public string EmailBcc { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
