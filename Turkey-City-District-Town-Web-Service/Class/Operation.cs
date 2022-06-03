using Sehir_İlce_Mahalle_Web_Servis.Models;

namespace Sehir_İlce_Mahalle_Web_Servis.Class
{
    public class Operation
    {
        public TurkeyLocationEntities LocationDB = new TurkeyLocationEntities();

        public string textOperation(string value)
        {
            value = checkEmpty(value);
            value = textToUpper(value);
            return value;
        }

        public string textToUpper(string value)
        {
            value = value.ToUpper();
            return value;
        }

        public string checkEmpty(string value)
        {
            value = value.Trim();
            return value;
        }

        public int checkNumber(int value)
        {
            if (value % 1 == 0) return value;
            else return 0;
        }

        public string generateCityName(int id)
        {
            try
            {
                var result = LocationDB.cities.Find(id);
                return result.TEXT.ToString();
            }
            catch
            {
                return "sehirYok";
            }
        }
    }
}