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
            string sqlS = "SELECT EmpNo, Name,Depart,Grade,WForm,PhoneNum,Join_Date FROM Employee";
            //employee sample = new employee();

            DataSet dataSet = dbh.DBSelect(sqlS);

            // DataSet을 DataGridView 컨트롤에 바인딩
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        public void DB_Row()
        {
            //
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            string dbcon = "Server=localhost; uid=sa; pwd=FPN_finger1; database=ERP_PF;";
            SqlConnection cn = new SqlConnection(dbcon);

            SqlCommand cm = new SqlCommand("DELETE FROM employee WHERE EmpNo = @No", cn);
            cm.Parameters.Add("@No", SqlDbType.Int).Value = 1;
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();

            //삭제 기능 체크박스로 기능 설정 가능하게 하고 DB 헬퍼 변경하기
        }
    }
}