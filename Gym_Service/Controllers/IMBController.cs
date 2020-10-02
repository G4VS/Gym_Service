using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Gym_Service.Models;

namespace Gym_Service.Controllers
{
    public class IMBController : Controller
    {
        // GET: IMB
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalculateIBM()
        {
            IEnumerable<IBM> customer = null;
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("");
                var responceTask = client.GetAsync("customer");//////////////////////////
                responceTask.Wait();

                var result = responceTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<IBM>>();
                    readJob.Wait();
                    customer = readJob.Result;

                }else
                {
                    //show error
                    customer = Enumerable.Empty<IBM>();
                    ModelState.AddModelError(string.Empty, "Server error occured. Please contact admin for help!");
                }

            }
            return View(customer);
        }
    }
}