using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class JobcardOracleCategoryUser
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public string Username { get; set; }
        public int Categoryfkid { get; set; }
        public DateTime? Creationdate { get; set; }
    }
}
