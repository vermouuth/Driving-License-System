using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LicensesDataAccessLayer;

namespace BussinessLayer
{
    public class clsCountry
    {
        public int _CountryID { get; set; }
        public string _CountryName { get; set; }
        private clsCountry(int CountryID , string CountryName) 
        {
            _CountryID = CountryID;
            _CountryName = CountryName;
        }

        public static clsCountry Find (int CountryID)
        {
            string CountryName = "";

            if(clsCountryData.GetCountryByID(CountryID , ref CountryName))

                return new clsCountry(CountryID, CountryName);

            else
                return null;

        }

        public static clsCountry Find(string CountryName)
        {
            int CountryID = -1;

            if (clsCountryData.GetCountryByName(CountryName, ref CountryID))

                return new clsCountry(CountryID, CountryName);

            else
                return null;

        }


        public static DataTable GetCountries()
        {
            return clsCountryData.GetCountryDataTable();
        }
    }
}
