using System;
using System.Collections.Generic;

#nullable disable

namespace portal.api.Models
{
    public partial class TransCarsTbl
    {
        public int CarId { get; set; }
        public string CarPlateNo { get; set; }
        public string CarCode { get; set; }
        public string CarDesc { get; set; }
        public DateTime? LiDate { get; set; }
        public string ChangeOil { get; set; }
        public string ChangeTyres { get; set; }
    }
}
