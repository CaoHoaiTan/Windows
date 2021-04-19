using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DBLayer
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataAdapter adp;

        string strConnect =
            "Data Source=DESKTOP-C6NONEG;" +
            "Initial Catalog=QLCuaHangSuaXe;" +
            "Integrated Security=True";

        public DBLayer()
        {
            cnn = new SqlConnection(strConnect);
            cmd = cnn.CreateCommand();
        }
        // Select query
        public DataSet ExecuteQueryDataSet(
            string strSQL, CommandType ct, params SqlParameter[] p)
        {
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public string ExecuteQueryXML(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds.GetXml();
        }
        // action query
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error,
            params SqlParameter[] param)
        {
            bool f = false;
            cnn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return f;
        }
    }
}
