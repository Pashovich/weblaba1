using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using laba1.Models;
namespace laba1.Controllers
{
    public class OperationsController : Controller
    {
        private Results initResult()
        {
            var rand = new Random();
            int first = rand.Next(1, 10);
            int second = rand.Next(1, 10);
            int add = first + second;
            int sub = first - second;
            int mult = first * second;
            int div = second == 0 ? 0 : first/second;
            Results viewModel = new Results()
            {
                first = first,
                second = second,
                add = add,
                sub = sub,
                mult = mult,
                div = div
            };
            return viewModel;
        }
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult PassModel()
        {
            return View(initResult());
        }
        public ViewResult PassViewData()
        {
            ViewData["data"] = initResult();
            return View();
        }
        public ViewResult PassViewBag()
        {
            ViewBag.data = initResult();
            return View();
        }
        public ViewResult PassInjection()
        {
            return View(initResult());
        }
    }
}