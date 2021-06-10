using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class JobcardFeedbackV
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Problemtype { get; set; }
        public string Details { get; set; }
        public string Extension { get; set; }
        public int Recordid { get; set; }
        public int? Rate { get; set; }
        public string Comment { get; set; }
        public DateTime? SDate { get; set; }
        public string Email { get; set; }
        public string Support { get; set; }
    }
}
