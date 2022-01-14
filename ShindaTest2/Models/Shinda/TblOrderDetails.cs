using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ShindaTest2.Models.Shinda
{
    public partial class TblOrderDetails
    {
        public string COrderId { get; set; }
        public int CProductId { get; set; }
        public int? CCount { get; set; }
        public decimal? CTotal { get; set; }
    }
}
