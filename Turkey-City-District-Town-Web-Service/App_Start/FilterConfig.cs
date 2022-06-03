using System.Web;
using System.Web.Mvc;

namespace Sehir_İlce_Mahalle_Web_Servis
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
