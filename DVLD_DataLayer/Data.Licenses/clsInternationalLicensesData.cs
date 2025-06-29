using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensesDataAccessLayer
{
    public class clsInternationalLicensesData
    {

        public static int InsertInterNationalLicense(int App, int Driver, int LicenseID, DateTime IssueDate, DateTime ExpirationDate, bool isActive, int CreatedBy)
        {
            int ID = -1;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[InternationalLicenses]
                            ([ApplicationID],[DriverID],[IssuedUsingLocalLicenseID],[IssueDate],[ExpirationDate],[IsActive],[CreatedByUserID])
                            VALUES
                            (@AppID, @DriverID ,@LicenseID, @IssueDate,@ExpirationDate, @isActive, @CreatedBy)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@AppID", App);
            cmd.Parameters.AddWithValue("@DriverID", Driver);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@isActive", isActive);
            cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);

            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int NewID))
                {
                    ID = NewID;
                }

            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            return ID;

        }

        public static bool IsDriverHasActiveInterNationalLicense(int DriverID)
        {
            bool isfound = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select foudn = 1 from InternationalLicenses where DriverID = @DriverID and IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                isfound = reader.HasRows;
            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            return isfound;
        }

        public static bool GetInternationalInfo(int LicenseID, ref string FullName , ref int InternationalID , ref string NationalNo,
            ref string Gendor ,ref DateTime IssueDate , ref int ApplicationID , ref string isActive ,
            ref DateTime DateOfBirth , ref int DriverID, ref DateTime ExpirationDate , ref string ImagePath)
        {
            bool isfound = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from InterantionalCardInfo_View where LicenseID = @LicenseID";

            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                conn.Open() ;
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    isfound = true;

                    FullName = (string)reader["FullName"];
                    InternationalID = (int)reader["InternationalLicenseID"];
                    NationalNo = (string)reader["NationalNo"];
                    Gendor = (string)reader["Gendor"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ApplicationID = (int)reader["ApplicationID"];
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
            finally { conn.Close(); }

            return isfound;
        }

        public static bool IsInternationalLicenseExist(int LicenseID)
        {
            bool found = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select found = 1 from InternationalLicenses where InternationalLicenses.IssuedUsingLocalLicenseID = @LicenseID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                found = reader.HasRows;
                reader.Close() ;
            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            return found;
        }


        public static DataTable GetAllInternationalLicenses()
        {
            DataTable table = new DataTable();

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT InternationalLicenses.InternationalLicenseID, InternationalLicenses.ApplicationID, InternationalLicenses.DriverID, InternationalLicenses.IssuedUsingLocalLicenseID, InternationalLicenses.IssueDate, 
                             InternationalLicenses.ExpirationDate, InternationalLicenses.IsActive
                             FROM 
                             InternationalLicenses INNER JOIN
                             Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID";

            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows) 
                {
                    table.Load(reader);

                }
                reader.Close();
            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }

            return table;
        }

    }
}
