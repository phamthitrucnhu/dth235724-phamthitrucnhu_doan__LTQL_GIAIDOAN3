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

namespace QUANLYLICHLAMVIEC.Forms
{
    public partial class frmCaLam : Form
    {
        QLLichDbContext context = new QLLichDbContext();// Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id; // Lấy mã khách hàng (dùng cho Sửa và Xóa)
        public frmCaLam()
        {
            InitializeComponent();
        }
        void BatTatChucNang(bool gt)
        {
            btnLuu.Enabled = gt;
            btnHuyBo.Enabled = gt;

            txtTenCa.Enabled = gt;
            dtpGioBatDau.Enabled = gt;
            dtpGioKetThuc.Enabled = gt;

            btnThem.Enabled = !gt;
            btnSua.Enabled = !gt;
            btnXoa.Enabled = !gt;
            btnThoat.Enabled = !gt;
        }
        private void LoadNhanVien()
        {
            dataGridView.DataSource = context.NhanVien.ToList();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmCaLam_Load(object sender, EventArgs e)
        {

            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            var list = context.CaLam.ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = list;

            txtTenCa.DataBindings.Clear();
            txtTenCa.DataBindings.Add("Text", bs, "TenCa", false, DataSourceUpdateMode.Never);

            dtpGioBatDau.DataBindings.Clear();
            

            dtpGioKetThuc.DataBindings.Clear();
           

            dataGridView.DataSource = bs;

            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                txtTenCa.Text = dataGridView.CurrentRow.Cells["TenCa"].Value.ToString();

                TimeSpan bd = (TimeSpan)dataGridView.CurrentRow.Cells["GioBatDau"].Value;
                TimeSpan kt = (TimeSpan)dataGridView.CurrentRow.Cells["GioKetThuc"].Value;

                dtpGioBatDau.Value = DateTime.Today.Add(bd);
                dtpGioKetThuc.Value = DateTime.Today.Add(kt);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtTenCa.Clear();
            dtpGioBatDau.Value = DateTime.Now;
            dtpGioKetThuc.Value = DateTime.Now;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Chọn ca làm!");
                return;
            }

            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTenCa.Text))
            {
                MessageBox.Show("Nhập tên ca!");
                return;
            }

            if (dtpGioKetThuc.Value <= dtpGioBatDau.Value)
            {
                MessageBox.Show("Giờ kết thúc phải lớn hơn giờ bắt đầu!");
                return;
            }

            if (xuLyThem)
            {
                CaLam ca = new CaLam();
                ca.TenCa = txtTenCa.Text;
                ca.GioBatDau = dtpGioBatDau.Value.TimeOfDay;
                ca.GioKetThuc = dtpGioKetThuc.Value.TimeOfDay;
                context.CaLam.Add(ca);
            }
            else
            {
                CaLam ca = context.CaLam.Find(id);
                if (ca != null)
                {
                    ca.TenCa = txtTenCa.Text;
                    ca.GioBatDau = dtpGioBatDau.Value.TimeOfDay;
                    ca.GioKetThuc = dtpGioKetThuc.Value.TimeOfDay;

                    context.CaLam.Update(ca);
                }
            }

            context.SaveChanges();
            frmCaLam_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmCaLam_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa ca làm?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

                var ca = context.CaLam.Find(id);
                if (ca != null)
                {
                    context.CaLam.Remove(ca);
                    context.SaveChanges();
                }

                frmCaLam_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
