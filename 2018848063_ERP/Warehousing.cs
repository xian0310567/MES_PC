using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _2018848063_ERP
{
    public partial class Warehousing : Form
    {
        //https://blog.8pmbiz.com/26

        string dbcon = "Server=localhost; uid=sa; pwd=FPN_finger1; database=ERP_PF;";
        string Ssql = "Select * From employee";

        public Warehousing()
        {
            InitializeComponent();
            DB_Select();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DB_Select();
        }


        public void DB_Select()
        {
            SqlConnection conn = new SqlConnection(dbcon);
            SqlCommand cmd = new SqlCommand(Ssql, conn);
            //검색 텍스트박스가 비어 있으면 = 모든값, 조건이 있으면 = 조건에 맞는 값 출력 할 수 있게 변경하기


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            Spread_Item.DataSource = ds.Tables[0];
            //받아온 데이터를 gridview에 뿌려줌
        }
    }
}
