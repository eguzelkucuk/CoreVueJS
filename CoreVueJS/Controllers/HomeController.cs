using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreVueJS.Controllers
{
    public class HomeController : Controller
    {
        public class Products
        {
            public int ProdId { get; set; }
            public bool Select { get; set; }
            public string Name { get; set; }
            public int Stock { get; set; }
            public double Price { get; set; }
        }
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public JsonResult GetProduct() {

            List<Products> ProdList = new List<Products>() { };

            ProdList.Add(new Products() { ProdId = 1, Select=false, Name = "None Computer", Stock = 55, Price = 1500.50 });
            ProdList.Add(new Products() { ProdId = 2, Select=false, Name = "Asus Computer", Stock = 23, Price = 4600.50 });
            ProdList.Add(new Products() { ProdId = 3, Select=false, Name = "Apple Computer", Stock = 45, Price = 6100.50 });
            ProdList.Add(new Products() { ProdId = 4, Select=false, Name = "HP Computer", Stock = 63, Price = 3600.50 });
            ProdList.Add(new Products() { ProdId = 5, Select=false, Name = "Lenova Computer", Stock = 62, Price = 7800.50 });
            ProdList.Add(new Products() { ProdId = 6, Select=false, Name = "IBM Computer", Stock = 14, Price = 2300.50 });
            ProdList.Add(new Products() { ProdId = 7, Select=false, Name = "XYZ Computer", Stock = 11, Price = 1200.50 });
            ProdList.Add(new Products() { ProdId = 8, Select = false, Name = "ABC Computer", Stock = 99, Price = 9000.50 });

            return Json(ProdList.ToList());
        }
    }
}
