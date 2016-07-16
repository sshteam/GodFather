using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KingCulator.TwoArgument;

namespace WebInterface.Controllers
{
    public class CalculatorController : Controller
    {
        private SelectListItem[] operations = new[]
            {
                new SelectListItem { Value = "summa", Text = "сложение", Selected = true},
                new SelectListItem { Value = "minus", Text = "вычитание", Selected = false},
                new SelectListItem { Value = "umnozenie", Text = "умножение", Selected = false},
                new SelectListItem { Value = "delenie", Text = "деление", Selected = false},
                new SelectListItem { Value = "power", Text = "возведение в степень", Selected = false},
                new SelectListItem { Value = "log", Text = "логарифм", Selected = false}
            };

        // GET: Calculator
        public ActionResult Index()
        {
            ViewBag.Operations = operations;
            return View();
        }

        [HttpPost]
        public ActionResult Index(double firstValue, double secondValue, string operation)
        {
            ITwoArgumentCalculater calculater = TwoArgumentFactory.CreateCalculater(operation);
            TempData["Answer"] = calculater.Calculate(firstValue, secondValue);
            TempData["firstArgument"] = firstValue;
            TempData["secondArgument"] = secondValue;
            TempData["operation"] = operation;
            return RedirectToAction("Result");
        }

        public ActionResult Result()
        {
            ViewBag.Answer = TempData["Answer"];
            ViewBag.firstArgument = TempData["firstArgument"];
            ViewBag.secondArgument = TempData["secondArgument"];
            ViewBag.operation = TempData["operation"];
            ViewBag.Operations = operations;
            TempData.Keep();
            return View();
        }
    }
}