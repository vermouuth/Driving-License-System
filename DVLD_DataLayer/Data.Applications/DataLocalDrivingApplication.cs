using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensesDataAccessLayer
{
    public class clsLocalDrivingApplicationData
    {
        public static bool GetLocalAppByLocalID(int LocalAppID ,ref int AppID , ref int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalAppID);

            try
            {

              

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())  // If a row is found
                {
                    IsFound = true;
                    AppID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }


            return IsFound;
        }

        public static bool GetLocalAppByID(int ApplicationID, ref int LocalID, ref int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {



                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())  // If a row is found
                {
                    IsFound = true;
                    LocalID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }


            return IsFound;
        }



        public static bool GetLocalInfo(int LocalID, ref string ClassName,ref string NationalNo ,ref string FullName , ref DateTime AppDate,ref int PassedTestCount,ref string Status)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "   select * from LocalDrivingLicenseApplications_View where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalID);

            try
            {



                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())  // If a row is found
                {
                    IsFound = true;
                    ClassName = (string)reader["ClassName"];
                    NationalNo = (string)reader["NationalNo"];
                    FullName = (string)reader["FullName"];
                    AppDate = (DateTime)reader["ApplicationDate"];
                    PassedTestCount = (int)reader["PassedTestCount"];
                    Status = (string)reader["Status"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }


            return IsFound;
        }

        public static int InsertIntoLocalLicenses(int ApplicaitonID, int LicenseClassID)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert into LocalDrivingLicenseApplications 
                            (ApplicationID , LicenseClassID)
                      values(@ApplicationID,@LicenseClassID)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicaitonID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    ID = insertID;
                }


            }
            catch (Exception)
            {

            }

            finally { connection.Close(); }

            return ID;
        }

        public static bool UpdateLocalApplication(int ApplicationID , int ClassID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"UPDATE [LocalDrivingLicenseApplications]
                          Set [LicenseClassID] = @ClassID
                          WHERE  ApplicationID = @ApplicationID ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClassID", ClassID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }

            return RowAffected > 0; 

        }

        public static bool DeleteLocalApplication(int LocalDrivingLicenseApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }



            return (rowsAffected > 0);
        }


    }
}
