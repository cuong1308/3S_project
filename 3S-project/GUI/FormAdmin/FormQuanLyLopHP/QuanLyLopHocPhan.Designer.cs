
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
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monHoc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangVien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button16 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(371, 175);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(226, 35);
            this.button14.TabIndex = 29;
            this.button14.Text = "Quản Lý sinh viên";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(774, 101);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(112, 35);
            this.button15.TabIndex = 28;
            this.button15.Text = "Tìm kiếm";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.maLopHocPhan,
            this.tenLopHocPhan,
            this.hocKi,
            this.namHoc,
            this.monHoc1,
            this.giangVien1,
            this.dataGridViewButtonColumn3,
            this.dataGridViewButtonColumn4});
            this.dataGridView5.Location = new System.Drawing.Point(45, 261);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 62;
            this.dataGridView5.Size = new System.Drawing.Size(1262, 351);
            this.dataGridView5.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // maLopHocPhan
            // 
            this.maLopHocPhan.HeaderText = "Mã lớp học phần";
            this.maLopHocPhan.MinimumWidth = 8;
            this.maLopHocPhan.Name = "maLopHocPhan";
            this.maLopHocPhan.Width = 150;
            // 
            // tenLopHocPhan
            // 
            this.tenLopHocPhan.HeaderText = "Tên lớp học phần";
            this.tenLopHocPhan.MinimumWidth = 8;
            this.tenLopHocPhan.Name = "tenLopHocPhan";
            this.tenLopHocPhan.Width = 150;
            // 
            // hocKi
            // 
            this.hocKi.HeaderText = "Học kì";
            this.hocKi.MinimumWidth = 8;
            this.hocKi.Name = "hocKi";
            this.hocKi.Width = 150;
            // 
            // namHoc
            // 
            this.namHoc.HeaderText = "Năm học";
            this.namHoc.MinimumWidth = 8;
            this.namHoc.Name = "namHoc";
            this.namHoc.Width = 150;
            // 
            // monHoc1
            // 
            this.monHoc1.HeaderText = "Môn học";
            this.monHoc1.MinimumWidth = 8;
            this.monHoc1.Name = "monHoc1";
            this.monHoc1.Width = 150;
            // 
            // giangVien1
            // 
            this.giangVien1.HeaderText = "Giảng viên";
            this.giangVien1.MinimumWidth = 8;
            this.giangVien1.Name = "giangVien1";
            this.giangVien1.Width = 150;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "Sửa";
            this.dataGridViewButtonColumn3.MinimumWidth = 8;
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Text = "Sửa";
            this.dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn3.Width = 150;
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.HeaderText = "Xoá";
            this.dataGridViewButtonColumn4.MinimumWidth = 8;
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            this.dataGridViewButtonColumn4.Text = "Xoá";
            this.dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn4.Width = 150;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(80, 170);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(232, 35);
            this.button16.TabIndex = 26;
            this.button16.Text = "Thêm lớp học phần mới";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(509, 101);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(224, 26);
            this.textBox5.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(354, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tìm kiếm theo mã lớp học phần/tên lớp học phần:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(533, 44);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(298, 36);
            this.label11.TabIndex = 23;
            this.label11.Text = "Quản lý lớp học phần";
            // 
            // QuanLyLopHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 663);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "QuanLyLopHocPhan";
            this.Text = "QuanLyLopHocPhan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn namHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn monHoc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giangVien1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn4;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}