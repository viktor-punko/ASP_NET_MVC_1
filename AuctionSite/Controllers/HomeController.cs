using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            using (var context = new AuctionSite.DAL.AuctionDbContext())
            {
                var newUser = new AuctionSite.Models.User
                {
                    UserID = 0,
                    UniqId = "kdjfkdsfj",
                    Email = "dgkfj@kjg.cvk",
                    FirstName = "Vasya",
                    LastName = "Gorshnev",
                    PhoneNumber = "985918940894"
                };

                context.Users.Add(newUser);
                context.SaveChanges();

                var users = context.Users;
            }

           
            return View();
        }

    }
}
