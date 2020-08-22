using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchCart.Orders
{
    public class OrderDetails
    {
        public int OrderId { get; set; }

        public string OrderDetail { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
