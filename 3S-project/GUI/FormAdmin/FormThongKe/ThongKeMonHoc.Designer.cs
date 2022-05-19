namespace _3S_project.GUI.FormAdmin.FormThongKe
{
    partial class ThongKeMonHoc
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
            this.cbxMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridTK = new System.Windows.Forms.DataGridView();
            this.maSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemThanhPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxTieuChi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.FormattingEnabled = true;
            this.cbxMonHoc.Location = new System.Drawing.Point(136, 86);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(210, 21);
            this.cbxMonHoc.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Môn học :";
            // 
            // gridTK
            // 
            this.gridTK.AllowUserToAddRows = false;
            this.gridTK.AllowUserToDeleteRows = false;
            this.gridTK.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVien,
            this.tenSinhVien,
            this.tenLop,
            this.tenLopHocPhan,
            this.diemThanhPhan,
            this.diemThi,
            this.diemTongKet});
            this.gridTK.Location = new System.Drawing.Point(39, 166);
            this.gridTK.Name = "gridTK";
            this.gridTK.Size = new System.Drawing.Size(544, 184);
            this.gridTK.TabIndex = 19;
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
            // tenLop
            // 
            this.tenLop.DataPropertyName = "TenLop";
            this.tenLop.HeaderText = "Lớp";
            this.tenLop.Name = "tenLop";
            // 
            // tenLopHocPhan
            // 
            this.tenLopHocPhan.DataPropertyName = "TenLopHocPhan";
            this.tenLopHocPhan.HeaderText = "Lớp học phần";
            this.tenLopHocPhan.Name = "tenLopHocPhan";
            // 
            // diemThanhPhan
            // 
            this.diemThanhPhan.DataPropertyName = "DiemThanhPhan";
            this.diemThanhPhan.HeaderText = "Điểm thành phần";
            this.diemThanhPhan.Name = "diemThanhPhan";
            // 
            // diemThi
            // 
            this.diemThi.DataPropertyName = "DiemThi";
            this.diemThi.HeaderText = "Điểm thi";
            this.diemThi.Name = "diemThi";
            // 
            // diemTongKet
            // 
            this.diemTongKet.DataPropertyName = "DiemTongKet";
            this.diemTongKet.HeaderText = "Điểm tổng kết";
            this.diemTongKet.Name = "diemTongKet";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 24);
            this.button2.TabIndex = 18;
            this.button2.Text = "In bảng điểm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxTieuChi
            // 
            this.cbxTieuChi.FormattingEnabled = true;
            this.cbxTieuChi.Location = new System.Drawing.Point(136, 116);
            this.cbxTieuChi.Name = "cbxTieuChi";
            this.cbxTieuChi.Size = new System.Drawing.Size(210, 21);
            this.cbxTieuChi.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tiêu chí :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thống kê theo môn học";
            // 
            // ThongKeMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 375);
            this.Controls.Add(this.cbxMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridTK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxTieuChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThongKeMonHoc";
            this.Text = "ThongKeMonHoc";
            this.Load += new System.EventHandler(this.ThongKeMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridTK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxTieuChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemThanhPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTongKet;
    }
}