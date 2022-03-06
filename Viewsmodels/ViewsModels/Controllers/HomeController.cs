using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewsModels.Models;

public class HomeController : Controller
    {


        public IActionResult Index()
        {
            List<Student> students = new List<Student>();

            Student st1 = new Student
            {
                Id = 1,
                Name = "Dunya",
                Surname = "Mammadli",
                Age = 22,

            };
            Student st2 = new Student
            {
                Id = 2,
                Name = "Gunel",
                Surname = "Mustafayeva",
                Age = 25,

            };

            students.Add(st1);
            students.Add(st2);

            var list = students;
            return View(students);
        }
    }



    //  public IActionResult Login()
    //   {
    //        return View();
    //   }

    //public IActionResult Login()
    //{
    ////try
    ////{
    ////    return View();

    ////}
    ////catch (Exception ex)
    ////{
    ////    return new ObjectResult(ex);
    ////    //return Content(ex.Message);
    ////}
    //////return NotFound();
    ////}



  
