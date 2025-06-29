using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensesDataAccessLayer
{
    public class clsApplicationTypesData
    {

        public static bool GetApplicationTypeInfoByID(int appID, ref string AppTitle, ref decimal AppFees)
        {
            bool isfound = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from ApplicationTypes where ApplicationTypeID = @AppID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@AppID", appID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    AppTitle = (string)reader["ApplicationTypeTitle"];
                    AppFees = (decimal)reader["ApplicationFees"];
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

        public static DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from ApplicationTypes";

            SqlCommand cmd = new SqlCommand(query,conn);

            try
            {
                conn.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
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

        public static bool UpdateApplicationsFees(int ApplicationID , string AppTilte  ,decimal AppFees)
        {
            int rowaffected = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "update ApplicationTypes set [ApplicationFees] = @AppFees ,[ApplicationTypeTitle] =@AppTitle  where ApplicationTypeID = @ApplicationID ";

            SqlCommand command = new SqlCommand(query,conn);
            command.Parameters.AddWithValue("@AppFees", AppFees);
            command.Parameters.AddWithValue("@AppTitle", AppTilte);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
