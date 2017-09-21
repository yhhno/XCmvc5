һ��IResultFilter,IExceptionFilter

ͬ��Ҳ�ǲ���aop��ģʽ���е������̡�����


����IResultFilter

�������ϣ���žͿ��Կ����������ҵ�View��ǰ�ͺ��ִ�С�����

ActionView => ViewResult,JsonResult,ContentResult.....  


=��ExecuteResult������


    public interface IResultFilter
    {
        void OnResultExecuted(ResultExecutedContext filterContext);
        void OnResultExecuting(ResultExecutingContext filterContext);
    }

IActionFilter��������һ�µġ�����

1. override����ʽ����

2. FilterAttribute��IResultFilter�������� => ActionFilterAtrribute

3. GlobleFilters ȫ�ֵ�ע�ᡣ����



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

����IExceptionFilter


    public interface IExceptionFilter
    {
        void OnException(ExceptionContext filterContext);
    }

�����ǵ�mvc�У���һ��Ĭ�ϵ� IExceptionFilter �Ľӿ�ʵ�֡�������

������handleError��


���������ν��handleError��ҵ�����߼�

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


�������ǲ���һ�£���index�й����׳��쳣������

 <customErrors mode="On"></customErrors>

 ���ʱ��Ϳ��Գɹ�����ת�� errorҳ�档

 ��װ��Խ����������չ�Ծ�Խ�����

 �Ҳ���Ҫ��handlerError��ҵ���߼����һ���Ҫ��¼db������


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



