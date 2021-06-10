using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class RequisitionItemDetail
    {
        public int Id { get; set; }
        public string FkCategory { get; set; }
        public string Itemdescription { get; set; }
        public decimal? Price { get; set; }
        public string Imagepath { get; set; }
        public int FkCategoryid { get; set; }
    }
}
