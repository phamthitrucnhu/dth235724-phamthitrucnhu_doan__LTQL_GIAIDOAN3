namespace QUANLYLICHLAMVIEC.Forms
{
    partial class frmCaLam
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
            dataGridView = new DataGridView();
            GioBatDau = new DataGridViewTextBoxColumn();
            GioKetThuc = new DataGridViewTextBoxColumn();
            TenCa = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            btnThem = new Button();
            txtTenCa = new TextBox();
            label4 = new Label();
            label7 = new Label();
            dtpGioBatDau = new DateTimePicker();
            dtpGioKetThuc = new DateTimePicker();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnHuyBo = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { TenCa, GioKetThuc, GioBatDau });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(973, 227);
            dataGridView.TabIndex = 6;
            // 
            // GioBatDau
            // 
            GioBatDau.DataPropertyName = "GioBatDau";
            GioBatDau.HeaderText = "Giờ bắt đầu";
            GioBatDau.MinimumWidth = 6;
            GioBatDau.Name = "GioBatDau";
            // 
            // GioKetThuc
            // 
            GioKetThuc.DataPropertyName = "GioKetThuc";
            GioKetThuc.HeaderText = "Giờ kết thúc";
            GioKetThuc.MinimumWidth = 6;
            GioKetThuc.Name = "GioKetThuc";
            // 
            // TenCa
            // 
            TenCa.DataPropertyName = "TenCa";
            TenCa.HeaderText = "Tên ca";
            TenCa.MinimumWidth = 6;
            TenCa.Name = "TenCa";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(26, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(979, 253);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách ca làm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 88);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 33;
            label3.Text = "Chọn giờ bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 53);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 32;
            label2.Text = "Nhập tên ca";
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
            // txtTenCa
            // 
            txtTenCa.Location = new Point(220, 40);
            txtTenCa.Name = "txtTenCa";
            txtTenCa.Size = new Size(329, 27);
            txtTenCa.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 88);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 144);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 42;
            label7.Text = "Chọn giờ kết thúc";
            label7.Click += label7_Click;
            // 
            // dtpGioBatDau
            // 
            dtpGioBatDau.Format = DateTimePickerFormat.Time;
            dtpGioBatDau.Location = new Point(225, 111);
            dtpGioBatDau.Name = "dtpGioBatDau";
            dtpGioBatDau.ShowUpDown = true;
            dtpGioBatDau.Size = new Size(329, 27);
            dtpGioBatDau.TabIndex = 43;
            // 
            // dtpGioKetThuc
            // 
            dtpGioKetThuc.Format = DateTimePickerFormat.Time;
            dtpGioKetThuc.Location = new Point(220, 144);
            dtpGioKetThuc.Name = "dtpGioKetThuc";
            dtpGioKetThuc.ShowUpDown = true;
            dtpGioKetThuc.Size = new Size(334, 27);
            dtpGioKetThuc.TabIndex = 44;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(dtpGioKetThuc);
            groupBox1.Controls.Add(dtpGioBatDau);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenCa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(941, 236);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ca làm";
            // 
            // frmCaLam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 513);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmCaLam";
            Text = "Ca Làm";
            Load += frmCaLam_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtChucVu;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn TenCa;
        private DataGridViewTextBoxColumn GioKetThuc;
        private DataGridViewTextBoxColumn GioBatDau;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Button btnThem;
        private TextBox txtTenCa;
        private Label label4;
        private Label label7;
        private DateTimePicker dtpGioBatDau;
        private DateTimePicker dtpGioKetThuc;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnSua;
        private Button btnHuyBo;
        private GroupBox groupBox1;
    }
}