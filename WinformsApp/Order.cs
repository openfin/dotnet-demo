using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsApp
{
    public class Order
    {
        public string OrderType { get; set; }
        public string OrderAction { get; set; }
        public string Security { get; set; }
        public int Shares { get; set; }
        public decimal Limit { get; set; }
    }
}
