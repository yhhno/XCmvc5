using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _03自定义module和handler加深对管道流的理解
{
    public class mymodule:IHttpModule
    {
        public void Dispose()
        {
           
        }

        public void Init(HttpApplication context)
        {
            //注册事件
            context.BeginRequest += context_BeginRequest;
        }

        void context_BeginRequest(object sender, EventArgs e)
        {

        //    //global
        //    var app = sender as HttpApplication;

        //    //获取参数，进行检测
        //    var query = app.Request.QueryString;

        //    //具体操作 不详说
        //    //空值判断
        //    if (query.Count>0&&query["name"].Contains("select"))
        //    {
        //        app.Response.StatusCode = 404;
        //    }



        }

    }
}