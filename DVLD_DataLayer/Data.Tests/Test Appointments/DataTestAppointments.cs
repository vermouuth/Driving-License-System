using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensesDataAccessLayer
{
    public class clsTestAppointmentsData
    {

        public static int GetTestAppointmentID(int LocalApplcationID , int TestTypeID)
        {
            int _ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select TOP 1 TestAppointments.TestAppointmentID from TestAppointments
                            where TestAppointments.LocalDrivingLicenseApplicationID = 31
                            and TestAppointments.TestTypeID = 2 and IsLocked = 1
                            order by TestAppointments.AppointmentDate desc ";

            SqlCommand commander = new SqlCommand(Query, connection);
            commander.Parameters.AddWithValue("@LocalApplcationID", LocalApplcationID);
            commander.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = commander.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out int TestID))
                {
                    _ID = TestID;
                }

            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }



            return _ID;
        }

        public static bool GetTestAppInfo(int TestAppointmentID, ref int TestAppType , ref int LocalDrivingApp ,ref DateTime AppDate , ref decimal Fees , ref int CreatedBy , ref bool IsLoocked )
        {
            bool isfound = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from TestAppointments WHERE TestAppointmentID = @TestAppointmentID ";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) 
                {
                    isfound = true;
                    TestAppType = (int)reader["TestTypeID"];
                    LocalDrivingApp = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppDate = (DateTime)reader["AppointmentDate"];
                    Fees = (decimal)reader["PaidFees"];
                    CreatedBy = (int)reader["CreatedByUserID"];
                    IsLoocked = (bool)reader["IsLocked"];

                }

                reader.Close();

            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            return isfound;
        }

        public static int InsertTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            int TestAppointmentID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked)
                VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked);
                SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                cmd.Parameters.AddWithValue("@IsLocked", IsLocked);

                try
                {
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        TestAppointmentID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return TestAppointmentID;
        }

        public static bool UpdateAppointmentDate(int TestAppointmentID, DateTime AppointmentDate)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                UPDATE TestAppointments 
                SET AppointmentDate = @AppointmentDate
                WHERE TestAppointmentID = @TestAppointmentID;";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);

                try
                {
                    connection.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return (rowsAffected > 0);
        }

        public static bool UpdateAppointmentLocker(int TestAppointmentID, bool isLocked)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
                UPDATE TestAppointments 
                SET IsLocked = @IsLocked
                WHERE TestAppointmentID = @TestAppointmentID;";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                cmd.Parameters.AddWithValue("@IsLocked", isLocked);

                try
                {
                    connection.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return (rowsAffected > 0);
        }

        public static bool DeleteTestAppointment(int TestAppointmentID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "DELETE FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                try
                {
                    connection.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetListOfTestsRelateToApplication(int LocalDrivingID , int TestTypeID)
        {
            DataTable TestAppiontemnts = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"  select 
                              TestAppointments.TestAppointmentID,
                              TestAppointments.AppointmentDate,
                              TestAppointments.PaidFees,
                              TestAppointments.IsLocked
                              from TestAppointments 
                              where TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingID and TestAppointments.TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingID",LocalDrivingID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    TestAppiontemnts.Load(reader);
                }    
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); } 

            return TestAppiontemnts;

        }

        public static bool IsLocalAppHasTestsWithTestType(int LocalDrivingID , int TestTypeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"  select found = 1
						     from
						     ( select 
                              TestAppointments.TestAppointmentID,
                              TestAppointments.AppointmentDate,
                              TestAppointments.PaidFees,
                              TestAppointments.IsLocked
                              from TestAppointments 
                              where TestAppointments.LocalDrivingLicenseApplicationID = 31 and TestAppointments.TestTypeID = 1
						     ) as SubQuery";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingID", LocalDrivingID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
               isFound = reader.HasRows;
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return isFound;
        }

        public static bool IsTestLooked(int TestAppointmentID,bool isLocked)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select found = 1 from TestAppointments where TestAppointmentID  = @TestAppointmentID and IsLocked = @IsLocked";
            
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@IsLocked", isLocked);


            try
            {
                connection.Open ();
                SqlDataReader reader = cmd.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();

            }
            catch (Exception)
            {

            }
            finally { connection.Close(); } 

            return isFound;
        }


        public static bool isThereNonLockedTest(int LocalDrivingID,int TestTypeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select found = 1 from TestAppointments
                            where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                            and IsLocked = 0
                            and TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
                    
            }
            catch (Exception)
            {

                isFound = false;
            }
            finally { connection.Close(); }


            return isFound; 
        }

        public static int Trials(int TestTypeID , int LocalDrivingID)
        {
            int _Trials = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"  select
                             Count(Tests.TestID) as Trials
                             from Tests Inner Join TestAppointments on TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             where TestAppointments.TestTypeID = @TestTypeID and TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingID";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingID", LocalDrivingID);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int Trials))
                {
                    _Trials = Trials;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return _Trials;
         }

        public static bool SucceededTested(int LocalDrivingID, int TestTypeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @" select 1 as  Found from                           
                             (
                             select 
                            		  Tests.TestResult,
                            		  TestAppointments.LocalDrivingLicenseApplicationID
                            		  from Tests 
                            		  inner join TestAppointments on TestAppointments.TestAppointmentID = Tests.TestAppointmentID	
                            		  where TestAppointments.TestTypeID = @TestTypeID and TestResult =  1 and TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingID
                            )as SubQuery";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingID", LocalDrivingID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();

            }
            catch (Exception)
            {
                isFound = false;
            }
            finally { connection.Close(); } 

            return isFound;
        }

    }
}
