using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewsModels.Models;

namespace ViewsModels.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product
            {
                Id = 1,
                Name = "RANGE ROVER"
            };

            return View(product);
        }
    }
}
