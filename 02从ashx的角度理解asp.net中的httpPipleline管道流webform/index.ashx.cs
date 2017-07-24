using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02从ashx的角度理解asp.net中的httpPipleline管道流webform
{
    /// <summary>
    /// Summary description for index
    /// </summary>
    public class index : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}