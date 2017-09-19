using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16实体验证之DataAnnotationsModel介绍.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(student stu)
        {

            var isValid = ModelState.IsValid;
            return View();
        }
    }

    public class student
    {
        
        public int id { get; set; }
        public string name { get; set; }
        [Range(1,160,ErrorMessage="年龄Range error")]
        public int age { get; set; }

        
    }
}