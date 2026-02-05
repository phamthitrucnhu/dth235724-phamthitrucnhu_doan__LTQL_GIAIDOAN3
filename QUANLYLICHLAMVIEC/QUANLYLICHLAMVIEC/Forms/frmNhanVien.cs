using Microsoft.EntityFrameworkCore;
using QUANLYLICHLAMVIEC.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static QUANLYLICHLAMVIEC.Data.QUANLYLICHLAMVIECConnection;
using BCrypt.Net;



namespace QUANLYLICHLAMVIEC.Forms
{
    public partial class frmNhanVien : Form
    {
        QLLichDbContext context = new QLLichDbContext();// Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id; // Lấy mã khách hàng (dùng cho Sửa và Xóa)

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;
            txtChucVu.Enabled = giaTri;
            txtTimKiem.Enabled = !giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }


        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            List<NhanVien> nv = context.NhanVien.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", bindingSource, "MatKhau", false, DataSourceUpdateMode.Never);

            txtChucVu.DataBindings.Clear();
            txtChucVu.DataBindings.Add("Text", bindingSource, "ChucVu", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("Text", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
           

        }
        private void LoadNhanVien()
        {
            dataGridView.DataSource = context.NhanVien.ToList();
        }

        private void frmNhanVien_Load_1(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtChucVu.Clear();

            cboQuyenHan.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập?");
                return;
            }

            if (string.IsNullOrWhiteSpace(cboQuyenHan.Text))
            {
                MessageBox.Show("Vui lòng chọn quyền hạn?");
                return;
            }

            if (xuLyThem && string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu?");
                return;
            }

            if (xuLyThem)
            {
                NhanVien nv = new NhanVien();
                nv.HoVaTen = txtHoVaTen.Text;
                nv.DienThoai = txtDienThoai.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.TenDangNhap = txtTenDangNhap.Text;
                nv.ChucVu = txtChucVu.Text;
                nv.QuyenHan = cboQuyenHan.Text == "Admin";
                nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);

                context.NhanVien.Add(nv);
            }
            else
            {
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    nv.HoVaTen = txtHoVaTen.Text;
                    nv.DienThoai = txtDienThoai.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text;
                    nv.ChucVu = txtChucVu.Text;
                    nv.QuyenHan = cboQuyenHan.Text == "Admin";

                    if (!string.IsNullOrWhiteSpace(txtMatKhau.Text))
                    {
                        nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                    }

                    context.NhanVien.Update(nv);
                }
            }

            context.SaveChanges();
            frmNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa nhân viên?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                var nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                    context.SaveChanges();
                }
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Text|*.txt";

            if (o.ShowDialog() == DialogResult.OK)
            {
                var lines = File.ReadAllLines(o.FileName);

                foreach (var line in lines)
                {
                    var data = line.Split('|');

                    NhanVien nv = new NhanVien();
                    nv.HoVaTen = data[0];
                    nv.DienThoai = data[1];
                    nv.DiaChi = data[2];
                    nv.TenDangNhap = data[3];
                    nv.MatKhau = "123";
                    nv.QuyenHan = false;

                    context.NhanVien.Add(nv);
                }

                context.SaveChanges();
                frmNhanVien_Load(sender, e);
            }


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string tk = txtTimKiem.Text.ToLower();

            var kq = context.NhanVien
                .Where(x => x.HoVaTen.ToLower().Contains(tk)
                         || x.DienThoai.Contains(tk)
                         || x.TenDangNhap.ToLower().Contains(tk))
                .ToList();

            dataGridView.DataSource = kq;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Text|*.txt";

            if (s.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(s.FileName))
                {
                    foreach (var nv in context.NhanVien.ToList())
                    {
                        sw.WriteLine($"{nv.HoVaTen}|{nv.DienThoai}|{nv.DiaChi}|{nv.TenDangNhap}");
                    }
                }

                MessageBox.Show("Xuất xong!");
            }
        }
    }
    


}
