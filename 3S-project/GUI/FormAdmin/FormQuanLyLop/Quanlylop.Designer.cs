
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
            this.components = new System.ComponentModel.Container();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.maLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoa1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xoa1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bsQLLop = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQLLop)).BeginInit();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(174, 106);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(151, 23);
            this.button10.TabIndex = 22;
            this.button10.Text = "Quản lý sinh viên";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(351, 57);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 21;
            this.button9.Text = "Tìm kiếm";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLop,
            this.tenLop,
            this.tenKhoa1,
            this.khoaHoc,
            this.Sua1,
            this.Xoa1});
            this.dataGridView3.Location = new System.Drawing.Point(36, 162);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.Size = new System.Drawing.Size(742, 228);
            this.dataGridView3.TabIndex = 20;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // maLop
            // 
            this.maLop.DataPropertyName = "MaLop";
            this.maLop.HeaderText = "Mã lớp";
            this.maLop.MinimumWidth = 8;
            this.maLop.Name = "maLop";
            // 
            // tenLop
            // 
            this.tenLop.DataPropertyName = "TenLop";
            this.tenLop.HeaderText = "Tên lớp";
            this.tenLop.MinimumWidth = 8;
            this.tenLop.Name = "tenLop";
            this.tenLop.Width = 150;
            // 
            // tenKhoa1
            // 
            this.tenKhoa1.DataPropertyName = "TenKhoa";
            this.tenKhoa1.HeaderText = "Tên khoa";
            this.tenKhoa1.MinimumWidth = 8;
            this.tenKhoa1.Name = "tenKhoa1";
            this.tenKhoa1.Width = 150;
            // 
            // khoaHoc
            // 
            this.khoaHoc.DataPropertyName = "KhoaHoc";
            this.khoaHoc.HeaderText = "Khoá học";
            this.khoaHoc.MinimumWidth = 8;
            this.khoaHoc.Name = "khoaHoc";
            this.khoaHoc.Width = 150;
            // 
            // Sua1
            // 
            this.Sua1.HeaderText = "Sửa";
            this.Sua1.MinimumWidth = 8;
            this.Sua1.Name = "Sua1";
            this.Sua1.Text = "Sửa";
            this.Sua1.UseColumnTextForButtonValue = true;
            this.Sua1.Width = 50;
            // 
            // Xoa1
            // 
            this.Xoa1.HeaderText = "Xoá";
            this.Xoa1.MinimumWidth = 8;
            this.Xoa1.Name = "Xoa1";
            this.Xoa1.Text = "Xoá";
            this.Xoa1.UseColumnTextForButtonValue = true;
            this.Xoa1.Width = 50;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(36, 106);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(132, 23);
            this.button11.TabIndex = 19;
            this.button11.Text = "Thêm lớp học mới";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 18;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tìm kiếm theo mã lớp/tên lớp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(347, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quản lý lớp ";
            // 
            // Quanlylop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 411);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Quanlylop";
            this.Text = "Quanlylop";
            this.Load += new System.EventHandler(this.Quanlylop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQLLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource bsQLLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoa1;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoaHoc;
        private System.Windows.Forms.DataGridViewButtonColumn Sua1;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa1;
    }
}