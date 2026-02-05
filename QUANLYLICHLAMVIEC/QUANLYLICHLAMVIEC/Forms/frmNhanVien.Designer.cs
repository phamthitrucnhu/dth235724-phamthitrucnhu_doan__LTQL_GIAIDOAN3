namespace QUANLYLICHLAMVIEC.Forms
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHoVaTen = new TextBox();
            txtDienThoai = new TextBox();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            txtDiaChi = new TextBox();
            cboQuyenHan = new ComboBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnThem = new Button();
            btnNhap = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnHuyBo = new Button();
            btnXuat = new Button();
            label7 = new Label();
            txtChucVu = new TextBox();
            groupBox1 = new GroupBox();
            txtTimKiem = new TextBox();
            groupBox2 = new GroupBox();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(146, 30);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(125, 27);
            txtHoVaTen.TabIndex = 0;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(146, 78);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(125, 27);
            txtDienThoai.TabIndex = 1;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(481, 21);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(125, 27);
            txtTenDangNhap.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(481, 74);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(125, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(146, 134);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(125, 27);
            txtDiaChi.TabIndex = 4;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý ", "Nhân viên" });
            cboQuyenHan.Location = new Point(443, 132);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(151, 28);
            cboQuyenHan.TabIndex = 5;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan, ChucVu });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(973, 227);
            dataGridView.TabIndex = 6;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và tên ";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại ";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập ";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quyền hạn ";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            // 
            // ChucVu
            // 
            ChucVu.DataPropertyName = "ChucVu";
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "Họ và tên ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 81);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 8;
            label2.Text = "Điện thoại ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 144);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 9;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 28);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 10;
            label4.Text = "Tên đăng nhập ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 81);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 11;
            label5.Text = "Mật khẩu ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 135);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 12;
            label6.Text = "Quyền hạn ";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(703, 21);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(691, 179);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 14;
            btnNhap.Text = "Nhập… ";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(833, 125);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(833, 72);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(323, 179);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(703, 125);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(833, 24);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 20;
            btnHuyBo.Text = "Hủy bỏ ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(821, 184);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 21;
            btnXuat.Text = "Xuất…";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 185);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 22;
            label7.Text = "Chức vụ";
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(146, 185);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(125, 27);
            txtChucVu.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Location = new Point(12, -3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(941, 236);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(469, 179);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(125, 27);
            txtTimKiem.TabIndex = 26;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(979, 253);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(703, 74);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 504);
            Controls.Add(txtChucVu);
            Controls.Add(label7);
            Controls.Add(btnHuyBo);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDiaChi);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtDienThoai);
            Controls.Add(txtHoVaTen);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            Load += frmNhanVien_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoVaTen;
        private TextBox txtDienThoai;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private TextBox txtDiaChi;
        private ComboBox cboQuyenHan;
        private DataGridView dataGridView;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnThem;
        private Button btnNhap;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnHuyBo;
        private Button btnXuat;
        private Label label7;
        private TextBox txtChucVu;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
        private DataGridViewTextBoxColumn ChucVu;
        private TextBox txtTimKiem;
        private Button btnSua;
    }
}