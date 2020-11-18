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
        string CV, DV;
        string dbcon = "Server=localhost; uid=sa; pwd=FPN_finger1; database=ERP_PF;";
        string SQL;

        POP_EmpAdd p1;
        Warehousing W1;

        public PTP_Sample()
        {
            InitializeComponent();
        }

        #region 여러가지 부모폼에서 인자값을 받아오기 위함
        public PTP_Sample(POP_EmpAdd POP, string ment)
        {
            InitializeComponent();

            p1 = POP;
            this.TcTT = ment;

            SQL = "SELECT * FROM " + TcTT;

            DBSelect();
        }
        //POP_EmpAdd

        public PTP_Sample(Warehousing WH, string ment)
        {
            InitializeComponent();

            W1 = WH;
            this.TcTT = ment;

            SQL = TcTT;

            DBSelect();
        }
        //Warehousing
        #endregion

        #region 조회 기능
        private void  DBSelect()
        {
            // 받아온 기본 값을 바탕으로 테이블을 불러옴

            SqlConnection conn = new SqlConnection(dbcon);

            SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        #endregion

        #region 더블클릭시 실행
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CV = this.dataGridView1.Rows[this.dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString();
            DV = this.dataGridView1.Rows[this.dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
            //코드 번호를 제외한 부서명, 직급명, 고용형태 받아옴

            TcTT_Check();
            //CV, DV값을 확인하여 상황에 맞는 이벤트 실행

            this.Close();
        }

        #region TcTT 값 확인
        public void TcTT_Check()
        {
            switch(TcTT) {
                case "Department":  //POP_EmpAdd_부서
                    p1.txt_Depart.Text = DV;
                    p1.txt_Depart_C.Text = CV;
                    break;
                case "Grade":   //POP_EmpAdd_직급
                    p1.txt_Grade.Text = DV;
                    p1.txt_Grade_C.Text = CV;
                    break;
                case "WForm":   //POP_EmpAdd_고용형태
                    p1.txt_WForm.Text = DV;
                    p1.txt_WForm_C.Text = CV;
                    break;
            }
        }
        #endregion

        #endregion
    }
}