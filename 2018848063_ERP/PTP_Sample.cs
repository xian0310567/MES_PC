using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018848063_ERP
{
    public partial class PTP_Sample : Form
    {
        string TcTT;
        DBHelper dbh = new DBHelper();

        public PTP_Sample(string ment)
        {
            InitializeComponent();
            this.TcTT = ment;
            DBSelect();
        }

        private void  DBSelect()
        {
            string Ssql = "SELECT * FROM " + TcTT;

            DataSet dataSet = dbh.DBSelect(Ssql);

            // DataSet을 DataGridView 컨트롤에 바인딩
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string CV, DV1, DV2;
            CV = TcTT;
            DV1 = this.dataGridView1.Rows[this.dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString();
            DV2 = this.dataGridView1.Rows[this.dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
            POP_EmpAdd POP = new POP_EmpAdd(CV, DV1, DV2);
            POP.Owner = this;
            this.Close();
        }
    }
}
