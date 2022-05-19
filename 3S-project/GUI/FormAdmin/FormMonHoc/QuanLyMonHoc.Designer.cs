
namespace _3S_project.GUI.FormAdmin.FormMonHoc
{
    partial class frmQuanLyMonHoc
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.maMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.bindingQuanLyMonHoc = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingQuanLyMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(67, 73);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(274, 20);
            this.textBox6.TabIndex = 33;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView6.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonHoc,
            this.tenMonHoc,
            this.DVPT,
            this.tinChi,
            this.Sua,
            this.Xoa});
            this.dataGridView6.Location = new System.Drawing.Point(67, 157);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(647, 228);
            this.dataGridView6.TabIndex = 32;
            this.dataGridView6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellContentClick);
            // 
            // maMonHoc
            // 
            this.maMonHoc.DataPropertyName = "MaMonHoc";
            this.maMonHoc.HeaderText = "Mã môn học";
            this.maMonHoc.Name = "maMonHoc";
            // 
            // tenMonHoc
            // 
            this.tenMonHoc.DataPropertyName = "TenMonHoc";
            this.tenMonHoc.HeaderText = "Tên môn học";
            this.tenMonHoc.Name = "tenMonHoc";
            // 
            // DVPT
            // 
            this.DVPT.DataPropertyName = "DonViPhuTrach";
            this.DVPT.HeaderText = "ĐVPT";
            this.DVPT.Name = "DVPT";
            // 
            // tinChi
            // 
            this.tinChi.DataPropertyName = "TinChi";
            this.tinChi.HeaderText = "Tín chỉ";
            this.tinChi.Name = "tinChi";
            // 
            // Sua
            // 
            this.Sua.HeaderText = "Sửa";
            this.Sua.Name = "Sua";
            this.Sua.Text = "Sửa";
            this.Sua.UseColumnTextForButtonValue = true;
            this.Sua.Width = 50;
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xoá";
            this.Xoa.Name = "Xoa";
            this.Xoa.Text = "Xoá";
            this.Xoa.UseColumnTextForButtonValue = true;
            this.Xoa.Width = 50;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(67, 114);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(149, 23);
            this.button17.TabIndex = 31;
            this.button17.Text = "Thêm mới học phần";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(349, 73);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(73, 23);
            this.button18.TabIndex = 30;
            this.button18.Text = "Tìm kiếm";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(274, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 25);
            this.label13.TabIndex = 29;
            this.label13.Text = "Quản lý môn học";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // frmQuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.label13);
            this.Name = "frmQuanLyMonHoc";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.frmQuanLyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingQuanLyMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource bindingQuanLyMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinChi;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
    }
}