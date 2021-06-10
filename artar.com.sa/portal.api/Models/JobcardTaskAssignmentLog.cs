using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class JobcardTaskAssignmentLog
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public string Support { get; set; }
        public int? Status { get; set; }
        public string DateForwardA { get; set; }
        public string DateSubmitted { get; set; }
        public string Admin { get; set; }
        public int? Rate { get; set; }
        public string NotesA { get; set; }
        public string NotesS { get; set; }
        public int? Cid { get; set; }
        public string Priority { get; set; }
    }
}
