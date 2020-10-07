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
using System.Security.Cryptography.X509Certificates;

namespace _2018848063_ERP
{
    public partial class employee : Form
    {
        DBHelper dbh = new DBHelper();
        

        public employee()
        {
            InitializeComponent();
            DBSelect();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            DBSelect();
        }

        private void Btn_Regi_Click(object sender, EventArgs e)
        {
            POP_EmpAdd POP_Add = new POP_EmpAdd("normal", "", "");
            POP_Add.Show();
        }

        public void DBSelect()
        {
            string sqlS = "SELECT Name,Depart,Grade,WForm,PhoneNum,Join_Date FROM Employee";
            //employee sample = new employee();

            DataSet dataSet = dbh.DBSelect(sqlS);

            // DataSet을 DataGridView 컨트롤에 바인딩
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}