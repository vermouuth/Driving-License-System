using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensesDataAccessLayer
{
    public class clsTestsData
    {
        public static int AddNewTest(int TestAppointmentID , bool TestResult , string Note , int CreatedBy)
        {
            int TestID = -1;
            
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"  INSERT INTO [dbo].[Tests]     
                               (TestAppointmentID ,TestResult ,Notes ,CreatedByUserID)
                               VALUES
                               (@TestAppointmentID ,  @TestResult ,@Note, @CreatedBy)
                               SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);

            if(Note != "")
            {
                cmd.Parameters.AddWithValue("@Note", Note);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Note", System.DBNull.Value);
            }


            try
            {
                conn.Open();

                object Result = cmd.ExecuteScalar();

                if(Result != null && int.TryParse(Result.ToString(),out int ID))
                {
                    TestID = ID;
                }

            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }


            return TestID;

        }
    }
}
