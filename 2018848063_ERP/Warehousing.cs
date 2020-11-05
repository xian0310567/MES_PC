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
            string Ssql = "Select Company,Factory,ChitNo,Customer,Surtax,CIDate,WHouse,PIC,Price,U_Date From Item_Master";

            SqlConnection conn = new SqlConnection(dbcon);
            SqlCommand cmd = new SqlCommand(Ssql, conn);
            //검색 텍스트박스가 비어 있으면 = 모든값, 조건이 있으면 = 조건에 맞는 값 출력 할 수 있게 변경하기

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            Spread_Item.DataSource = ds.Tables[0];

            column_Name_Master();
            
        }

        #region 컬럼명 변경
        public void column_Name_Master()
        {
            Spread_Item.Columns[0].HeaderText = "회사";
            Spread_Item.Columns[1].HeaderText = "공장";
            Spread_Item.Columns[2].HeaderText = "전표번호";
            Spread_Item.Columns[3].HeaderText = "거래처";
            Spread_Item.Columns[4].HeaderText = "거래유형";
            Spread_Item.Columns[5].HeaderText = "입고일자";
            Spread_Item.Columns[6].HeaderText = "창고";
            Spread_Item.Columns[7].HeaderText = "담당자";
            Spread_Item.Columns[8].HeaderText = "총금액";
            Spread_Item.Columns[9].HeaderText = "수정일";
        }

        public void column_Name_Detail()
        {
            Spread_Detail.Columns[0].HeaderText = "품목코드";
            Spread_Detail.Columns[1].HeaderText = "전표번호";
            Spread_Detail.Columns[2].HeaderText = "품목명";
            Spread_Detail.Columns[3].HeaderText = "창고";
            Spread_Detail.Columns[4].HeaderText = "Lot";
            Spread_Detail.Columns[5].HeaderText = "규격";
            Spread_Detail.Columns[6].HeaderText = "단위";
            Spread_Detail.Columns[7].HeaderText = "입고수량";
            Spread_Detail.Columns[8].HeaderText = "단가";
            Spread_Detail.Columns[9].HeaderText = "공급가액";
            Spread_Detail.Columns[10].HeaderText = "부가세";
            Spread_Detail.Columns[11].HeaderText = "총금액";
        }
        #endregion

        #region 행 클릭시 실행
        private void Spread_Item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Ssql = "Select * From Item_Detail";

            SqlConnection conn = new SqlConnection(dbcon);
            SqlCommand cmd = new SqlCommand(Ssql, conn);
            //검색 텍스트박스가 비어 있으면 = 모든값, 조건이 있으면 = 조건에 맞는 값 출력 할 수 있게 변경하기

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            Spread_Detail.DataSource = ds.Tables[0];
            column_Name_Detail();
            //받아온 데이터를 gridview에 뿌려줌
        }
        #endregion
    }
}
