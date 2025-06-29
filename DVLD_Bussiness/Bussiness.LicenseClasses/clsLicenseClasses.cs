using LicensesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLicenseClasses
    {
        public int _ID { get; set; }
        public string _ClassName { get; set; }
        public string _ClassDescription { get; set; }
        public decimal _ClassFees { get; set; }
        public byte _DefaultValidityLength { get; set; }
        public byte _MinimumAllowedAge { get; set; }

        private clsLicenseClasses(int ID, string className, string classDescription, decimal classFees, byte defaultValidity, byte minAge)
        {
            _ID = ID;
            _ClassName = className;
            _ClassDescription = classDescription;
            _ClassFees = classFees;
            _DefaultValidityLength = defaultValidity;
            _MinimumAllowedAge = minAge;
        }

        public static clsLicenseClasses Find(int ID)
        {
            string className = "";
            string classDescription = "";
            decimal classFees = 0;
            byte defaultValidity = 0;
            byte minAge = 0;

            if (clsLicenseClassesData.GetLicenseClassByID(ID, ref className, ref classDescription, ref classFees, ref defaultValidity, ref minAge))
            {
                return new clsLicenseClasses(ID, className, classDescription, classFees, defaultValidity, minAge);
            }
            else
            {
                return null;
            }
        }


        public static clsLicenseClasses Find(string ClassName)
        {
            int ClassID = -1;
            string classDescription = "";
            decimal classFees = 0;
            byte defaultValidity = 0;
            byte minAge = 0;

            if (clsLicenseClassesData.GetLicenseClassByName(ClassName, ref ClassID, ref classDescription, ref classFees, ref defaultValidity, ref minAge))
            {
                return new clsLicenseClasses(ClassID, ClassName, classDescription, classFees, defaultValidity, minAge);
            }
            else
            {
                return null;
            }
        }


        public static DataTable GetLicenseClasses()
        {
            return clsLicenseClassesData.GetAllLicenseClasses();
        }

        public bool UpdateLicenseClass()
        {
            return clsLicenseClassesData.UpdateLicenseClass(this._ID, this._ClassName, this._ClassDescription, this._ClassFees, this._DefaultValidityLength, this._MinimumAllowedAge);
        }
    }
}
