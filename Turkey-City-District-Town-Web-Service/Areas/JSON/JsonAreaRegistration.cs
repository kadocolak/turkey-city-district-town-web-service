using System.Web.Mvc;

namespace Sehir_İlce_Mahalle_Web_Servis.Areas.Json
{
    public class JsonAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Json";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Json_default",
                "Json/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}