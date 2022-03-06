using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.ViewModels;
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


        Product product = new Product
        {
            Id = 1,
            Name = "MERCEDES"
        };

        List<int> list = new List<int>{1, 2, 3, 4, 5, 5, 6, 7, 8, 9};
             
        HomeViewModel homeViewModel = new HomeViewModel
        {
            Students = students,
            Product =  product,
            Counts =  list
        };

           return View(students);
            //var list = students;

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



  
