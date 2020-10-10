using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using WatchCart.Orders;

namespace WatchCart.Test
{
   public class WatchOrderTest
    {
        [Test]
        public void CreateOrders_Saves_OrderDetails_Via_Context()
        {
            var mockSet = new Mock<DbSet<OrderDetails>>();

            var mockContext = new Mock<WatchStoreDbContext>();
            mockContext.Setup(m => m.OrderDetail).Returns(mockSet.Object);

            var orderRepository
                = new OrderRepository(mockContext.Object);
           

            orderRepository.save(new OrderDetails() { OrderDetail = "order details", CreateDate = DateTime.Now, OrderId = 1 });

            mockSet.Verify(m => m.Add(It.IsAny<OrderDetails>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

    }
}
