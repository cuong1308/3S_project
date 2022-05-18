
namespace _3S_project.GUI.FormQuanLyLop
{
    partial class QuanLyLopHocPhan
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
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.maLopHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monHoc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangVien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button16 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bsQuanLyLopHP = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuanLyLopHP)).BeginInit();
            this.SuspendLayout();
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(214, 114);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(151, 23);
            this.button14.TabIndex = 29;
            this.button14.Text = "Quản Lý sinh viên";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(456, 66);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 28;
            this.button15.Text = "Tìm kiếm";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLopHocPhan,
            this.tenLopHocPhan,
            this.hocKi,
            this.namHoc,
            this.monHoc1,
            this.giangVien1,
            this.Sua,
            this.Xoa});
            this.dataGridView5.Location = new System.Drawing.Point(30, 170);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 62;
            this.dataGridView5.Size = new System.Drawing.Size(841, 228);
            this.dataGridView5.TabIndex = 27;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // maLopHocPhan
            // 
            this.maLopHocPhan.DataPropertyName = "MaLopHocPhan";
            this.maLopHocPhan.HeaderText = "Mã lớp học phần";
            this.maLopHocPhan.MinimumWidth = 8;
            this.maLopHocPhan.Name = "maLopHocPhan";
            // 
            // tenLopHocPhan
            // 
            this.tenLopHocPhan.DataPropertyName = "TenLopHocPhan";
            this.tenLopHocPhan.HeaderText = "Tên lớp học phần";
            this.tenLopHocPhan.MinimumWidth = 8;
            this.tenLopHocPhan.Name = "tenLopHocPhan";
            this.tenLopHocPhan.Width = 150;
            // 
            // hocKi
            // 
            this.hocKi.DataPropertyName = "HocKi";
            this.hocKi.HeaderText = "Học kì";
            this.hocKi.MinimumWidth = 8;
            this.hocKi.Name = "hocKi";
            this.hocKi.Width = 50;
            // 
            // namHoc
            // 
            this.namHoc.DataPropertyName = "NamHoc";
            this.namHoc.HeaderText = "Năm học";
            this.namHoc.MinimumWidth = 8;
            this.namHoc.Name = "namHoc";
            // 
            // monHoc1
            // 
            this.monHoc1.DataPropertyName = "TenMonHoc";
            this.monHoc1.HeaderText = "Môn học";
            this.monHoc1.MinimumWidth = 8;
            this.monHoc1.Name = "monHoc1";
            this.monHoc1.Width = 150;
            // 
            // giangVien1
            // 
            this.giangVien1.DataPropertyName = "TenGiangVien";
            this.giangVien1.HeaderText = "Giảng viên";
            this.giangVien1.MinimumWidth = 8;
            this.giangVien1.Name = "giangVien1";
            this.giangVien1.Width = 125;
            // 
            // Sua
            // 
            this.Sua.DataPropertyName = "Sua";
            this.Sua.HeaderText = "Sửa";
            this.Sua.MinimumWidth = 8;
            this.Sua.Name = "Sua";
            this.Sua.Text = "Sửa";
            this.Sua.UseColumnTextForButtonValue = true;
            this.Sua.Width = 50;
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            this.Xoa.HeaderText = "Xoá";
            this.Xoa.MinimumWidth = 8;
            this.Xoa.Name = "Xoa";
            this.Xoa.Text = "Xoá";
            this.Xoa.UseColumnTextForButtonValue = true;
            this.Xoa.Width = 50;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(53, 114);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(155, 23);
            this.button16.TabIndex = 26;
            this.button16.Text = "Thêm lớp học phần mới";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(299, 66);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(151, 20);
            this.textBox5.TabIndex = 25;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tìm kiếm theo mã lớp học phần/tên lớp học phần:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(355, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Quản lý lớp học phần";
            // 
            // QuanLyLopHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 431);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyLopHocPhan";
            this.Text = "QuanLyLopHocPhan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuanLyLopHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource bsQuanLyLopHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn namHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn monHoc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giangVien1;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
    }
}