using System.Web.Mvc;

namespace _23Area在mvc中的使用以及架构思想.Areas.flight
{
    public class flightAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "flight";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "flight_default",
                "flight/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}