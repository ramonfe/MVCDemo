using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            PersonModel p = new PersonModel();
            int i = 5 / p.Age;
            return View();
        }
        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Ramon", LastName = "Felix", Age = 47 });
            people.Add(new PersonModel { FirstName = "Joe", LastName = "Smith", Age = 50 });
            people.Add(new PersonModel { FirstName = "Sara", LastName = "Connor", Age = 25 });
            return View(people);
        }
    }
}