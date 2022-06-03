using System.Collections.Generic;
using System.Linq;
using Sehir_İlce_Mahalle_Web_Servis.Models;

namespace Sehir_İlce_Mahalle_Web_Servis.Class
{
    public class DataMain
    {
        public TurkeyLocationEntities LocationDB = new TurkeyLocationEntities();
        public static string sehirAdi = "";

        Operation operation = new Operation();

        public List<city> ShowAllCity()
        {
            var data = LocationDB.cities.ToList();
            return data;
        }

        public List<ShowDistrict_Result> ShowDistrict(int plate)
        {
            plate = operation.checkNumber(plate);
            sehirAdi = operation.generateCityName(plate);
            sehirAdi = operation.textOperation(sehirAdi);
            var data = LocationDB.ShowDistrict(sehirAdi).ToList();
            return data;
        }

        public List<ShowTown_Result> ShowTown(int plate, string district)
        {
            plate = operation.checkNumber(plate);
            sehirAdi = operation.generateCityName(plate);
            sehirAdi = operation.textOperation(sehirAdi);
            district = operation.textOperation(district);
            var data = LocationDB.ShowTown(sehirAdi, district).ToList();
            return data;
        }

        public List<developer> ShowDeveloper()
        {
            var data = LocationDB.developers.ToList();
            return data;
        }
    }
}