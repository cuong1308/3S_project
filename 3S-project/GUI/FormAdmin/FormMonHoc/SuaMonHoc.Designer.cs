
namespace _3S_project.GUI.FormAdmin.FormMonHoc
{
    partial class frmSuaMonHoc
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
            this.button1 = new System.Windows.Forms.Button();
            this.cboDVPT = new System.Windows.Forms.ComboBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bsSuaMH = new System.Windows.Forms.BindingSource(this.components);
            this.numTinChi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuaMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTinChi)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboDVPT
            // 
            this.cboDVPT.FormattingEnabled = true;
            this.cboDVPT.Location = new System.Drawing.Point(124, 82);
            this.cboDVPT.Name = "cboDVPT";
            this.cboDVPT.Size = new System.Drawing.Size(134, 21);
            this.cboDVPT.TabIndex = 19;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(124, 26);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(134, 20);
            this.txtTenMH.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tín chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Đơn Vị Phụ Trách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tên môn học";
            // 
            // numTinChi
            // 
            this.numTinChi.Location = new System.Drawing.Point(124, 137);
            this.numTinChi.Name = "numTinChi";
            this.numTinChi.Size = new System.Drawing.Size(134, 20);
            this.numTinChi.TabIndex = 23;
            // 
            // frmSuaMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 201);
            this.Controls.Add(this.numTinChi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboDVPT);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "frmSuaMonHoc";
            this.Text = "Sửa môn học";
            this.Load += new System.EventHandler(this.frmSuaMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsSuaMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTinChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboDVPT;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bsSuaMH;
        private System.Windows.Forms.NumericUpDown numTinChi;
    }
}