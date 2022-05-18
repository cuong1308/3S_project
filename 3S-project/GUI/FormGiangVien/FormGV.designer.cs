
namespace _3S_project.GUI.FormAdmin.QuanLyGiangVien
{
    partial class FormGV
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtGiangVien = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bsGiangVien = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTimKiem.Location = new System.Drawing.Point(257, 77);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(71, 23);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtGiangVien
            // 
            this.txtGiangVien.Location = new System.Drawing.Point(98, 77);
            this.txtGiangVien.Multiline = true;
            this.txtGiangVien.Name = "txtGiangVien";
            this.txtGiangVien.Size = new System.Drawing.Size(153, 23);
            this.txtGiangVien.TabIndex = 1;
            this.txtGiangVien.TextChanged += new System.EventHandler(this.txtGiangVien_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2.Location = new System.Drawing.Point(98, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 21);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaGiangVien,
            this.colTenGiangVien,
            this.colSua,
            this.colXoa});
            this.dataGridView1.Location = new System.Drawing.Point(98, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 194);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colMaGiangVien
            // 
            this.colMaGiangVien.DataPropertyName = "MaGiangVien";
            this.colMaGiangVien.HeaderText = "Mã giảng viên";
            this.colMaGiangVien.Name = "colMaGiangVien";
            // 
            // colTenGiangVien
            // 
            this.colTenGiangVien.DataPropertyName = "TenGiangVien";
            this.colTenGiangVien.HeaderText = "Tên giảng viên";
            this.colTenGiangVien.Name = "colTenGiangVien";
            // 
            // colSua
            // 
            this.colSua.HeaderText = "Sửa";
            this.colSua.Name = "colSua";
            this.colSua.Text = "Sửa";
            this.colSua.UseColumnTextForButtonValue = true;
            // 
            // colXoa
            // 
            this.colXoa.HeaderText = "Xóa";
            this.colXoa.Name = "colXoa";
            this.colXoa.Text = "Xoá";
            this.colXoa.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(237, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quàn lý giảng viên";
            // 
            // FormGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtGiangVien);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "FormGV";
            this.Text = "Quản Lý Giảng Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtGiangVien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsGiangVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenGiangVien;
        private System.Windows.Forms.DataGridViewButtonColumn colSua;
        private System.Windows.Forms.DataGridViewButtonColumn colXoa;
    }
}