using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using codevist.ExchangeRate.Entities;
using codevist.ExchangeRate.Entities.Model;
using codevist.ExchangeRate.Web.Models;

namespace codevist.ExchangeRate.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new ExchangeRateDTO();
            
            using (CurrencyContext context= new CurrencyContext())
            {
                model.ExchangeRateDataList = context.ExchangeRate.Where(m=>m.Id>0).Include(m=>m.Currency).ToList();
            }
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}