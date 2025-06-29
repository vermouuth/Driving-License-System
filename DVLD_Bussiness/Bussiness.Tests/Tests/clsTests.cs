using LicensesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class clsTests
    {
        public int TestID { get; set; } 

        public int TestAppiontmentID { get; set; } 

        public bool TestResult { get; set; }  
        
        public string Note { get; set; }  

        public int CratedBy {  get; set; }

        public clsTests() 
        {
            TestID = -1;
            TestAppiontmentID = -1;
            TestResult = false;
            Note = string.Empty;
            CratedBy = -1;
        }


        public bool AddNewTest()
        {
            this.TestID = clsTestsData.AddNewTest(TestAppiontmentID,TestResult,Note,CratedBy);

            return (TestID > 0);
        }
    }
}
