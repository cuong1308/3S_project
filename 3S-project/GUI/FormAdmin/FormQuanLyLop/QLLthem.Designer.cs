
namespace _3S_project.GUI.FormQuanLyLop
{
    partial class QLLthem
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
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.dongy = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tenkhoa = new System.Windows.Forms.Label();
            this.khoahoc = new System.Windows.Forms.Label();
            this.tenlop = new System.Windows.Forms.Label();
            this.themlophoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(103, 140);
            this.cbxKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(207, 21);
            this.cbxKhoa.TabIndex = 40;
            this.cbxKhoa.SelectedIndexChanged += new System.EventHandler(this.cbxKhoa_SelectedIndexChanged);
            // 
            // dongy
            // 
            this.dongy.Location = new System.Drawing.Point(226, 189);
            this.dongy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dongy.Name = "dongy";
            this.dongy.Size = new System.Drawing.Size(84, 28);
            this.dongy.TabIndex = 39;
            this.dongy.Text = "Đồng ý";
            this.dongy.UseVisualStyleBackColor = true;
            this.dongy.Click += new System.EventHandler(this.dongy_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 108);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 20);
            this.textBox3.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 77);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 37;
            // 
            // tenkhoa
            // 
            this.tenkhoa.AutoSize = true;
            this.tenkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenkhoa.Location = new System.Drawing.Point(30, 143);
            this.tenkhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenkhoa.Name = "tenkhoa";
            this.tenkhoa.Size = new System.Drawing.Size(35, 13);
            this.tenkhoa.TabIndex = 36;
            this.tenkhoa.Text = "Khoa:";
            // 
            // khoahoc
            // 
            this.khoahoc.AutoSize = true;
            this.khoahoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoahoc.Location = new System.Drawing.Point(30, 111);
            this.khoahoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.khoahoc.Name = "khoahoc";
            this.khoahoc.Size = new System.Drawing.Size(58, 13);
            this.khoahoc.TabIndex = 35;
            this.khoahoc.Text = "Khóa Học:";
            // 
            // tenlop
            // 
            this.tenlop.AutoSize = true;
            this.tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenlop.Location = new System.Drawing.Point(30, 77);
            this.tenlop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenlop.Name = "tenlop";
            this.tenlop.Size = new System.Drawing.Size(50, 13);
            this.tenlop.TabIndex = 34;
            this.tenlop.Text = "Tên Lớp:";
            // 
            // themlophoc
            // 
            this.themlophoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themlophoc.Location = new System.Drawing.Point(28, 27);
            this.themlophoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.themlophoc.Name = "themlophoc";
            this.themlophoc.Size = new System.Drawing.Size(186, 28);
            this.themlophoc.TabIndex = 33;
            this.themlophoc.Text = "Thêm Lớp Học";
            // 
            // QLLthem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 238);
            this.Controls.Add(this.cbxKhoa);
            this.Controls.Add(this.dongy);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tenkhoa);
            this.Controls.Add(this.khoahoc);
            this.Controls.Add(this.tenlop);
            this.Controls.Add(this.themlophoc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QLLthem";
            this.Text = "QLLthem";
            this.Load += new System.EventHandler(this.QLLthem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.Button dongy;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label tenkhoa;
        private System.Windows.Forms.Label khoahoc;
        private System.Windows.Forms.Label tenlop;
        private System.Windows.Forms.Label themlophoc;
    }
}