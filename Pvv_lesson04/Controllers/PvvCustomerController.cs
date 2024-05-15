using Pvv_lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pvv_lesson04.Controllers
{
    public class PvvCustomerController : Controller
    {
        // GET: PvvCustomer
        public ActionResult Index()
        {
            return View();
        }
        //action : customerdetail
        public ActionResult PvvCustomerDetail()
        {
            var Customer = new PvvCustomer()
            {
                Customer = 1,
                firstname = "phan viet",
                lastname = "vuong",
                YearOfBirth = 2004
            };
            ViewBag.customer= Customer;
            return View();

        }
        public ActionResult PvvListCustmer()
        {
            var list = new List<PvvCustomer>()
            {
                new PvvCustomer()
                {
                Customer = 1,
                firstname = "phan viet",
                lastname = "vuong",
                address ="k22cntt3",
                YearOfBirth = 2004
                },
                new PvvCustomer()
                {
                    Customer= 2,
                    firstname="dam vinh",
                    lastname="hung",
                    address="k22cntt4",
                    YearOfBirth=2024
                },
                new PvvCustomer()
                {
                    Customer= 3,
                    firstname="dam vinh",
                    lastname="hung",
                    address="k22cntt4",
                    YearOfBirth=2024
                },
                new PvvCustomer()
                {
                    Customer= 4,
                    firstname="dam vinh",
                    lastname="hung",
                    address="k22cntt4",
                    YearOfBirth=2024
                },

            };
            ViewBag.list = list;
            return View();
        }
    }
    
}