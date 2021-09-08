using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class DogController : Controller
    {
        // GET: Dog
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListDogs()
        {
            List<DogModel> dog = new List<DogModel>();
            dog.Add(new DogModel { Name = "Milo", Age = 7, Color = "Negro", Raza = "Schnauzer" });
            dog.Add(new DogModel { Name = "Shadow", Age = 13, Color = "Blanco", Raza = "Schitzue" });
            return View(dog);
        }
    }
}