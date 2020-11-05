using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018848063_ERP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void 사원정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee EMP = new Employee();
            EMP.MdiParent = this;
            EMP.Show();
        }

        private void 입고ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Warehousing WH = new Warehousing();
            WH.MdiParent = this;
            WH.Show();

        }
    }
}
