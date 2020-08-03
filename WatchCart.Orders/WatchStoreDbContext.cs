using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WatchCart.Orders
{
    public class WatchStoreDbContext : DbContext
    {
        public List<OrderDetails> MyProperty { get; set; }
    }
}
