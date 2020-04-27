using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using laba1.Models;
using laba1.Services;
namespace laba1.Controllers
{
    public class OperationsController : Controller
    {
        private Results initResult()
        {
            ResultsInitializer results = new ResultsInitializer();
            return results.results;
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
            ValuesGetter service = new ValuesGetter();
            return View(service);
        }
    }
}