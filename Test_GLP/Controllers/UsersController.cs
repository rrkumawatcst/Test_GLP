using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Test_GLP.Models;

namespace Test_GLP.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult UserList()
        {

            ViewUsers users = new ViewUsers();
            users.LstUsers = new Users().getUserList();
            
            return View(users);
        }
    }
}