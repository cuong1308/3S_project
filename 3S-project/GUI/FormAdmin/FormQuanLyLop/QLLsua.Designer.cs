
namespace _3S_project.GUI.FormQuanLyLop
{
    partial class QLLsua
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
            this.dongy = new System.Windows.Forms.Button();
            this.txtKhoaHoc = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.tenkhoa = new System.Windows.Forms.Label();
            this.khoahoc = new System.Windows.Forms.Label();
            this.tenlop = new System.Windows.Forms.Label();
            this.sualophoc = new System.Windows.Forms.Label();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dongy
            // 
            this.dongy.Location = new System.Drawing.Point(225, 196);
            this.dongy.Margin = new System.Windows.Forms.Padding(2);
            this.dongy.Name = "dongy";
            this.dongy.Size = new System.Drawing.Size(84, 28);
            this.dongy.TabIndex = 47;
            this.dongy.Text = "Sửa";
            this.dongy.UseVisualStyleBackColor = true;
            this.dongy.Click += new System.EventHandler(this.dongy_Click);
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.Location = new System.Drawing.Point(104, 117);
            this.txtKhoaHoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Size = new System.Drawing.Size(205, 20);
            this.txtKhoaHoc.TabIndex = 45;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(104, 84);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(205, 20);
            this.txtTenLop.TabIndex = 44;
            // 
            // tenkhoa
            // 
            this.tenkhoa.AutoSize = true;
            this.tenkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenkhoa.Location = new System.Drawing.Point(32, 156);
            this.tenkhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenkhoa.Name = "tenkhoa";
            this.tenkhoa.Size = new System.Drawing.Size(57, 13);
            this.tenkhoa.TabIndex = 43;
            this.tenkhoa.Text = "Tên Khoa:";
            // 
            // khoahoc
            // 
            this.khoahoc.AutoSize = true;
            this.khoahoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoahoc.Location = new System.Drawing.Point(32, 120);
            this.khoahoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.khoahoc.Name = "khoahoc";
            this.khoahoc.Size = new System.Drawing.Size(58, 13);
            this.khoahoc.TabIndex = 42;
            this.khoahoc.Text = "Khóa Học:";
            // 
            // tenlop
            // 
            this.tenlop.AutoSize = true;
            this.tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenlop.Location = new System.Drawing.Point(32, 87);
            this.tenlop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenlop.Name = "tenlop";
            this.tenlop.Size = new System.Drawing.Size(50, 13);
            this.tenlop.TabIndex = 41;
            this.tenlop.Text = "Tên Lớp:";
            // 
            // sualophoc
            // 
            this.sualophoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sualophoc.Location = new System.Drawing.Point(30, 27);
            this.sualophoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sualophoc.Name = "sualophoc";
            this.sualophoc.Size = new System.Drawing.Size(186, 28);
            this.sualophoc.TabIndex = 40;
            this.sualophoc.Text = "Sửa Lớp Học";
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(104, 153);
            this.cbxKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(205, 21);
            this.cbxKhoa.TabIndex = 48;
            // 
            // QLLsua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 244);
            this.Controls.Add(this.cbxKhoa);
            this.Controls.Add(this.dongy);
            this.Controls.Add(this.txtKhoaHoc);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.tenkhoa);
            this.Controls.Add(this.khoahoc);
            this.Controls.Add(this.tenlop);
            this.Controls.Add(this.sualophoc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QLLsua";
            this.Text = "QLLsua";
            this.Load += new System.EventHandler(this.QLLsua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dongy;
        private System.Windows.Forms.TextBox txtKhoaHoc;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label tenkhoa;
        private System.Windows.Forms.Label khoahoc;
        private System.Windows.Forms.Label tenlop;
        private System.Windows.Forms.Label sualophoc;
        private System.Windows.Forms.ComboBox cbxKhoa;
    }
}