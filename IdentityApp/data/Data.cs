using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityApp.data
{
    public static class Data
    {
        // Connection information
        public static string connInfo = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                   "localhost", 5433, "postgres", "su", "identity");
        public static NpgsqlConnection conn = null;
        public static string stt = "";
        public static string connectDb()
        {
            try
            {
                conn = new NpgsqlConnection(connInfo);
                conn.Open();
                stt = "connect success";
            }
            catch(Exception ex)
            {
                stt = ex.Message;
            }
            finally
            {
                // Close connection
                if (null != conn)
                {
                    conn.Close();
                }
            }
            return stt;
        }

    }
}
