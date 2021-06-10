using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class OTemplate
    {
        public int Id { get; set; }
        public string Template { get; set; }
        public string TemplateDesc { get; set; }
    }
}
