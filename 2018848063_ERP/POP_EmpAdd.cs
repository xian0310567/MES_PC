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
    public partial class POP_EmpAdd : Form
    {
        DBHelper dbh = new DBHelper();
        Employee emp = new Employee();

        public POP_EmpAdd()
        {
            InitializeComponent();
        }
        

        //부서 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            PTP_Sample PTP = new PTP_Sample(this, "Department");
            PTP.Owner = this;
            PTP.ShowDialog(this);
        }

        //직급 버튼
        private void button4_Click(object sender, EventArgs e)
        {
            PTP_Sample PTP = new PTP_Sample(this, "Grade");
            PTP.Owner = this;
            PTP.ShowDialog();
        }

        //고용형태 버튼
        private void button5_Click(object sender, EventArgs e)
        {
            PTP_Sample PTP = new PTP_Sample(this, "WForm");
            
            PTP.Owner = this;
            PTP.ShowDialog();
        }

        #region 등록 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string dbcon = "Server=localhost; uid=sa; pwd=FPN_finger1; database=ERP_PF;";
                string Ssql = "insert into employee (Name,Depart,Grade,WForm,PhoneNum,Join_Date,Date) values (@Name,@Depart,@Grade,@WForm,@Phone_Num,@Join_Date,@Date)";

                //DataSet ds = new DataSet();
                SqlConnection conn = new SqlConnection(dbcon);
                SqlCommand cmd = new SqlCommand(Ssql, conn);

                cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@Depart", txt_Depart.Text);
                cmd.Parameters.AddWithValue("@Grade", txt_Grade.Text);
                cmd.Parameters.AddWithValue("@WForm", txt_WForm.Text);
                cmd.Parameters.AddWithValue("@Phone_Num", txt_Phone_num.Text);
                cmd.Parameters.AddWithValue("@Join_Date", txt_Join_Date.Text);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd"));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                reset_Text();

                this.Close();
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }
        #endregion

        #region 초기화 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            reset_Text();
        }

        public void reset_Text()
        {
            txt_Name.Text = "";
            txt_Depart.Text = "Depart";
            txt_Grade.Text = "";
            txt_WForm.Text = "";
            txt_Phone_num.Text = "";
            txt_Join_Date.Text = "";
        }
        #endregion
    }
}