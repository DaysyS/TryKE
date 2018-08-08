using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TryPatternsMVC.Models.Adapter;

namespace TryPatternsMVC.Controllers
{
    public class AdapterController : Controller
    {
        public IActionResult Index()
        {

			var newElectricitySystem = new NewElectricitySystem();
			ElectricityConsumer.ChargeNotebook(newElectricitySystem);

			// Ми повинні адаптуватися до старої системи, використовуючи адаптер   
			var oldElectricitySystem = new OldElectricitySystem();
			var adapter = new Adapter(oldElectricitySystem);
			ViewData["result"] = ElectricityConsumer.ChargeNotebook(adapter); 

			return View("ResultView");
        }
    }
}