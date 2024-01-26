using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UralAjans3.Models;
using UralAjans3.MVVM;
using ContactUs = UralAjans3.Models.ContactUs;


namespace UralAjans3.Controllers
{
    public class HomeController : Controller
    {
        UralAjansEntities context = new UralAjansEntities();
        MainPageModel mpm = new MainPageModel();
        // GET: Home
        public ActionResult Index()
        {
            var employees = context.Employees.OrderBy(e => e.EmployeeName).Take(4).ToList();

            mpm.employeeList_name = context.Employees.OrderBy(e => e.EmployeeName).ToList();
            mpm.employeeList_role = context.Employees.OrderBy(e => e.EmployeeID).ToList();
            mpm.employeeList_photo = context.Employees.OrderBy(e => e.EmployeeID).ToList();

            return View(employees);
        }
        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(ContactUs _contactus)
        {
            bool answer = cls_ContactUs.AddMessage(_contactus);
            if (answer == true) { TempData["Message"] = "Mesajınız Gönderildi"; }
            else
            {
                TempData["Message"] = "Hata";
            }
            context.ContactUs.Add(_contactus);
            context.SaveChanges();
            return View(_contactus);
        }
    }
}