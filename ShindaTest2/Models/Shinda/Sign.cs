using System;

namespace ShindaTest2.Models.Shinda
{
    public class Sign
    {
        public string cID { get; set; }
        public string cName { get; set; }
        public DateTime? cDT { get; set; }
        public string showDt { get; set; }
        public decimal cSubTotal { get; set; } // 小數點後兩位
        public string showTot { get; set; }
        public string  items { get; set; }
    }
}
