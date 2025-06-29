using LicensesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class clsApplicationTypes
    {
       public int _ID { get; set; }

       public string _ApplicationTypeTile { get; set; }
        
       public decimal _Fees { get; set; }

        clsApplicationTypes(int ID , string AppTitle , decimal fees)
        {
            _ID = ID;
            _ApplicationTypeTile = AppTitle;
            _Fees = fees;
        }


        public static clsApplicationTypes Find(int ID)
        {
            string AppTitle = "";
            decimal fees = 0;

            if(clsApplicationTypesData.GetApplicationTypeInfoByID(ID,ref AppTitle,ref fees))
            {
                return new clsApplicationTypes(ID, AppTitle, fees);
            }
            else
            {
                return null;
            }
        }


        public static DataTable GetApps()
        {
            return clsApplicationTypesData.GetAllApplications();
        }

        public bool UpdateAppFees()
        {
            return clsApplicationTypesData.UpdateApplicationsFees(this._ID,this._ApplicationTypeTile ,this._Fees);
        }

        
    }
}
