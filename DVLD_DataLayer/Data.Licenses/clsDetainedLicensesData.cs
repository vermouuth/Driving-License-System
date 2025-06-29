using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensesDataAccessLayer
{
    public class clsDetainedLicensesData
    {
        public static bool IsLicenseDetaind(int LicensesID)
        {
            bool found = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select found = 1 from DetainedLicenses where LicenseID = @LicenseID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicensesID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                found = reader.HasRows;
                reader.Close();
            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }
        
            return found;
        }

        public static bool DetianAllLicense(int LicenseID)
        {
            int rowsAffected = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"update DetainedLicenses
                            set IsReleased = 0
                            where LicenseID  = @LicenseID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;

            }
            finally
            {
                conn.Close();
            }

            return (rowsAffected > 0);


        }

        public static bool ReleaseAllLicense(int LicenseID)
        {
            int rowsAffected = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"update DetainedLicenses
                            set IsReleased = 1
                            where LicenseID  = @LicenseID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;

            }
            finally
            {
                conn.Close();
            }

            return (rowsAffected > 0);


        }


        public static bool IsLicenseReleased(int LicenseID)
        {
            bool found = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select found = 1 from DetainedLicenses where LicenseID = @LicenseID and IsReleased = 1";

            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                found = reader.HasRows;
                reader.Close(); 
            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            return found;

        }

        public static int InsertNewDetaindLicense(int xLicenseID, DateTime DetaindDate, decimal DFees , int CreatedBy,
                         bool Released ,DateTime xReleasedDate, int RelaesedBy , int ReleasdAppID)
        {
            int ID = -1;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[DetainedLicenses]
                             ([LicenseID]
                             ,[DetainDate]
                             ,[FineFees]
                             ,[CreatedByUserID]
                             ,[IsReleased]
                             ,[ReleaseDate]
                             ,[ReleasedByUserID]
                             ,[ReleaseApplicationID])
                              VALUES
                             (@xLicenseID, @DetaindDate,@DFees,@CreatedBy,@Released ,@xReleasedDate,@RelaesedBy,@ReleasdAppID)
		                     SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(@query,conn);
            cmd.Parameters.AddWithValue("@xLicenseID", xLicenseID);
            cmd.Parameters.AddWithValue("@DetaindDate", DetaindDate);
            cmd.Parameters.AddWithValue("@DFees", DFees);
            cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
            cmd.Parameters.AddWithValue("@Released", Released);


            if (xReleasedDate == new DateTime())
                cmd.Parameters.AddWithValue("@xReleasedDate", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@xReleasedDate", xReleasedDate);

            if (RelaesedBy == 0) 
                cmd.Parameters.AddWithValue("@RelaesedBy", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@RelaesedBy", RelaesedBy);


            if (ReleasdAppID == 0)
                cmd.Parameters.AddWithValue("@ReleasdAppID", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@ReleasdAppID", ReleasdAppID);


            try
            {
                conn.Open();
                object reasult = cmd.ExecuteScalar();

                if (reasult != null && int.TryParse(reasult.ToString(), out int NeewDetaindID))
                    {
                        ID = NeewDetaindID;
                    }


            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }


            return ID;
        }

        public static bool UpdateReleaseDetaindLicense(int xLicenseID, bool isReleased ,
                        DateTime xReleaseDate, int ReleasedBy , int ReleaseAppID)
        {

            int affectedRows = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[DetainedLicenses]
                          SET [IsReleased] = @isReleased,
                             [ReleaseDate] = @xReleaseDate,
                             [ReleasedByUserID] = @ReleasedBy,
                             [ReleaseApplicationID] = @ReleaseAppID
                             WHERE LicenseID = @xLicenseID and IsReleased = 0";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@isReleased", isReleased);
            cmd.Parameters.AddWithValue("@xReleaseDate", xReleaseDate);
            cmd.Parameters.AddWithValue("@ReleasedBy", ReleasedBy);
            cmd.Parameters.AddWithValue("@ReleaseAppID", ReleaseAppID);
            cmd.Parameters.AddWithValue("@xLicenseID", xLicenseID);

            try
            {
                conn.Open();
                affectedRows = cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }


            return affectedRows > 0;

        }

        public static bool GetDetaindLicense(int LicenseID , ref int DetainedID , ref DateTime DetainedDate , ref decimal Fees , ref int CreatedBy ,
                    ref bool IsReleased , ref DateTime ReleaseDate , ref int ReleaseID , ref int ReleaseAppID) 
        {
            bool isfound = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from DetainedLicenses where LicenseID = @LicenseID and IsReleased = 0";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                conn.Open() ;
                SqlDataReader reader  = command.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;

                    DetainedID = (int)reader["DetainID"];
                    DetainedDate = (DateTime)reader["DetainedDate"];
                    Fees = (decimal)reader["FineFees"];
                    CreatedBy = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                    ReleaseID = (int)reader["ReleasedByUserID"];
                    ReleaseAppID = (int)reader["ReleaseApplicationID"];

                }

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            return isfound;
        }


        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from DetianedLicensesView";

            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
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
            finally { connection.Close(); }

            return dt;

        }
        
    }
}
