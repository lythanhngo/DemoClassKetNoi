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
    public partial class frmDulieuvaoCB : Form
    {
        public frmDulieuvaoCB()
        {
            InitializeComponent();
        }
        private void frmDulieuvaoCB_Load(object sender, EventArgs e)
        {
            clsKetnoi.dodulieu_combobox(cbKhuvuc, "SELECT * FROM KHUVUC", "TenKV", "MaKV");
        }

        private void cbKhuvuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chuoi = "SELECT MaTS, Ho, Ten, TenKV FROM THISINH ts, KHUVUC kv WHERE ts.MaKV=kv.MaKV AND ts.MaKV = '" + cbKhuvuc.SelectedValue.ToString() + "'";
            clsKetnoi.dodulieu_datagirbview(dgKhuvuc, chuoi);
        }

        private void frmDulieuvaoCB_FormClosing(object sender, FormClosingEventArgs e)
        {
            new frmDemo().Show();
        }
    }
}
