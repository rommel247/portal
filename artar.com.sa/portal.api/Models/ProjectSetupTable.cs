using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class ProjectSetupTable
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? SetupDate { get; set; }
        public string FolderName { get; set; }
    }
}
