using System.Collections.Generic;
using System.Web.Services;
using Sehir_İlce_Mahalle_Web_Servis.Models;
using Sehir_İlce_Mahalle_Web_Servis.Class;

namespace Sehir_İlce_Mahalle_Web_Servis.Areas.Soap
{
    
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class TurkeyLocation : System.Web.Services.WebService
    {
        public TurkeyLocationEntities LocationDB = new TurkeyLocationEntities();
        DataMain dataMain = new DataMain();

        [WebMethod]
        public List<city> ShowAllCity()
        {
            var result = dataMain.ShowAllCity();
            return result;
        }

        [WebMethod]
        public List<ShowDistrict_Result> ShowDistrict(VirtualDistrict district)
        {
            var result = dataMain.ShowDistrict(district.plate);
            return result;
        }

        [WebMethod]
        public List<ShowTown_Result> ShowTown(VirtualTown town)
        {
            var result = dataMain.ShowTown(town.plate,town.district);
            return result;
        }

        [WebMethod]
        public List<developer> DeveloperInfo()
        {
            var result = dataMain.ShowDeveloper();
            return result;
        }
    }
}
