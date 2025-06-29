using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using static System.Net.Mime.MediaTypeNames;

namespace LicensesDataAccessLayer
{
    public class clsApplicationsData
    {
        public static bool GetApplicationByID(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID,
                                              ref byte ApplicationStatus, ref int CreatedByUserID, ref DateTime LastStatusDate, ref decimal PaidFees)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        IsFound = true;
                        ApplicantPersonID = (int)reader["ApplicantPersonID"];
                        ApplicationDate = (DateTime)reader["ApplicationDate"];
                        ApplicationStatus = (byte)reader["ApplicationStatus"];
                        ApplicationTypeID = (int)reader["ApplicationTypeID"];
                        CreatedByUserID = (int)reader["CreatedByUserID"];
                        LastStatusDate = (DateTime)reader["LastStatusDate"];
                        PaidFees = (decimal)reader["PaidFees"];
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally { connection.Close(); }
            }

            return IsFound;
        }

        public static bool GetAllAppBasicInfoByID(int ApplicationID, ref string Status, ref decimal PaidFees , ref string ApplicationType , ref string FullName , ref DateTime AppDate, ref DateTime StatusDate , ref string CreatedBy   )
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from ApplicationBasicInfo Where ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {

                

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())  // If a row is found
                {
                    IsFound = true;
                    Status = (string)reader["Status"];
                    PaidFees = (decimal)reader["PaidFees"];
                    ApplicationType = (string)reader["ApplicationTypeTitle"];
                    FullName = (string)reader["FullName"];
                    AppDate = (DateTime)reader["ApplicationDate"];
                    StatusDate = (DateTime)reader["LastStatusDate"];
                    CreatedBy = (string)reader["UserName"];


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

        public static int AddNewApplication(int ApplicantPerson, DateTime ApplicationDate, byte ApplicationStatus, int ApplicationTypeID,
                                            int CreatedByUserID, DateTime LastStatusDate, decimal PaidFees)
        {
            int newID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = @"INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationStatus, ApplicationTypeID,
                              CreatedByUserID, LastStatusDate, PaidFees) 
                               VALUES (@ApplicantPersonID, @ApplicationDate, @ApplicationStatus, @ApplicationTypeID,
                                 @CreatedByUserID, @LastStatusDate, @PaidFees);
                                 SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPerson);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    newID = insertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            
            finally { connection.Close(); }

            return newID;
        }

        public static bool UpdateApplication(int ApplicationID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "UPDATE Applications SET ApplicationStatus = @ApplicationStatus, LastStatusDate = @LastStatusDate, PaidFees = @PaidFees WHERE ApplicationID = @ApplicationID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                cmd.Parameters.AddWithValue("@PaidFees", PaidFees);

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
            }

            return (rowsAffected > 0);
        }

        public static bool UpdateApplcaitonStatus(int ApplicationID , int ApplcaitonStatus)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);           
            string query = @"UPDATE [dbo].[Applications]
                            SET ApplicationStatus = @ApplcaitonStatus       
                            WHERE Applications.ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@ApplcaitonStatus", ApplcaitonStatus);

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

        public static bool DeleteApplication(int ApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            
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

        public static DataTable GetAllApplications()
        {
            DataTable Applications = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT * FROM LocalDrivingLicenseApplications_View";

            SqlCommand cmd = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader readr = cmd.ExecuteReader();

                if(readr.HasRows)
                {
                    Applications.Load(readr);
                }

                readr.Close();


            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return Applications;

        }

        public static bool CheackPersonHasApp(int PersonID , int LicenseClassID , ref int ApplicationID)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"SELECT TOP 1 Applications.ApplicationID, 1 AS found
                            FROM Applications
                            INNER JOIN LocalDrivingLicenseApplications 
                            ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                            WHERE Applications.ApplicantPersonID = @PersonID 
                            AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID 
                            AND Applications.ApplicationStatus = 1;";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read()) // Ensure we have data before accessing it
                {
                    isFound = true;
                    ApplicationID = Reader.GetInt32(0); // Get the ApplicationID
                }

                Reader.Close();

            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return isFound;

        }

        public static bool isApplicationHasLicense(int ApplicaitonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = " select found = 1 from Licenses where ApplicationID = @ApplicaitonID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicaitonID", ApplicaitonID);

            try
            {
                connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                isFound = Reader.HasRows; 

            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return isFound;    
        }

        public static bool PersonHasActiveLicense(int PersonID , int LicenseClass)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select found = 1 from
                           ( select Licenses.LicenseID,
                            Licenses.LicenseClass,
                            Drivers.PersonID from Licenses 
                            inner join Drivers on Drivers.DriverID = Licenses.DriverID
                            where Drivers.PersonID = @PersonID and LicenseClass = @LicenseClass and Licenses.IsActive = 1
                           )AS SubQuery";

            SqlCommand cmd = new SqlCommand(query , connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);

            try
            {
                connection.Open ();

                SqlDataReader Reader = cmd.ExecuteReader();
                isFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return isFound;
        }



    }
}