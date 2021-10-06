using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        public readonly IAllCars _carRep;
        private readonly Shopcart _shopCart;

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult Index()
        {
            var homeCars =new HomeViewModel()
            {
                favCars = _carRep.GetFavCars
            };
            return View(homeCars);
        }
    }
}
