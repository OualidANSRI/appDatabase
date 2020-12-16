
using System.Data.SqlClient;

namespace appDatabase
{
    class ClassConnectionSQL
    {
        public static bool db_connection()
        {
            try

            {

                SqlConnectionStringBuilder bu = new SqlConnectionStringBuilder();
                bu.DataSource = "localhost";
                bu.UserID = "sa";
                bu.Password = "123456";
                bu.InitialCatalog = "master";
                using (SqlConnection cn = new SqlConnection(bu.ConnectionString))
                {
                    cn.Open();
                    return true;
                }

            }
            catch (SqlException E)
            {
                return false;
            }
        }
    }

}
