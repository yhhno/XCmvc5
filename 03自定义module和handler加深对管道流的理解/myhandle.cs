using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _03自定义module和handler加深对管道流的理解
{
    public class myhandle:IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
           //图片的逻辑处理后台
            var info = context.Request.UrlReferrer;

            if (info == null)
            {
                context.Response.StatusCode = 404;
            }
        }
    }
}