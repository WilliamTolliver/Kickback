using Kickback.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kickback.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [Route("users")]
        public ActionResult Users()
        {
            var user = new User() { FirstName = "William", LastName = "Tolliver", City = "Powder Springs", State = "Georgia", Country = "United States" };
            return View(user);
        }
    }
}