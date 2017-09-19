using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17自定义验证之ValidationAttribute及Model级验证IValidationObject.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index(student stu)
        {
            var isValid = ModelState.IsValid;
            return View();
        }

    }


    public class student:IValidatableObject//model级别也就是类级别的验证
    {
        public int id { get; set; }
        public string name { get; set; }
        //[MyCustom]
        public int age { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //此时可以得到其他的字段. 可以综合做验证,
            if (age % 2 == 0)
            {
                var result = new ValidationResult("年龄的验证有问题", new string[] { "Age" });

                yield return result;
            }
        }
    }
    //public class student
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    [MyCustom]
    //    public int age { get; set; }
    //}
    //public class MyCustomAttribute:ValidationAttribute
    //{
    //    public override bool IsValid(object value)
    //    {
    //        //我们的验证逻辑

    //        //1. 读取数据库
    //        var dbValue = new Random().Next(0, 100);

    //        //2. 根据数据库的返回值来决定是否应该返回true/false
    //        var b = dbValue % 2 == 0;

    //        if (!b)
    //        {
    //            ErrorMessage = "当前验证不通过";  //给一个错误信息
    //        }

    //        return b;
    //    }
    //}
}