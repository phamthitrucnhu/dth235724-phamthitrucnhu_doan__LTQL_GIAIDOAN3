using QUANLYLICHLAMVIEC.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QUANLYLICHLAMVIEC.Data.QUANLYLICHLAMVIECConnection;

namespace QUANLYLICHLAMVIEC.Forms
{
    public partial class frmLichLamViec : Form
    {
        QLLichDbContext context = new QLLichDbContext();// Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id; // Lấy mã khách hàng (dùng cho Sửa và Xóa)
        public frmLichLamViec()
        {
            InitializeComponent();
        }
        void BatTatChucNang(bool gt)
        {
            btnLuu.Enabled = gt;
            btnHuyBo.Enabled = gt;

            cboNhanVien.Enabled = gt;
            cboCaLam.Enabled = gt;
            dtpNgayLam.Enabled = gt;
            txtGhiChu.Enabled = gt;
            cboTrangThai.Enabled = gt;

            btnThem.Enabled = !gt;
            btnSua.Enabled = !gt;
            btnXoa.Enabled = !gt;
            btnThoat.Enabled = !gt;
        }
        private void LoadNhanVien()
        {
            dataGridView.DataSource = context.NhanVien.ToList();
        }

        private void frmLichLamViec_Load(object sender, EventArgs e)
        {

            BatTatChucNang(false);

            // Nhân viên
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.ValueMember = "ID";

            // Ca làm
            cboCaLam.DataSource = context.CaLam.ToList();
            cboCaLam.DisplayMember = "TenCa";
            cboCaLam.ValueMember = "ID";

            // Trạng thái
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Đi làm");
            cboTrangThai.Items.Add("Nghỉ");
            cboTrangThai.Items.Add("Đổi ca");

            // DataGridView
            var list = context.LichLamViec
                .Select(l => new
                {
                    l.ID,
                    TenNhanVien = l.NhanVien.HoVaTen,
                    TenCa = l.CaLam.TenCa,
                    l.NgayLam,
                    l.TrangThai,
                    l.GhiChu
                }).ToList();

            dataGridView.DataSource = list;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            dtpNgayLam.Value = DateTime.Now;
            txtGhiChu.Clear();
            cboTrangThai.SelectedIndex = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show("Xóa lịch?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

                var lich = context.LichLamViec.Find(id);
                if (lich != null)
                {
                    context.LichLamViec.Remove(lich);
                    context.SaveChanges();
                }

                frmLichLamViec_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null || cboCaLam.SelectedValue == null)
            {
                MessageBox.Show("Chọn nhân viên và ca!");
                return;
            }

            if (string.IsNullOrWhiteSpace(cboTrangThai.Text))
            {
                MessageBox.Show("Chọn trạng thái!");
                return;
            }

            // ❗ chống trùng lịch
            bool check = context.LichLamViec.Any(l =>
                l.NhanVienID == (int)cboNhanVien.SelectedValue &&
                l.CaLamID == (int)cboCaLam.SelectedValue &&
                l.NgayLam.Date == dtpNgayLam.Value.Date &&
                l.ID != id);

            if (check)
            {
                MessageBox.Show("Trùng lịch!");
                return;
            }

            if (xuLyThem)
            {
                LichLamViec lich = new LichLamViec();
                lich.NhanVienID = (int)cboNhanVien.SelectedValue;
                lich.CaLamID = (int)cboCaLam.SelectedValue;
                lich.NgayLam = dtpNgayLam.Value;
                lich.GhiChu = txtGhiChu.Text;
                lich.TrangThai = cboTrangThai.Text;

                context.LichLamViec.Add(lich);
            }
            else
            {
                var lich = context.LichLamViec.Find(id);
                if (lich != null)
                {
                    lich.NhanVienID = (int)cboNhanVien.SelectedValue;
                    lich.CaLamID = (int)cboCaLam.SelectedValue;
                    lich.NgayLam = dtpNgayLam.Value;
                    lich.GhiChu = txtGhiChu.Text;
                    lich.TrangThai = cboTrangThai.Text;

                    context.LichLamViec.Update(lich);
                }
            }

            context.SaveChanges();
            frmLichLamViec_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLichLamViec_Load(sender, e);
        }
    }
    

}
