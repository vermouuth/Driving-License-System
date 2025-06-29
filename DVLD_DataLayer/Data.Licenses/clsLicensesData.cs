using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensesDataAccessLayer
{
    public class clsLicensesData
    {
        public static int InsertNewLicense(int ApplicationID , int DriverID ,int LicenseClass , DateTime IssueDate , DateTime ExpirationDate , string Notes , decimal PaidFees , bool isActive , byte IssueReason  , int CreatedBy)
        {

            int ID = -1;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Qury = @"INSERT INTO Licenses
                         ([ApplicationID] ,[DriverID] ,[LicenseClass] ,[IssueDate] ,[ExpirationDate] ,[Notes] ,[PaidFees] ,[IsActive] ,[IssueReason] ,[CreatedByUserID])
                         VALUES
                         (@ApplicationID , @DriverID , @LicenseClass , @IssueDate , @ExpirationDate , @Notes , @PaidFees , @IsActive , @IssueReason ,@CreatedByUserID)
                         SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand (Qury, conn);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", isActive);
            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedBy);

            if(Notes != "")
            {
                cmd.Parameters.AddWithValue("@Notes", Notes); /////
            }
            else
            {
                cmd.Parameters.AddWithValue("@Notes", System.DBNull.Value); /////

            }

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(),out int LicenseID))
                {
                    ID = LicenseID;
                }

            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            return ID;

        }

        public static bool GetLicesneInfoToInfoCard(int LicenseClassID , int LocalAppID, ref int LicenseID, ref int DriverID , ref DateTime IssueDate , ref string IssueReason , ref string Notes , ref bool isActive , ref DateTime ExpirationDate)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select
	                         Licenses.LicenseID,
	                         Licenses.DriverID,
	                         Licenses.IssueDate,
	                         case
	                         when Licenses.IssueReason = 1 then 'Frist Time'
	                         when Licenses.IssueReason = 2 then 'Second Time'
	                         when Licenses.IssueReason = 3 then 'Third Time'
	                         when Licenses.IssueReason = 4 then 'Fourth Time'
	                         when Licenses.IssueReason = 5 then 'Fifth Time'
	                         when Licenses.IssueReason = 6 then 'Sith Time'
	                         when Licenses.IssueReason = 7 then 'Seventh Time'
	                         End as IssueReason,
	                         Licenses.Notes,
	                         Licenses.IsActive,
	                         Licenses.ExpirationDate
	                         from Licenses inner join Applications on Applications.ApplicationID = Licenses.ApplicationID
	                         inner Join LocalDrivingLicenseApplications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
	                         where LicenseClass = @LicenseClassID and LocalDrivingLicenseApplicationID = @LocalAppID ";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            cmd.Parameters.AddWithValue("@LocalAppID", LocalAppID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) 
                {
                    isFound = true; 

                    LicenseID = (int)reader["LicenseID"];
                    DriverID = (int)reader["DriverID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    IssueReason = (string)reader["IssueReason"];
                    isActive = (bool)reader["IsActive"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    Notes = reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"];

                }

                reader.Close();

            }
            catch (Exception)
            {

            }
            finally {  connection.Close(); }
                

            return isFound;
        }

        public static bool GetAllLicenseInfo(int LicenseID , ref string ClassName ,ref string FullName , ref string NationalNo ,
            ref string Gendor , ref DateTime IssueDate, ref string IsssueReason , ref string Notes ,  ref string isActive ,
            ref DateTime DateOfBirth , ref int DriverID , ref DateTime ExpirationDate , ref string ImagePath)
        {
            bool isfound  = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from LicenseInfoView where LicenseID = @LicenseID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;

                    ClassName = (string)reader["ClassName"];
                    FullName = (string)reader["FullName"];
                    NationalNo = (string)reader["NationalNo"];
                    Gendor = (string)reader["Gendor"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    IsssueReason = (string)reader["IssueReason"];
                    if (reader["Notes"] == DBNull.Value)
                    {
                        Notes = "No Notes";
                    }
                    else
                    {
                        Notes = (string)reader["Notes"];
                    }                   
                    isActive = (string)reader["IsActive"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    DriverID = (int)reader["DriverID"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    if (reader["ImagePath"] == DBNull.Value)
                    {
                        ImagePath = "";
                    }
                    else
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }

                }
                reader.Close();
            }
            catch (Exception)
            {

            }
            finally {  conn.Close(); }

            return isfound;
        }

        public static bool GetShortLicenseInfo(int LicenseID, ref int ApplicationID , ref int DriverID , ref int LicenseClass)
        {
            bool isfound = false;
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select Licenses.LicenseID , Licenses.ApplicationID , Licenses.DriverID , Licenses.LicenseClass
						   from Licenses
						   where Licenses.LicenseID = @LicenseID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {

                connection.Open() ;

                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    isfound = true;

                    ApplicationID = (int)sqlDataReader["ApplicationID"];
                    DriverID = (int)sqlDataReader["DriverID"];
                    LicenseClass = (int)sqlDataReader["LicenseClass"];


                }

                sqlDataReader.Close();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return isfound;
        }

        public static int GetLicenseIDbyAppID(int ApplicationID)
        {
            int ID = -1;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select Licenses.LicenseID from Licenses where Licenses.ApplicationID =@ApplicationID";

            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                conn.Open() ;

                object result = cmd.ExecuteScalar();

                if( result != null  && int.TryParse(result.ToString(), out int LicenseID))
                {
                    ID = LicenseID;
                }

            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            return ID;
        }

        public static bool IsLicenseExist(int LicenseID)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select 1 as  Found from  Licenses where LicenseID = @LicenseID";

            SqlCommand cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                isfound = sqlDataReader.HasRows;
                sqlDataReader.Close();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }
            
            return isfound;
        }

        public static bool IsLicenseActive(int LicenseID)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select found = 1 from Licenses where LicenseID = @LicenseID and IsActive = 1";

            SqlCommand cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {

                connection.Open ();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                isfound = sqlDataReader.HasRows;
                sqlDataReader.Close();

            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }

            return isfound;
        }

        public static bool IsLicenseExipred(int LicenseID)
        {
            bool isfound = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select found = 1 from Licenses where LicenseID = @LicenseID and Licenses.ExpirationDate <  GETDATE() and IsActive = 1;";

            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                conn.Open ();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                isfound = sqlDataReader.HasRows;
                sqlDataReader.Close();
            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            return isfound; 
        }

        public static bool DeActiveLicenseByID(int LicenseID)
        {
            int Rowaffected = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Update Licenses set IsActive = 0  where LicenseID = @LicenseID";

            SqlCommand cmd =new SqlCommand(Query,conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                conn.Open();
                Rowaffected = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            return Rowaffected > 0;
        }

      

    }
}
