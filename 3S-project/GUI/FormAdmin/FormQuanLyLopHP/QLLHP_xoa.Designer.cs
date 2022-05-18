
namespace _3S_project.GUI.FormAdmin.FormQuanLyLopHP
{
    partial class frmXoaLHP
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
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.maLopHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monHoc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangVien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.bsXoaMHP = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsXoaMHP)).BeginInit();
            this.SuspendLayout();
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
            this.giangVien1});
            this.dataGridView5.Location = new System.Drawing.Point(12, 12);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 62;
            this.dataGridView5.Size = new System.Drawing.Size(919, 68);
            this.dataGridView5.TabIndex = 28;
            // 
            // maLopHocPhan
            // 
            this.maLopHocPhan.DataPropertyName = "MaLopHocPhan";
            this.maLopHocPhan.HeaderText = "Mã lớp học phần";
            this.maLopHocPhan.MinimumWidth = 8;
            this.maLopHocPhan.Name = "maLopHocPhan";
            this.maLopHocPhan.Width = 150;
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
            this.hocKi.Width = 150;
            // 
            // namHoc
            // 
            this.namHoc.DataPropertyName = "NamHoc";
            this.namHoc.HeaderText = "Năm học";
            this.namHoc.MinimumWidth = 8;
            this.namHoc.Name = "namHoc";
            this.namHoc.Width = 150;
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
            this.giangVien1.Width = 150;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(826, 86);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmXoaLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 121);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dataGridView5);
            this.Name = "frmXoaLHP";
            this.Text = "QLLHP_xoa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsXoaMHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn namHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn monHoc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giangVien1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.BindingSource bsXoaMHP;
    }
}