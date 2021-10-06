using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.Data.Repository;
using Shop.ViewModels;
//using Controller = System.Web.Mvc.Controller;
//using ViewResult = System.Web.Mvc.ViewResult;

namespace Shop.Controllers
{
    public class ShopCartController : Controller
    {
        public readonly IAllCars _carRep;
        private readonly Shopcart _shopCart;

        public ShopCartController(IAllCars carRep, Shopcart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.lisySgopItems = items;

            var obj = new ShopCartViewModel()
            {
                shopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(i=>i.id==id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
