using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
// Cách dùng <Tên Class>.<Tên hàm>(<Các đối số tương ứng>);
// VD: clsKetnoi.laybang();
namespace DemoClassKetNoi
{
    class clsKetnoi
    {
        public SqlConnection conn;
        // Hàm kết nối
        public clsKetnoi()
        {
            conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLTS;Persist Security Info=True;User ID=sa;Password=system");
            conn.Open();
        }
        // Hàm đóng kết nối
        public void dongketnoi()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        // Hàm lấy bảng
        public static DataTable laybang(string chuoi)
        {
            clsKetnoi kn = new clsKetnoi();
            SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(chuoi, kn.conn));
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                kn.dongketnoi();
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }
        // Hàm thêm sửa xoá dư liệu -- Nếu hàm trả về true là thực hiện thành công, ngược lại không thành công
        public static bool dieuchinh(string chuoi)
        {
            clsKetnoi kn = new clsKetnoi();
            try
            {
                if ((new SqlCommand(chuoi, kn.conn)).ExecuteNonQuery() > 0)
                    return true;
                else return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                kn.dongketnoi();
            }
        }
        // hàm đổ dử liệu sql vào DataGridView
        public static bool dodulieu_datagirbview(DataGridView dg, string chuoi)
        {
            DataTable dt = new DataTable();
            dt = clsKetnoi.laybang(chuoi);
            try
            {
                if (dt.Rows.Count > 0)
                {
                    dg.DataSource = dt;
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        // Hàm đổ dữ liệu sql vào Combobox
        // hienthi : hiển thị bên ngoài
        // giá trị : giá trị bên trong
        public static void dodulieu_combobox(ComboBox cb, string chuoi, string hienthi, string giatri)
        {
            clsKetnoi kn = new clsKetnoi();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(chuoi, kn.conn));
                DataSet ds = new DataSet();
                da.Fill(ds);
                cb.DataSource = ds.Tables[0];
                cb.DisplayMember = hienthi;
                cb.ValueMember = giatri;   
            }
            catch { }
            finally
            {
                kn.dongketnoi();
            }
        }
    }
}