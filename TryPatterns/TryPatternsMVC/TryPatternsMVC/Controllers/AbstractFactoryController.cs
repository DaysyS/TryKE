using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TryPatternsMVC.Models.AbstractFactory;

namespace TryPatternsMVC.Controllers
{
    public class AbstractFactoryController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }

        public IActionResult WoodenToys()
        {
            //Fabric1
            IToysFactory toyFactory = new WoodenToysFactory();
            IBear bear = toyFactory.GetBear();
            ICat cat = toyFactory.GetCat();
            ViewData["result"] = $"{bear.Message} {cat.Message }";
            return View();
        }
        public IActionResult TeddyToys()
        {
            //Fabric2
            IToysFactory toyFactor = new TeddyToysFactory();
            IBear bear = toyFactor.GetBear();
            ICat cat = toyFactor.GetCat();
            ViewData["result"] = $"{bear.Message} {cat.Message }";
            return View();
        }
    }
}