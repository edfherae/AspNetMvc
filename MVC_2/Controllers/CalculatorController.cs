using Microsoft.AspNetCore.Mvc;
using MVC_2.Services;
using System.ComponentModel.DataAnnotations;
using MVC_2.Models;

namespace MVC_2.Controllers
{
	public class CalculatorController : Controller
	{
		[HttpGet]
		[ActionName("Index")] //зачем action name
		public IActionResult Index()
		{
			CalculatorViewModel model = new CalculatorViewModel();
			return View(model);
		}
		[HttpPost]
		//[ActionName("Calculate")]
		public IActionResult Calculate(CalculatorViewModel model)
		{
			//double a = ;
			//double b;

			//if (!(double.TryParse(InputA, out a) && double.TryParse(InputB, out b))) 

			//if (!ModelState.IsValid) return View();
			if (!ModelState.IsValid) return View("Index", model);

			switch (model.Operation)
			{
				case "+":
					model.Result = (model.A + model.B).ToString();
					break;
				case "-":
					model.Result = (model.A - model.B).ToString();
					break;
				case "*":
					model.Result = (model.A * model.B).ToString();
					break;
				case "/":
					if (model.B == 0)
					{
						ModelState.AddModelError("B", "Деление на ноль невозможно");
						return View("Index", model);
					}
					model.Result = (model.A / model.B).ToString();
					break;
            }

			return View("Index", model);
		}
	}
}
