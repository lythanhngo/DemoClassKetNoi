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
    public partial class frmDieuchinh : Form
    {
        public frmDieuchinh()
        {
            InitializeComponent();
        }

        private void frmDieuchinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            new frmDemo().Show();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string chuoi = "INSERT INTO KHUVUC(MaKV,TenKV, UuTien) VALUES ('" + txtThemMa.Text + "',N'" + txtThemTen.Text + "', '"+txtThemUutien.Text+"')";
            if (clsKetnoi.dieuchinh(chuoi))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm không thành công");
            clsKetnoi.dodulieu_datagirbview(dgKhuvuc, "SELECT * FROM KHUVUC");
        }

        private void frmDieuchinh_Load(object sender, EventArgs e)
        {
            clsKetnoi.dodulieu_datagirbview(dgKhuvuc, "SELECT * FROM KHUVUC");
        }

        private void dgKhuvuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSuaMa.Text = dgKhuvuc[0,e.RowIndex].Value.ToString();
            txtSuaTen.Text = dgKhuvuc[1, e.RowIndex].Value.ToString();
            txtSuaUutien.Text = dgKhuvuc[2, e.RowIndex].Value.ToString();
            txtXoaMa.Text = dgKhuvuc[0, e.RowIndex].Value.ToString();
            txtXoaTen.Text = dgKhuvuc[1, e.RowIndex].Value.ToString();
            txtXoaUutien.Text = dgKhuvuc[2, e.RowIndex].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string chuoi = "Update KHUVUC Set TenKV=N'" + txtSuaTen.Text + "', UuTien='" + txtSuaUutien.Text + "' WHERE MaKV='"+txtSuaUutien.Text+"'";
            if (clsKetnoi.dieuchinh(chuoi))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa không thành công");
            clsKetnoi.dodulieu_datagirbview(dgKhuvuc, "SELECT * FROM KHUVUC");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string chuoi = "DELETE FROM KHUVUC WHERE MaKV = '" + txtXoaMa.Text + "'";
            if (clsKetnoi.dieuchinh(chuoi))
                MessageBox.Show("Xoá thành công");
            else
                MessageBox.Show("Xoá không thành công");
            clsKetnoi.dodulieu_datagirbview(dgKhuvuc, "SELECT * FROM KHUVUC");
        }
    }
}
