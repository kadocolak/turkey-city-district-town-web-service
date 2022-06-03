using System.Web.Mvc;
using Sehir_İlce_Mahalle_Web_Servis.Models;
using Sehir_İlce_Mahalle_Web_Servis.Class;

namespace Sehir_İlce_Mahalle_Web_Servis.Areas.Json.Controllers
{
    public class APIController : Controller
    {
        public TurkeyLocationEntities LocationDB = new TurkeyLocationEntities();
        DataMain dataMain = new DataMain();

        public ActionResult Index()
        {
            return Redirect("https://api.kadircolak.com/Konum/");
        }

        public JsonResult ShowAllCity()
        {
            try
            {
                var result = dataMain.ShowAllCity();
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json("not connect database", JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult ShowDistrict(VirtualDistrict district)
        {
            try
            {
                var result = dataMain.ShowDistrict(district.plate);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json("not connect database", JsonRequestBehavior.AllowGet);
            }
        }
        
        public JsonResult ShowTown(VirtualTown town)
        {
            try
            {
                var result = dataMain.ShowTown(town.plate, town.district);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json("not connect database", JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult DeveloperInfo()
        {
            try
            {
                var result = dataMain.ShowDeveloper();
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json("not connect database", JsonRequestBehavior.AllowGet);
            }
        }
        
    }
}