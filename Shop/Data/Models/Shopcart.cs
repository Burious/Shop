using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Shop.Data.Models
{
    public class Shopcart
    {
        private readonly AppDBContent appDBContent;

        public Shopcart(AppDBContent appDBcontent)
        {
            this.appDBContent = appDBcontent;
        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> lisySgopItems { get; set; }

        public static Shopcart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);
            return new Shopcart(context) {ShopCartId = shopCartId};
        }

        public void AddToCart(Car car)
        {
            appDBContent.ShopCartItem.Add(new ShopCartItem()
            {
                ShopCartId = ShopCartId,
                car = car,
                price = car.price
            });
            appDBContent.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()
        {
            return appDBContent.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.car).ToList();
        }
    }

}
