
namespace _3S_project.GUI.FormAdmin.FormQuanLyKhoa
{
    partial class FormQuanLyKhoa
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
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sua3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xoa3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bsQuanLyKhoa = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuanLyKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(225, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhoa,
            this.tenKhoa,
            this.sua3,
            this.xoa3});
            this.dataGridView2.Location = new System.Drawing.Point(68, 137);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(555, 228);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // maKhoa
            // 
            this.maKhoa.DataPropertyName = "MaKhoa";
            this.maKhoa.HeaderText = "Mã khoa";
            this.maKhoa.MinimumWidth = 100;
            this.maKhoa.Name = "maKhoa";
            this.maKhoa.Width = 200;
            // 
            // tenKhoa
            // 
            this.tenKhoa.DataPropertyName = "TenKhoa";
            this.tenKhoa.HeaderText = "Tên khoa";
            this.tenKhoa.MinimumWidth = 6;
            this.tenKhoa.Name = "tenKhoa";
            this.tenKhoa.Width = 200;
            // 
            // sua3
            // 
            this.sua3.HeaderText = "Sửa";
            this.sua3.MinimumWidth = 6;
            this.sua3.Name = "sua3";
            this.sua3.Text = "Sửa";
            this.sua3.UseColumnTextForButtonValue = true;
            this.sua3.Width = 50;
            // 
            // xoa3
            // 
            this.xoa3.HeaderText = "Xoá";
            this.xoa3.MinimumWidth = 6;
            this.xoa3.Name = "xoa3";
            this.xoa3.Text = "Xoá";
            this.xoa3.UseColumnTextForButtonValue = true;
            this.xoa3.Width = 50;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(68, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Thêm";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quản lý khoa";
            // 
            // FormQuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 387);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormQuanLyKhoa";
            this.Text = "FormQuanLyKhoa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuanLyKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bsQuanLyKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoa;
        private System.Windows.Forms.DataGridViewButtonColumn sua3;
        private System.Windows.Forms.DataGridViewButtonColumn xoa3;
    }
}