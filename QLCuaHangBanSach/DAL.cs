using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLCuaHangBanSach
{
    class DAL
    {
        public SqlConnection getConnect()
        {
            try
            {
                String path = @"Data Source=DESKTOP-B0D1PJ3\SQLEXPRESS;Initial Catalog=QLCuaHangSach;Integrated Security=True";
                SqlConnection conn = new SqlConnection(path);
                return conn;
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối , hàm get Connect");
                return null;
            }
        }

        public DataTable getTable(String sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = getConnect();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public void ExecuteNonQuerry(String sql)
        {
            try
            {

                SqlConnection conn = getConnect();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (SqlException ex)
            {

                if (ex.Message.Contains("Primary Key"))
                {
                    MessageBox.Show("Mã sách không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
