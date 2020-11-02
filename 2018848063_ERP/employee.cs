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
    public partial class Employee : Form
    {
        string dbcon = "Server=localhost; uid=sa; pwd=FPN_finger1; database=ERP_PF;";
        string Ssql = "SELECT EmpNo, Name,Depart,Grade,WForm,PhoneNum,Join_Date FROM Employee";

        public Employee()
        {
            InitializeComponent();

            DB_Select();
        }

        #region 조회버튼
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            DB_Select();
        }

        public void DB_Select()
        {
            SqlConnection conn = new SqlConnection(dbcon);

            SqlDataAdapter da = new SqlDataAdapter(Ssql, conn);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        #endregion

        #region 등록버튼
        private void Btn_Regi_Click(object sender, EventArgs e)
        {
            POP_EmpAdd POP_Add = new POP_EmpAdd();
            POP_Add.Show();
        }
        #endregion

        #region 삭제버튼
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool isChecked = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);
                string empNo = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);

                if (isChecked)
                {
                    try
                    {
                        SqlConnection cn = new SqlConnection(dbcon);
                        SqlCommand cm = new SqlCommand("DELETE FROM employee WHERE EmpNo = @No", cn);
                        //AI 값을 가진 EmpNo를 기준으로 삭제

                        cm.Parameters.AddWithValue("@No", empNo);

                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();

                        DB_Select();

                        //여러개를 한번에 삭제 할 수 있는 기능 추가하기
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        #endregion
    }
}