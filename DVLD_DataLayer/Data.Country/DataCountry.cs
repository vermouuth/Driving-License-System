using System;
using System.Data;
using System.Data.SqlClient;


namespace LicensesDataAccessLayer
{
    public class clsCountryData
    {

        public static bool GetCountryByID(int ID, ref string CountryName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Countries where CountryID = @ID";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    CountryName = (string)reader["CountryName"];
                }
                else
                {
                    isFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;

            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetCountryByName(string CountryName, ref int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Countries where CountryName = @CountryName";


            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["CountryID"];
                }
                else
                {
                    isFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;

            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static DataTable GetCountryDataTable()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Countries order by CountryName";      

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                
            }
            finally 
            {
                connection.Close();
            }

            return dt;

        }

    }

}
