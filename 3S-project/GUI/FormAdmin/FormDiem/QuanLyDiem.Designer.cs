namespace _3S_project.GUI.FormAdmin.FormDiem
{
    partial class QuanLyDiem
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
            this.components = new System.ComponentModel.Container();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.txtTenSinhVien = new System.Windows.Forms.TextBox();
            this.gridQuanLyBanDiem = new System.Windows.Forms.DataGridView();
            this.maSinhVien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSinhVien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopHocPhan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemChuyenCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemKiemTra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemKiemTra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemKiemTra3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhap = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button20 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.bsQuanLyDiem = new System.Windows.Forms.BindingSource(this.components);
            this.cbxLopHocPhan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuanLyBanDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuanLyDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(335, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 49;
            this.label18.Text = "Lớp học phần:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(151, 102);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(150, 20);
            this.txtMaSinhVien.TabIndex = 48;
            this.txtMaSinhVien.TextChanged += new System.EventHandler(this.txtTenSinhVien_TextChanged);
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Location = new System.Drawing.Point(151, 67);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.Size = new System.Drawing.Size(150, 20);
            this.txtTenSinhVien.TabIndex = 45;
            this.txtTenSinhVien.TextChanged += new System.EventHandler(this.txtTenSinhVien_TextChanged);
            // 
            // gridQuanLyBanDiem
            // 
            this.gridQuanLyBanDiem.AllowUserToAddRows = false;
            this.gridQuanLyBanDiem.AllowUserToDeleteRows = false;
            this.gridQuanLyBanDiem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridQuanLyBanDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridQuanLyBanDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQuanLyBanDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVien1,
            this.tenSinhVien1,
            this.tenLop2,
            this.tenLopHocPhan1,
            this.diemChuyenCan,
            this.diemKiemTra1,
            this.diemKiemTra2,
            this.diemKiemTra3,
            this.diemThi,
            this.nhap});
            this.gridQuanLyBanDiem.Location = new System.Drawing.Point(12, 149);
            this.gridQuanLyBanDiem.Name = "gridQuanLyBanDiem";
            this.gridQuanLyBanDiem.Size = new System.Drawing.Size(766, 289);
            this.gridQuanLyBanDiem.TabIndex = 44;
            this.gridQuanLyBanDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridQuanLyBanDiem_CellContentClick);
            // 
            // maSinhVien1
            // 
            this.maSinhVien1.DataPropertyName = "MaSinhVien";
            this.maSinhVien1.HeaderText = "Mã sinh viên";
            this.maSinhVien1.Name = "maSinhVien1";
            // 
            // tenSinhVien1
            // 
            this.tenSinhVien1.DataPropertyName = "TenSinhVien";
            this.tenSinhVien1.HeaderText = "Tên sinh viên";
            this.tenSinhVien1.Name = "tenSinhVien1";
            // 
            // tenLop2
            // 
            this.tenLop2.DataPropertyName = "TenLop";
            this.tenLop2.HeaderText = "Tên lớp";
            this.tenLop2.Name = "tenLop2";
            // 
            // tenLopHocPhan1
            // 
            this.tenLopHocPhan1.DataPropertyName = "TenLopHocPhan";
            this.tenLopHocPhan1.HeaderText = "Tên lớp học phần";
            this.tenLopHocPhan1.Name = "tenLopHocPhan1";
            // 
            // diemChuyenCan
            // 
            this.diemChuyenCan.DataPropertyName = "DiemChuyenCan";
            this.diemChuyenCan.HeaderText = "Điểm chuyên cần";
            this.diemChuyenCan.Name = "diemChuyenCan";
            // 
            // diemKiemTra1
            // 
            this.diemKiemTra1.DataPropertyName = "DiemKiemTra1";
            this.diemKiemTra1.HeaderText = "Điểm kiểm tra 1";
            this.diemKiemTra1.Name = "diemKiemTra1";
            // 
            // diemKiemTra2
            // 
            this.diemKiemTra2.DataPropertyName = "DiemKiemTra2";
            this.diemKiemTra2.HeaderText = "Điểm kiểm tra 2";
            this.diemKiemTra2.Name = "diemKiemTra2";
            // 
            // diemKiemTra3
            // 
            this.diemKiemTra3.DataPropertyName = "DiemKiemTra3";
            this.diemKiemTra3.HeaderText = "Điểm kiểm tra 3";
            this.diemKiemTra3.Name = "diemKiemTra3";
            // 
            // diemThi
            // 
            this.diemThi.DataPropertyName = "DiemThi";
            this.diemThi.HeaderText = "ĐIểm thi";
            this.diemThi.Name = "diemThi";
            // 
            // nhap
            // 
            this.nhap.DataPropertyName = "Nhap";
            this.nhap.HeaderText = "Nhập";
            this.nhap.Name = "nhap";
            this.nhap.Text = "Nhập";
            this.nhap.UseColumnTextForButtonValue = true;
            this.nhap.Width = 50;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(464, 105);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 43;
            this.button20.Text = "Tìm kiếm";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Tên sinh viên:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(324, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 25);
            this.label15.TabIndex = 41;
            this.label15.Text = "Quản lý bảng điểm";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(48, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "Mã sinh viên:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // cbxLopHocPhan
            // 
            this.cbxLopHocPhan.FormattingEnabled = true;
            this.cbxLopHocPhan.Location = new System.Drawing.Point(464, 70);
            this.cbxLopHocPhan.Name = "cbxLopHocPhan";
            this.cbxLopHocPhan.Size = new System.Drawing.Size(169, 21);
            this.cbxLopHocPhan.TabIndex = 52;
            this.cbxLopHocPhan.SelectedIndexChanged += new System.EventHandler(this.txtTenSinhVien_TextChanged);
            // 
            // QuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxLopHocPhan);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.txtTenSinhVien);
            this.Controls.Add(this.gridQuanLyBanDiem);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Name = "QuanLyDiem";
            this.Text = "QuanLyDiem";
            this.Load += new System.EventHandler(this.QuanLyDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridQuanLyBanDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuanLyDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.TextBox txtTenSinhVien;
        private System.Windows.Forms.DataGridView gridQuanLyBanDiem;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.BindingSource bsQuanLyDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVien1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSinhVien1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLop2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopHocPhan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemChuyenCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemKiemTra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemKiemTra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemKiemTra3;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemThi;
        private System.Windows.Forms.DataGridViewButtonColumn nhap;
        private System.Windows.Forms.ComboBox cbxLopHocPhan;
    }
}