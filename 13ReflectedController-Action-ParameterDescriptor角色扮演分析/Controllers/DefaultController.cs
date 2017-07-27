using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _13ReflectedController_Action_ParameterDescriptor角色扮演分析.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        //acitonDescriptor 会检查Arrtribute，此时就不会通过 HttpPost
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }
    }
}