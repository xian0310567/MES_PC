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
        string DV;
        string dbcon = "Server=localhost; uid=sa; pwd=FPN_finger1; database=ERP_PF;";

        POP_EmpAdd p1;

        public PTP_Sample()
        {
            InitializeComponent();
        }

        public PTP_Sample(POP_EmpAdd POP, string ment)
        {
            InitializeComponent();

            p1 = POP;

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

        #region 더블클릭시 실행
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DV = this.dataGridView1.Rows[this.dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();

            TcTT_Check();

            employee emp = new employee();
            emp.DB_Select();

            this.Close();
        }

        #region 부모폼 텍스트 박스 확인
        public void TcTT_Check()
        {
            if(TcTT == "Department")
            {
                p1.txt_Depart.Text = DV;
            }
            else if (TcTT == "Grade")
            {
                p1.txt_Grade.Text = DV;
            }
            else if (TcTT == "WForm")
            {
                p1.txt_WForm.Text = DV;
            }
        }
        #endregion

        #endregion
    }
}