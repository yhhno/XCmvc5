using System.Web.Mvc;

namespace _23Area在mvc中的使用以及架构思想.Areas.Hotel
{
    public class HotelAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Hotel";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Hotel_default",
                "Hotel/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                
            );
        }
    }
}