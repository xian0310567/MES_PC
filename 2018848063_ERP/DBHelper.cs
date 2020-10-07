using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018848063_ERP
{
    class DBHelper
    {
        string dbcon = "Server=localhost; uid=sa; pwd=FPN_finger1; database=ERP_PF;";

        //DB Connection Tester
        public void DBConnect()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dbcon);
                conn.Open();
                MessageBox.Show("접속성공");
            }
            catch(Exception ex)
            {
                MessageBox.Show("접속실패" + ex.ToString());
            }
        }

        //DB Select
        public DataSet DBSelect(string Ssql)
        {
            SqlConnection conn = new SqlConnection(dbcon);

            DataSet ds = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(Ssql, dbcon);

            adapter.Fill(ds);

            conn.Close();
            return ds;
        }
    }
}