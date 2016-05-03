using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoPractice.Models;

namespace KendoPractice.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {

            return View();
        }
        public JsonResult GetUserList()
        {
            using (var db = new StoreEntities1())
            {
                var users = db.Customers.Select(c => new
                {
                    
                    Name = c.Name,
                    City = c.City,
                    Address = c.Address,
                    CustomerId = c.CustomerId,
                    CityId = c.CityId,
                    Country = c.Country,
                    Created = c.Created,
                 }).ToList();

                return Json(users, JsonRequestBehavior.AllowGet);
            }

        }
    }
}
