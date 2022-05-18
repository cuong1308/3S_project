namespace _3S_project.GUI.FormAdmin.FormThongKe
{
    partial class ThongKeLop
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
            this.gridLop = new System.Windows.Forms.DataGridView();
            this.maSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemThanhPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxTieuChi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.bsLop = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLop)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLop
            // 
            this.gridLop.AllowUserToAddRows = false;
            this.gridLop.AllowUserToDeleteRows = false;
            this.gridLop.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridLop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVien,
            this.tenSinhVien,
            this.diemThanhPhan,
            this.diemThi,
            this.diemTongKet});
            this.gridLop.Location = new System.Drawing.Point(37, 160);
            this.gridLop.Name = "gridLop";
            this.gridLop.Size = new System.Drawing.Size(544, 150);
            this.gridLop.TabIndex = 11;
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
            this.button2.Location = new System.Drawing.Point(462, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "In bảng điểm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxTieuChi
            // 
            this.cbxTieuChi.FormattingEnabled = true;
            this.cbxTieuChi.Location = new System.Drawing.Point(134, 110);
            this.cbxTieuChi.Name = "cbxTieuChi";
            this.cbxTieuChi.Size = new System.Drawing.Size(210, 21);
            this.cbxTieuChi.TabIndex = 8;
            this.cbxTieuChi.SelectedIndexChanged += new System.EventHandler(this.cbxTieuChi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiêu chí :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thống kê theo lớp học phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lớp học phần :";
            // 
            // cbxLop
            // 
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(134, 80);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(210, 21);
            this.cbxLop.TabIndex = 13;
            this.cbxLop.SelectedIndexChanged += new System.EventHandler(this.cbxTieuChi_SelectedIndexChanged);
            // 
            // ThongKeLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 375);
            this.Controls.Add(this.cbxLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridLop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxTieuChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThongKeLop";
            this.Text = "ThongKeLop";
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxTieuChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemThanhPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTongKet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.BindingSource bsLop;
    }
}