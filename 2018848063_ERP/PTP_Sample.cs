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
using System.Runtime.CompilerServices;

namespace _2018848063_ERP
{
    public partial class PTP_Sample : Form
    {
        string TcTT;
        string dbcon = "Server=localhost; uid=sa; pwd=FPN_finger1; database=ERP_PF;";

        public PTP_Sample(string ment)
        {
            InitializeComponent();

            this.TcTT = ment;

            DBSelect();
        }

        #region 조회 기능
        private void  DBSelect()
        {
            string Ssql = "SELECT * FROM " + TcTT;

            SqlConnection conn = new SqlConnection(dbcon);

            SqlDataAdapter da = new SqlDataAdapter(Ssql, conn);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        #endregion

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            POP_EmpAdd POP = new POP_EmpAdd();

            POP.txt_Depart.Text = "aa";
            
            this.Close();
        }
    }
}
