namespace _3S_project.GUI.FormAdmin.FormQuanLyLopHP
{
    partial class QLLHP_addSV
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
            this.button1 = new System.Windows.Forms.Button();
            this.themsv = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.malop = new System.Windows.Forms.Label();
            this.tenlop = new System.Windows.Forms.Label();
            this.bsQuanLySinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.maSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSinhVIen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuanLySinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 81;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // themsv
            // 
            this.themsv.Location = new System.Drawing.Point(695, 300);
            this.themsv.Margin = new System.Windows.Forms.Padding(2);
            this.themsv.Name = "themsv";
            this.themsv.Size = new System.Drawing.Size(84, 29);
            this.themsv.TabIndex = 80;
            this.themsv.Text = "Thêm";
            this.themsv.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(323, 23);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 78;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 77;
            // 
            // malop
            // 
            this.malop.AutoSize = true;
            this.malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malop.Location = new System.Drawing.Point(33, 26);
            this.malop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.malop.Name = "malop";
            this.malop.Size = new System.Drawing.Size(73, 13);
            this.malop.TabIndex = 76;
            this.malop.Text = "Mã Sinh Viên:";
            // 
            // tenlop
            // 
            this.tenlop.AutoSize = true;
            this.tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenlop.Location = new System.Drawing.Point(246, 26);
            this.tenlop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenlop.Name = "tenlop";
            this.tenlop.Size = new System.Drawing.Size(77, 13);
            this.tenlop.TabIndex = 75;
            this.tenlop.Text = "Tên Sinh Viên:";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVien,
            this.tenSinhVIen,
            this.sinhVien,
            this.gioiTinh,
            this.diaChi,
            this.tenLop1});
            this.dataGridView4.Location = new System.Drawing.Point(36, 75);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(864, 188);
            this.dataGridView4.TabIndex = 82;
            // 
            // maSinhVien
            // 
            this.maSinhVien.DataPropertyName = "MaSinhVien";
            this.maSinhVien.HeaderText = "Mã sinh viên";
            this.maSinhVien.Name = "maSinhVien";
            // 
            // tenSinhVIen
            // 
            this.tenSinhVIen.DataPropertyName = "TenSinhVien";
            this.tenSinhVIen.HeaderText = "Tên sinh viên";
            this.tenSinhVIen.Name = "tenSinhVIen";
            // 
            // sinhVien
            // 
            this.sinhVien.DataPropertyName = "DateTime";
            this.sinhVien.HeaderText = "Ngày sinh";
            this.sinhVien.Name = "sinhVien";
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "GioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "DiaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            // 
            // tenLop1
            // 
            this.tenLop1.DataPropertyName = "TenLop";
            this.tenLop1.HeaderText = "Tên lớp";
            this.tenLop1.Name = "tenLop1";
            this.tenLop1.Width = 150;
            // 
            // QLLHP_addSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.themsv);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.malop);
            this.Controls.Add(this.tenlop);
            this.Name = "QLLHP_addSV";
            this.Text = "QLLHP_addSV";
            ((System.ComponentModel.ISupportInitialize)(this.bsQuanLySinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button themsv;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label malop;
        private System.Windows.Forms.Label tenlop;
        private System.Windows.Forms.BindingSource bsQuanLySinhVien;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSinhVIen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLop1;
    }
}