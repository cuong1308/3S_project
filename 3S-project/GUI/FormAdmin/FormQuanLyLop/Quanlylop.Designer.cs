
namespace _3S_project.GUI.FormQuanLyLop
{
    partial class Quanlylop
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
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoa1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(261, 163);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(226, 35);
            this.button10.TabIndex = 22;
            this.button10.Text = "Quản lý sinh viên";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(527, 88);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 35);
            this.button9.TabIndex = 21;
            this.button9.Text = "Tìm kiếm";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maLop,
            this.tenLop,
            this.tenKhoa1,
            this.khoaHoc,
            this.sua,
            this.xoa});
            this.dataGridView3.Location = new System.Drawing.Point(54, 249);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.Size = new System.Drawing.Size(1114, 351);
            this.dataGridView3.TabIndex = 20;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 8;
            this.stt.Name = "stt";
            this.stt.Width = 150;
            // 
            // maLop
            // 
            this.maLop.HeaderText = "Mã lớp";
            this.maLop.MinimumWidth = 8;
            this.maLop.Name = "maLop";
            this.maLop.Width = 150;
            // 
            // tenLop
            // 
            this.tenLop.HeaderText = "Tên lớp";
            this.tenLop.MinimumWidth = 8;
            this.tenLop.Name = "tenLop";
            this.tenLop.Width = 150;
            // 
            // tenKhoa1
            // 
            this.tenKhoa1.HeaderText = "Tên khoa";
            this.tenKhoa1.MinimumWidth = 8;
            this.tenKhoa1.Name = "tenKhoa1";
            this.tenKhoa1.Width = 150;
            // 
            // khoaHoc
            // 
            this.khoaHoc.HeaderText = "Khoá học";
            this.khoaHoc.MinimumWidth = 8;
            this.khoaHoc.Name = "khoaHoc";
            this.khoaHoc.Width = 150;
            // 
            // sua
            // 
            this.sua.HeaderText = "Sửa";
            this.sua.MinimumWidth = 8;
            this.sua.Name = "sua";
            this.sua.Text = "Sửa";
            this.sua.UseColumnTextForButtonValue = true;
            this.sua.Width = 150;
            // 
            // xoa
            // 
            this.xoa.HeaderText = "Xoá";
            this.xoa.MinimumWidth = 8;
            this.xoa.Name = "xoa";
            this.xoa.Text = "Xoá";
            this.xoa.UseColumnTextForButtonValue = true;
            this.xoa.Width = 150;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(54, 163);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(198, 35);
            this.button11.TabIndex = 19;
            this.button11.Text = "Thêm lớp học mới";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(280, 88);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 26);
            this.textBox3.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tìm kiếm theo mã lớp/tên lớp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(521, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 36);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quản lý lớp ";
            // 
            // Quanlylop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 632);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "Quanlylop";
            this.Text = "Quanlylop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoa1;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoaHoc;
        private System.Windows.Forms.DataGridViewButtonColumn sua;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}