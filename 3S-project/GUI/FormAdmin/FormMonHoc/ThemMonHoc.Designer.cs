
namespace _3S_project.GUI.FormAdmin.FormMonHoc
{
    partial class frmThemMonHoc
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
            this.button1 = new System.Windows.Forms.Button();
            this.cboDVPT = new System.Windows.Forms.ComboBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numTinChi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numTinChi)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboDVPT
            // 
            this.cboDVPT.FormattingEnabled = true;
            this.cboDVPT.Location = new System.Drawing.Point(132, 81);
            this.cboDVPT.Name = "cboDVPT";
            this.cboDVPT.Size = new System.Drawing.Size(128, 21);
            this.cboDVPT.TabIndex = 20;
            this.cboDVPT.SelectedIndexChanged += new System.EventHandler(this.cboDVPT_SelectedIndexChanged);
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(132, 24);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(128, 20);
            this.txtTenMH.TabIndex = 17;
            this.txtTenMH.TextChanged += new System.EventHandler(this.txtTenMH_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tín chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Đơn Vị Phụ Trách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // numTinChi
            // 
            this.numTinChi.Location = new System.Drawing.Point(132, 142);
            this.numTinChi.Name = "numTinChi";
            this.numTinChi.Size = new System.Drawing.Size(128, 20);
            this.numTinChi.TabIndex = 22;
            // 
            // frmThemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 200);
            this.Controls.Add(this.numTinChi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboDVPT);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThemMonHoc";
            this.Text = "Thêm môn học";
            this.Load += new System.EventHandler(this.frmThemMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTinChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboDVPT;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTinChi;
    }
}