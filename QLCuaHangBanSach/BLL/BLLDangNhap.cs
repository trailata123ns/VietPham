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
    class BLLDangNhap
    {
        DAL dal = new DAL();

        public DataTable getAccount(String user)
        {
            String sql = "SELECT pass From Account Where userr ='" + user + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}
