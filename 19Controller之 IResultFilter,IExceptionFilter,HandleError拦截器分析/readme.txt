一：IResultFilter,IExceptionFilter

同样也是采用aop的模式进行的切面编程。。。


二：IResultFilter

从名字上，大概就可以看出，就是我的View的前和后的执行。。。

ActionView => ViewResult,JsonResult,ContentResult.....  


=》ExecuteResult方法。


    public interface IResultFilter
    {
        void OnResultExecuted(ResultExecutedContext filterContext);
        void OnResultExecuting(ResultExecutingContext filterContext);
    }

IActionFilter基本上是一致的。。。

1. override的形式。。

2. FilterAttribute，IResultFilter。。。。 => ActionFilterAtrribute

3. GlobleFilters 全局的注册。。。



        private ResultExecutedContext InvokeActionResultFilterRecursive(IList<IResultFilter> filters, int filterIndex, ResultExecutingContext preContext, ControllerContext controllerContext, ActionResult actionResult)
        {
            if (filterIndex > (filters.Count - 1))
            {
                this.InvokeActionResult(controllerContext, actionResult);
                return new ResultExecutedContext(controllerContext, actionResult, false, null);
            }
            IResultFilter filter = filters[filterIndex];
            filter.OnResultExecuting(preContext);
            if (preContext.Cancel)
            {
                return new ResultExecutedContext(preContext, preContext.Result, true, null);
            }
            bool flag = false;
            ResultExecutedContext filterContext = null;
            try
            {
                int num = filterIndex + 1;
                filterContext = this.InvokeActionResultFilterRecursive(filters, num, preContext, controllerContext, actionResult);
            }
            catch (ThreadAbortException)
            {
                filterContext = new ResultExecutedContext(preContext, preContext.Result, false, null);
                filter.OnResultExecuted(filterContext);
                throw;
            }
            catch (Exception exception)
            {
                flag = true;
                filterContext = new ResultExecutedContext(preContext, preContext.Result, false, exception);
                filter.OnResultExecuted(filterContext);
                if (!filterContext.ExceptionHandled)
                {
                    throw;
                }
            }
            if (!flag)
            {
                filter.OnResultExecuted(filterContext);
            }
            return filterContext;
        }

三：IExceptionFilter


    public interface IExceptionFilter
    {
        void OnException(ExceptionContext filterContext);
    }

在我们的mvc中，有一个默认的 IExceptionFilter 的接口实现。。。。

它叫做handleError。


这个就是所谓的handleError的业务处理逻辑

        public virtual void OnException(ExceptionContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }
            if (!filterContext.IsChildAction && (!filterContext.ExceptionHandled && filterContext.HttpContext.IsCustomErrorEnabled))
            {
                Exception innerException = filterContext.Exception;
                if ((new HttpException(null, innerException).GetHttpCode() == 500) && this.ExceptionType.IsInstanceOfType(innerException))
                {
                    string controllerName = (string) filterContext.RouteData.Values["controller"];
                    string actionName = (string) filterContext.RouteData.Values["action"];
                    HandleErrorInfo model = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);
                    ViewResult result = new ViewResult {
                        ViewName = this.View,
                        MasterName = this.Master,
                        ViewData = new ViewDataDictionary<HandleErrorInfo>(model),
                        TempData = filterContext.Controller.TempData
                    };
                    filterContext.Result = result;
                    filterContext.ExceptionHandled = true;
                    filterContext.HttpContext.Response.Clear();
                    filterContext.HttpContext.Response.StatusCode = 500;
                    filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;
                }
            }
        }


现在我们测试一下，在index中估计抛出异常。。。

 <customErrors mode="On"></customErrors>

 这个时候就可以成功的跳转到 error页面。

 封装的越厉害，可扩展性就越差。。。

 我不光要有handlerError的业务逻辑，我还需要记录db。。。


   try
                    {
                        continuation();
                    }
                    catch (ThreadAbortException)
                    {
                        throw;
                    }
                    catch (Exception exception)
                    {
                        ExceptionContext context = this.InvokeExceptionFilters(controllerContext, filterInfo.ExceptionFilters, exception);
                        if (!context.ExceptionHandled)
                        {
                            throw;
                        }
                        this.InvokeActionResult(controllerContext, context.Result);
                    }



