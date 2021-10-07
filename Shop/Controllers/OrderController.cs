using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Controllers
{
    public class OrderController :Controller
    {

        private readonly IAllOrders allOrders;
        private readonly Shopcart shopCart;

        public OrderController(IAllOrders allOrders, Shopcart cart)
        {
            this.allOrders = allOrders;
            this.shopCart = cart;
        }

        public IActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            shopCart.listShopItems = shopCart.GetShopItems();
            if (shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "Cart must content items!");
            }

            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View();
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Order successfully processed";
            return View();
        }
    }
}
