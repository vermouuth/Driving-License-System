using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensesDataAccessLayer
{
    public class clsLicenseClassesData
    {
        public static bool GetLicenseClassByID(int classID, ref string className, ref string classDescription, ref decimal classFees, ref byte defaultValidity, ref byte minAge)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @ClassID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ClassID", classID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    className = (string)reader["ClassName"];
                    classDescription = (string)reader["ClassDescription"];
                    classFees = (decimal)reader["ClassFees"];
                    defaultValidity = (byte)reader["DefaultValidityLength"]; // TinyInt -> byte
                    minAge = (byte)reader["MinimumAllowedAge"]; // TinyInt -> byte
                }

                reader.Close();
            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }

        public static bool GetLicenseClassByName(string className, ref int classID, ref string classDescription, ref decimal classFees, ref byte defaultValidity, ref byte minAge)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LicenseClasses WHERE ClassName =  @className";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@className", className);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    classID = (int)reader["LicenseClassID"];
                    classDescription = (string)reader["ClassDescription"];
                    classFees = (decimal)reader["ClassFees"];
                    defaultValidity = (byte)reader["DefaultValidityLength"]; // TinyInt -> byte
                    minAge = (byte)reader["MinimumAllowedAge"]; // TinyInt -> byte
                }

                reader.Close();
            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }


        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LicenseClasses";

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
                // Handle exceptions if necessary
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static bool UpdateLicenseClass(int classID, string className, string classDescription, decimal classFees, byte defaultValidity, byte minAge)
        {
            int rowsAffected = 0;
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE LicenseClasses SET ClassName = @ClassName, ClassDescription = @ClassDescription, ClassFees = @ClassFees, DefaultValidityLength = @DefaultValidity, MinimumAllowedAge = @MinAge WHERE LicenseClassID = @ClassID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ClassName", className);
            cmd.Parameters.AddWithValue("@ClassDescription", classDescription);
            cmd.Parameters.AddWithValue("@ClassFees", classFees);
            cmd.Parameters.AddWithValue("@DefaultValidity", defaultValidity); // TinyInt -> byte
            cmd.Parameters.AddWithValue("@MinAge", minAge); // TinyInt -> byte
            cmd.Parameters.AddWithValue("@ClassID", classID);

            try
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                // Handle exceptions if necessary
            }
            finally
            {
                conn.Close();
            }

            return (rowsAffected > 0);
        }



    }
}
