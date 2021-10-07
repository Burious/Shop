using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly Shopcart shopCart;

        public OrdersRepository(AppDBContent content, Shopcart cart)
        {
            this.appDBContent = content;
            this.shopCart = cart;
        }

        public void createOrder(Order order)
        {
            order.ordertime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();
            var items = shopCart.listShopItems;

            foreach (var element in items )
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = element.car.id,
                    orderId = order.id,
                    Price = element.car.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }

            appDBContent.SaveChanges();
        }
    }
}
