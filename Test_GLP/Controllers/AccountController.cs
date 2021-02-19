using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_GLP.Models;

namespace Test_GLP.Controllers
{
    public class AccountController : Controller
    {
        //[HttpPost]
        // GET: Account
        public ActionResult CreateAccount()
        {
            return View();
        }

        public ActionResult RegisterAccount(Account acc)
        {
            int i = new Account().createAccount(acc);
            if (i == 1)
            {
                ViewBag.message = "Account Create Successfully";
            }
            else if (i == 2)
            {
                ViewBag.message = "Account Update Successfully";
            }
            return View("CreateAccount");
        }
    }
}