namespace _3S_project.GUI.FormAdmin.FormThongKe
{
    partial class ThongKeTrungBinhMon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTieuChi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDiemTrungBinh = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiemTrungBinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê theo điểm trung bình";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiêu chí :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbxTieuChi
            // 
            this.cbxTieuChi.FormattingEnabled = true;
            this.cbxTieuChi.Location = new System.Drawing.Point(110, 101);
            this.cbxTieuChi.Name = "cbxTieuChi";
            this.cbxTieuChi.Size = new System.Drawing.Size(210, 21);
            this.cbxTieuChi.TabIndex = 2;
            this.cbxTieuChi.SelectedIndexChanged += new System.EventHandler(this.cbxTieuChi_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "In bảng điểm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVien,
            this.tenSinhVien,
            this.lop,
            this.khoa,
            this.diemTrungBinh});
            this.dataGridView1.Location = new System.Drawing.Point(38, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maSinhVien
            // 
            this.maSinhVien.DataPropertyName = "MaSinhVien";
            this.maSinhVien.HeaderText = "Mã sinh viên";
            this.maSinhVien.Name = "maSinhVien";
            // 
            // tenSinhVien
            // 
            this.tenSinhVien.DataPropertyName = "TenSinhVien";
            this.tenSinhVien.HeaderText = "Tên sinh viên";
            this.tenSinhVien.Name = "tenSinhVien";
            // 
            // lop
            // 
            this.lop.DataPropertyName = "TenLop";
            this.lop.HeaderText = "Lớp";
            this.lop.Name = "lop";
            // 
            // khoa
            // 
            this.khoa.DataPropertyName = "TenKhoa";
            this.khoa.HeaderText = "Khoa";
            this.khoa.Name = "khoa";
            // 
            // diemTrungBinh
            // 
            this.diemTrungBinh.DataPropertyName = "DiemTrungBinh";
            this.diemTrungBinh.HeaderText = "Điểm trung bình";
            this.diemTrungBinh.Name = "diemTrungBinh";
            // 
            // ThongKeTrungBinhMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxTieuChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThongKeTrungBinhMon";
            this.Text = "ThongKeTrungBinhMon";
            this.Load += new System.EventHandler(this.ThongKeTrungBinhMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDiemTrungBinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTieuChi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsDiemTrungBinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTrungBinh;
    }
}