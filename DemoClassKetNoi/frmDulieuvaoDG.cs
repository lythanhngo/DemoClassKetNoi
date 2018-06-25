using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoClassKetNoi
{
    public partial class frmDulieuvaoDG : Form
    {
        public frmDulieuvaoDG()
        {
            InitializeComponent();
        }

        private void frmDulieuvaoDG_Load(object sender, EventArgs e)
        {
            if(!clsKetnoi.dodulieu_datagirbview(dgQuequan, "SELECT * FROM QUEQUAN"))
            {
                MessageBox.Show("Không có dữ liệu hiển thị");
            }
        }

        private void frmDulieuvaoDG_FormClosing(object sender, FormClosingEventArgs e)
        {
            new frmDemo().Show();
        }
    }
}
