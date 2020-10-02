using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym_Service.Models;

namespace Gym_Service.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(RegisterModel registerDetails)
        {
            using (GymDataModel db = new GymDataModel())
            {
                var userDetails = db.Users.Where(x => x.UserName == registerDetails.UserName).FirstOrDefault();
                if (userDetails != null)//if username already exists
                {
                    registerDetails.RegisterError = "Username already in use.";
                    return View("Index", registerDetails);
                }else if (registerDetails.Password != registerDetails.ConfirmPassword)//password and confirm password do not match
                {
                    registerDetails.RegisterError = "Passwords do not match.";
                    return View("Index", registerDetails);
                }

                User newUser = new User();
                newUser.UserName = registerDetails.UserName;  // register user
                newUser.Password = registerDetails.Password;
                db.Users.Add(newUser);
                db.SaveChanges();
                return RedirectToAction("Index", "Login");
            }
        }
    }
}