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

            SqlConnection conn = new SqlConnection(dbcon);
            SqlCommand cmd = new SqlCommand("SLT_ItemMaster @ChitNo", conn);
            cmd.Parameters.AddWithValue("@ChitNo", txt_ChitNo.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            Spread_Item.DataSource = ds.Tables[0];

            column_Name_Master();
            
        }

        #region 컬럼명 변경
        public void column_Name_Master()
        {
            Spread_Item.Columns[0].HeaderText = "전표번호";
            Spread_Item.Columns[1].HeaderText = "거래처";
            Spread_Item.Columns[2].HeaderText = "거래유형";
            Spread_Item.Columns[3].HeaderText = "입고일자";
            Spread_Item.Columns[4].HeaderText = "창고";
            Spread_Item.Columns[5].HeaderText = "담당자";
            Spread_Item.Columns[6].HeaderText = "총금액";
            Spread_Item.Columns[7].HeaderText = "수정일";
        }

        public void column_Name_Detail()
        {
            Spread_Detail.Columns[0].HeaderText = "전표번호";
            Spread_Detail.Columns[1].HeaderText = "품목명";
            Spread_Detail.Columns[2].HeaderText = "창고";
            Spread_Detail.Columns[3].HeaderText = "Lot";
            Spread_Detail.Columns[4].HeaderText = "규격";
            Spread_Detail.Columns[5].HeaderText = "단위";
            Spread_Detail.Columns[6].HeaderText = "입고수량";
            Spread_Detail.Columns[7].HeaderText = "단가";
            Spread_Detail.Columns[8].HeaderText = "공급가액";
            Spread_Detail.Columns[9].HeaderText = "부가세";
            Spread_Detail.Columns[10].HeaderText = "총금액";
        }
        #endregion

        #region 행 클릭시 실행
        private void Spread_Item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string CV = this.Spread_Item.Rows[this.Spread_Item.CurrentCellAddress.Y].Cells[0].Value.ToString();

            SqlConnection conn = new SqlConnection(dbcon);
            SqlCommand cmd = new SqlCommand("SLT_ItemDetail @ChitNo", conn);
            cmd.Parameters.AddWithValue("@ChitNo", CV);

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
