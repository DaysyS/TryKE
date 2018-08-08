using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TryPatternsMVC.Models.Singleton;

namespace TryPatternsMVC.Controllers
{
    public class SingletonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IncreaseCounter()
        {
            ViewData["result"] = Singleton.Instance.IncreaseCounter();
            return View();
        }

        public IActionResult ShowMessage(string m="some text")
        {
            ViewData["result"] = Singleton.Instance.ShowMessage(m);
            return View("ResultView");
        }
    }
}