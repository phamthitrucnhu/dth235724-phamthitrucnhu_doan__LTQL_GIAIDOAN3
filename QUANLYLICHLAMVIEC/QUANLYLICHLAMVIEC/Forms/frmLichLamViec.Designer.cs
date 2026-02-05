namespace QUANLYLICHLAMVIEC.Forms
{
    partial class frmLichLamViec
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
            btnSua = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            dataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            cboTrangThai = new ComboBox();
            label5 = new Label();
            cboCaLam = new ComboBox();
            label1 = new Label();
            cboNhanVien = new ComboBox();
            btnLuu = new Button();
            dtpNgayLam = new DateTimePicker();
            label7 = new Label();
            label4 = new Label();
            txtGhiChu = new TextBox();
            btnThem = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            HoVaTen = new DataGridViewTextBoxColumn();
            CaLam = new DataGridViewTextBoxColumn();
            NgayLam = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSua
            // 
            btnSua.Location = new Point(649, 89);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 40;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(821, 38);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 41;
            btnHuyBo.Text = "Hủy bỏ ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(821, 89);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 38;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(649, 145);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 39;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { HoVaTen, CaLam, NgayLam, GhiChu });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(973, 227);
            dataGridView.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboCaLam);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(dtpNgayLam);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(10, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(941, 236);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn ngày";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(518, 195);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 28);
            cboTrangThai.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 203);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 47;
            label5.Text = "Trạng thái";
            // 
            // cboCaLam
            // 
            cboCaLam.FormattingEnabled = true;
            cboCaLam.Location = new Point(164, 90);
            cboCaLam.Name = "cboCaLam";
            cboCaLam.Size = new Size(151, 28);
            cboCaLam.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 98);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 45;
            label1.Text = "Chọn ca";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(164, 47);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(151, 28);
            cboNhanVien.TabIndex = 44;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(821, 144);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 37;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // dtpNgayLam
            // 
            dtpNgayLam.Location = new Point(164, 146);
            dtpNgayLam.Name = "dtpNgayLam";
            dtpNgayLam.ShowUpDown = true;
            dtpNgayLam.Size = new Size(329, 27);
            dtpNgayLam.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 203);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 42;
            label7.Text = "Ghi chú";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 88);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 34;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(112, 196);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(213, 27);
            txtGhiChu.TabIndex = 26;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(649, 44);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 36;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 47);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 32;
            label2.Text = "Chọn nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 151);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 33;
            label3.Text = "Chọn ngày";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(10, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(979, 253);
            groupBox2.TabIndex = 48;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị lịch làm việc";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "NhanVien.HoVaTen";
            HoVaTen.HeaderText = "Nhân viên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // CaLam
            // 
            CaLam.DataPropertyName = "CaLam.TenCa";
            CaLam.HeaderText = "Ca làm";
            CaLam.MinimumWidth = 6;
            CaLam.Name = "CaLam";
            // 
            // NgayLam
            // 
            NgayLam.DataPropertyName = "NgayLam";
            NgayLam.HeaderText = "Ngày làm";
            NgayLam.MinimumWidth = 6;
            NgayLam.Name = "NgayLam";
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            // 
            // frmLichLamViec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 517);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmLichLamViec";
            Text = "frmLichLamViec";
            Load += frmLichLamViec_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSua;
        private Button btnHuyBo;
        private Button btnThoat;
        private Button btnXoa;
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private Button btnLuu;
        private DateTimePicker dtpNgayLam;
        private Label label7;
        private Label label4;
        private TextBox txtGhiChu;
        private Button btnThem;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox cboNhanVien;
        private ComboBox cboCaLam;
        private ComboBox cboTrangThai;
        private Label label5;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn CaLam;
        private DataGridViewTextBoxColumn NgayLam;
        private DataGridViewTextBoxColumn GhiChu;
    }
}