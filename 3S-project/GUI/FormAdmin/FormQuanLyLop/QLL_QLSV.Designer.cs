
namespace _3S_project.GUI.FormQuanLyLop
{
    partial class QLL_QLSV
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
            this.themsv = new System.Windows.Forms.Button();
            this.suasv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CulMaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xoasv = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tenkhoa = new System.Windows.Forms.Label();
            this.khoahoc = new System.Windows.Forms.Label();
            this.malop = new System.Windows.Forms.Label();
            this.tenlop = new System.Windows.Forms.Label();
            this.qlsv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // themsv
            // 
            this.themsv.Location = new System.Drawing.Point(666, 453);
            this.themsv.Name = "themsv";
            this.themsv.Size = new System.Drawing.Size(126, 44);
            this.themsv.TabIndex = 55;
            this.themsv.Text = "Thêm";
            this.themsv.UseVisualStyleBackColor = true;
            this.themsv.Click += new System.EventHandler(this.themsv_Click);
            // 
            // suasv
            // 
            this.suasv.Location = new System.Drawing.Point(836, 453);
            this.suasv.Name = "suasv";
            this.suasv.Size = new System.Drawing.Size(126, 44);
            this.suasv.TabIndex = 54;
            this.suasv.Text = "Sửa";
            this.suasv.UseVisualStyleBackColor = true;
            this.suasv.Click += new System.EventHandler(this.suasv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CulMaSinhVien,
            this.tensinhvien,
            this.NgaySinh,
            this.gioitinh,
            this.tenlophoc,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(123, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(922, 150);
            this.dataGridView1.TabIndex = 53;
            // 
            // CulMaSinhVien
            // 
            this.CulMaSinhVien.HeaderText = "Mã Sinh Viên";
            this.CulMaSinhVien.MinimumWidth = 8;
            this.CulMaSinhVien.Name = "CulMaSinhVien";
            this.CulMaSinhVien.Width = 150;
            // 
            // tensinhvien
            // 
            this.tensinhvien.HeaderText = "Tên Sinh Viên";
            this.tensinhvien.MinimumWidth = 8;
            this.tensinhvien.Name = "tensinhvien";
            this.tensinhvien.Width = 150;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 8;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 150;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.MinimumWidth = 8;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 150;
            // 
            // tenlophoc
            // 
            this.tenlophoc.HeaderText = "Tên Lớp Học";
            this.tenlophoc.MinimumWidth = 8;
            this.tenlophoc.Name = "tenlophoc";
            this.tenlophoc.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Khoa";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(759, 222);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(276, 26);
            this.textBox6.TabIndex = 52;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(755, 170);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(276, 26);
            this.textBox5.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tên Khoa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tên Lớp Học:";
            // 
            // xoasv
            // 
            this.xoasv.Location = new System.Drawing.Point(991, 453);
            this.xoasv.Name = "xoasv";
            this.xoasv.Size = new System.Drawing.Size(126, 44);
            this.xoasv.TabIndex = 48;
            this.xoasv.Text = "Xóa";
            this.xoasv.UseVisualStyleBackColor = true;
            this.xoasv.Click += new System.EventHandler(this.xoasv_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(755, 121);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(276, 26);
            this.textBox4.TabIndex = 47;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(294, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(276, 26);
            this.textBox3.TabIndex = 46;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(294, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 26);
            this.textBox2.TabIndex = 45;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 26);
            this.textBox1.TabIndex = 44;
            // 
            // tenkhoa
            // 
            this.tenkhoa.AutoSize = true;
            this.tenkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenkhoa.Location = new System.Drawing.Point(598, 122);
            this.tenkhoa.Name = "tenkhoa";
            this.tenkhoa.Size = new System.Drawing.Size(106, 25);
            this.tenkhoa.TabIndex = 43;
            this.tenkhoa.Text = "Giới Tính:";
            // 
            // khoahoc
            // 
            this.khoahoc.AutoSize = true;
            this.khoahoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoahoc.Location = new System.Drawing.Point(118, 222);
            this.khoahoc.Name = "khoahoc";
            this.khoahoc.Size = new System.Drawing.Size(119, 25);
            this.khoahoc.TabIndex = 42;
            this.khoahoc.Text = "Ngày Sinh:";
            // 
            // malop
            // 
            this.malop.AutoSize = true;
            this.malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malop.Location = new System.Drawing.Point(118, 119);
            this.malop.Name = "malop";
            this.malop.Size = new System.Drawing.Size(149, 25);
            this.malop.TabIndex = 41;
            this.malop.Text = "Mã Sinh Viên:";
            // 
            // tenlop
            // 
            this.tenlop.AutoSize = true;
            this.tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenlop.Location = new System.Drawing.Point(118, 175);
            this.tenlop.Name = "tenlop";
            this.tenlop.Size = new System.Drawing.Size(157, 25);
            this.tenlop.TabIndex = 40;
            this.tenlop.Text = "Tên Sinh Viên:";
            // 
            // qlsv
            // 
            this.qlsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlsv.Location = new System.Drawing.Point(433, 47);
            this.qlsv.Name = "qlsv";
            this.qlsv.Size = new System.Drawing.Size(404, 41);
            this.qlsv.TabIndex = 39;
            this.qlsv.Text = "Quản Lý Sinh Viên";
            this.qlsv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QLL_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 545);
            this.Controls.Add(this.themsv);
            this.Controls.Add(this.suasv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xoasv);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tenkhoa);
            this.Controls.Add(this.khoahoc);
            this.Controls.Add(this.malop);
            this.Controls.Add(this.tenlop);
            this.Controls.Add(this.qlsv);
            this.Name = "QLL_QLSV";
            this.Text = "QLL_QLSV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button themsv;
        private System.Windows.Forms.Button suasv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CulMaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button xoasv;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tenkhoa;
        private System.Windows.Forms.Label khoahoc;
        private System.Windows.Forms.Label malop;
        private System.Windows.Forms.Label tenlop;
        private System.Windows.Forms.Label qlsv;
    }
}