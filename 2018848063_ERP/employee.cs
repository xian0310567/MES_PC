using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _2018848063_ERP
{
    public partial class Employee : Form
    {
        string dbcon = "Server=localhost; uid=sa; pwd=FPN_finger1; database=ERP_PF;";
        string Ssql = "SELECT Emp.EmpNo, Emp.Name, Dep.DP_Name, GR.GR_Name, WF.WF_Name, emp.PhoneNum, emp.Join_Date From employee Emp Left Outer Join Department Dep On emp.Depart = Dep.DP_Code Left Outer Join Grade GR ON emp.Grade = GR.GR_Code Left Outer Join WForm WF ON emp.WForm = WF.WF_Code";

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
            SqlCommand cmd = new SqlCommand(Ssql, conn);
            cmd.Parameters.AddWithValue("@Name", Sch_Name.Text);
            //검색 텍스트박스가 비어 있으면 = 모든값, 조건이 있으면 = 조건에 맞는 값 출력 할 수 있게 변경하기


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            column_Name();
            //받아온 데이터를 gridview에 뿌려줌
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

                        //한번에 여러개가 삭제되지 않는 이유 찾기
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        #endregion

        #region 인쇄버튼
        private void Btn_Print_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region 컬럼명 변경
        public void column_Name()
        {
            dataGridView1.Columns[1].HeaderText = "직원번호";
            dataGridView1.Columns[2].HeaderText = "이름";
            dataGridView1.Columns[3].HeaderText = "부서";
            dataGridView1.Columns[4].HeaderText = "직책";
            dataGridView1.Columns[5].HeaderText = "고용형태";
            dataGridView1.Columns[6].HeaderText = "전화번호";
            dataGridView1.Columns[7].HeaderText = "입사일";
        }
        #endregion
    }
}