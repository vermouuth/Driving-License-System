using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensesDataAccessLayer
{
    public class clsTestsTypesData
    {
        public static bool GetTestType(int TestID, ref string TestTitle, ref string TestDescription ,ref decimal TestFees)
        {
            bool isfound = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from TestTypes where TestTypeID = @TestID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    TestTitle = (string)reader["TestTypeTitle"];
                    TestDescription = (string)reader["TestTypeDescription"];
                    TestFees = (decimal)reader["TestTypeFees"];
                }

                reader.Close();

            }
            catch (Exception)
            {
                isfound = false;
            }
            finally { conn.Close(); }

            return isfound;

        }

        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from TestTypes";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            return dt;
        }

        public static bool UpdateTestData(int TestID, string TestTitle, string TestDescription, decimal TestFees)
        {
            int rowaffected = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"update TestTypes set [TestTypeFees] = @TestFees ,[TestTypeTitle] = @TestTitle , 
                                    [TestTypeDescription] = @TestDescription   where TestTypeID = @TestID ";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@TestFees", TestFees);
            command.Parameters.AddWithValue("@TestTitle", TestTitle);
            command.Parameters.AddWithValue("@TestDescription", TestDescription);
            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                conn.Open();

                rowaffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            return (rowaffected > 0);
        }


    }
}
