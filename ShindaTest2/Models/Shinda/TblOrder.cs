using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ShindaTest2.Models.Shinda
{
    public partial class TblOrder
    {
        public string COrderId { get; set; }
        public string CName { get; set; }
        public decimal? CSubTotal { get; set; }
        public DateTime? CDt { get; set; }
    }
}
