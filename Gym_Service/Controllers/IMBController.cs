using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Gym_Service.Models;
using Newtonsoft.Json;

namespace Gym_Service.Controllers
{
    public class IMBController : Controller
    {
        // GET: IMB
        public ActionResult Index()
        {
            return View(new IBM());
        }
        [HttpPost]
        public JsonResult CalculateIBM(IBM i)
        {
           double BMI;
           
                i.BMIValue = (i.Weight / (i.Height * i.Height)) * 703;
                BMI = i.BMIValue;

         
            var json = JsonConvert.SerializeObject(BMI);
            return Json(json,JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult CalculateFatMen(IBM i)
        {
            double FVM;
         
                i.FatValueMen = 10.1 - (0.239 * i.Height) + (0.8 * i.AbdominalCircumference) - (0.5 * i.NeckCircumference);
                FVM = i.FatValueMen;
            
          
            var json = JsonConvert.SerializeObject(FVM);
            return Json(json, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult CalculateFatWomen(IBM i)
        {
            double FVW;
          
         
                i.FatValueWomen = 19.2 - (0.239 * i.Height) + (0.8 * i.AbdominalCircumference) - (0.5 * i.NeckCircumference);
                FVW = i.FatValueWomen;
            
            var json = JsonConvert.SerializeObject(FVW);
            return Json(json, JsonRequestBehavior.AllowGet);

        }









    }
}