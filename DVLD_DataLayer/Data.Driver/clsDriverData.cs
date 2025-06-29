using System;
using System.Data;
using System.Data.SqlClient;


namespace LicensesDataAccessLayer
{
    public class clsDriverData
    {
        public static bool GetDriverInfo(int DriverID, ref int PersonID, ref int UserID, ref DateTime CreatedDate)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Drivers where DriverID = @DriverID";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    UserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                }

                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return isFound;

        }


        public static bool GetDriverInfoByPerson(int PersonID, ref int DriverID, ref int UserID, ref DateTime CreatedDate)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Drivers where PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    isFound = true;

                    DriverID = (int)reader["DriverID"];
                    UserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                }

                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return isFound;

        }

        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into Drivers
                          (PersonID,CreatedByUserID, CreatedDate)
                          values
                          (@PersonID , @CreatedByUserID , @CreatedDate)
                          SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID  ", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("CreatedDate", CreatedDate);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ID = InsertedID;
                }
            }
            catch (Exception)
            {

            }

            finally
            {
                connection.Close();
            }

            return ID;


        }

        public static bool isDriverExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select found = 1 from Drivers where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

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
            finally
            {
                connection.Close();
            }
            return isFound;

        }

        public static DataTable GetDriversData()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Drivers_View";

            SqlCommand sqlCommand = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if(reader.HasRows)
                {
                    table.Load(reader);
                }

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally {connection.Close(); }

            return table;
        }

        public static DataTable GetLocalDriverLicenses(int PersonID)
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString) ;
            string query = @"SELECT Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive
                             FROM Applications INNER JOIN
                             Licenses ON Applications.ApplicationID = Licenses.ApplicationID INNER JOIN
                             LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
						     inner join Drivers on Licenses.DriverID = Drivers.DriverID
						     where Drivers.PersonID = @PersonID";

            SqlCommand sqlCommand = new SqlCommand( query, connection);
            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open ();

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if(reader.HasRows) 
                {
                    table.Load(reader);
                }
                else
                {
                    return table = null;
                }

                reader.Close();

            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return  table ;
        }

        public static DataTable GetInterNationalDriverLicenses(int PersonID)
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT InternationalLicenses.InternationalLicenseID,
                             InternationalLicenses.ApplicationID,
                             InternationalLicenses.IssuedUsingLocalLicenseID,
                             InternationalLicenses.IssueDate,
                             InternationalLicenses.ExpirationDate, 
                             InternationalLicenses.IsActive
                             FROM  
                             InternationalLicenses INNER JOIN Drivers ON InternationalLicenses.DriverID = Drivers.DriverID
                             where PersonID = @PersonID and IsActive = 1";

            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }
                else
                {
                    return table = null;
                }

                reader.Close();

            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return table;
        }


    }
}
