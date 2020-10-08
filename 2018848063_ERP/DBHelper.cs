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
                MessageBox.Show(ex.ToString());
            }
        }

        public DataSet DBSelect(string Ssql)
        {
                SqlConnection conn = new SqlConnection(dbcon);
 
                SqlDataAdapter adapter = new SqlDataAdapter(Ssql, conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                return ds;

            //SqlCommand 파라미터의 값을 넘겨 줄 수 있는 방법이 있지 않을까
            //adapter 사용법 더 알아보기
        }
    }
}