using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class DogModel
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Raza { get; set; }
        public int Age { get; set; } = 1;
        public bool IsAlive { get; set; } = true;
    }
}