using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsApp
{
    public class ProcessOrderEventArgs : EventArgs
    {
        public ProcessOrderEventArgs(Order order)
        {
            Order = order;
        }

        public Order Order { get; protected set; }
    }
}
