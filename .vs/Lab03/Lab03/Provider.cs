using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Provider
    {
       private string connectionString = "Data Source=607-20\\SQLEXPRESS;Initial Catalog=QLThucTap;Integrated Security=True";
        public DataTable ExcureQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            { 
            connection.Open();
            SqlCommand cmd = new SqlCommand(connectionString, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query,connection);
                sqlDataAdapter.Fill(data);
            connection.Close();
            }
            return data;
        }
        public DataTable ExcureQueryHavePara(string para)
        {
            string query1 = "exec GetThongTinSinhVienTheoQueQuan @QueQuan";
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query1, connection))
                {
                    cmd.Parameters.AddWithValue("@QueQuan", para); 
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(data);
                }
            }
            return data;
        }
    }
   
}
