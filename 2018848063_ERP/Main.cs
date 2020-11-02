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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void 사원정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee newMDIChild = new Employee();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
