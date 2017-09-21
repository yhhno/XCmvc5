using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20form验证之Authorize及高度定制AuthorizeAttribute.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        //[Authorize]
        [MyAuthorize]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            //开始进行form验证
            //FormsAuthentication.SetAuthCookie(username, true);

            //判断值是否通过，如果通过，将用户信息存放到专门redis中

            //redis.add(sessionid,"adfasdfadf");

            return RedirectToAction("Index");
        }

    }

    public class MyAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //获取sessionid
           // var sessionid = httpContext.Request.Cookies["sessionid"].Value;

            //读取  redisclient.get(sessionid)...
            
            //如果有值， return true  ，否则返回false

            return true;

            //return base.AuthorizeCore(httpContext);
        }
    }
}