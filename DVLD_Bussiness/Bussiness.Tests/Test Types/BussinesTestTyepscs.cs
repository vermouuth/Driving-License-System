using LicensesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class clsTestTypes
    {
        public int _ID { get; set; }

        public string _TestTitle { get; set; }

        public string _TestDescription { get; set; }

        public decimal _Fees { get; set; }

        clsTestTypes(int ID, string TestTitle, string TestDescription,  decimal fees)
        {
            _ID = ID;
            _TestTitle = TestTitle;
            _TestDescription = TestDescription;
            _Fees = fees;
        }


        public static clsTestTypes Find(int ID)
        {
            
            string TestTitle = "";
            string TestDescription = "";
            decimal fees = 0;
          

            if (clsTestsTypesData.GetTestType(ID, ref TestTitle, ref TestDescription, ref fees))
            {
                return new clsTestTypes(ID, TestTitle, TestDescription, fees);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetTests()
        {
            return clsTestsTypesData.GetAllTestTypes();
        }

        public bool UpdateTestInfo()
        {
            return clsTestsTypesData.UpdateTestData(_ID, _TestTitle, _TestDescription, _Fees);
        }
    }
}
