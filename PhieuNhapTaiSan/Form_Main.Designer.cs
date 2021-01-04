namespace PhieuNhapTaiSan
{
    partial class Form_Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnThanhLy = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnHoaDon);
            this.panel1.Controls.Add(this.btnThanhLy);
            this.panel1.Controls.Add(this.btnNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(164, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 349);
            this.panel1.TabIndex = 4;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnHoaDon.Location = new System.Drawing.Point(254, 94);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(185, 69);
            this.btnHoaDon.TabIndex = 3;
            this.btnHoaDon.Text = "SỬA PHIẾU NHẬP MUA";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnThanhLy
            // 
            this.btnThanhLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnThanhLy.Location = new System.Drawing.Point(25, 196);
            this.btnThanhLy.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhLy.Name = "btnThanhLy";
            this.btnThanhLy.Size = new System.Drawing.Size(185, 69);
            this.btnThanhLy.TabIndex = 2;
            this.btnThanhLy.Text = "THANH LÝ TÀI SẢN";
            this.btnThanhLy.UseVisualStyleBackColor = true;
            this.btnThanhLy.Click += new System.EventHandler(this.btnThanhLy_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnNhap.Location = new System.Drawing.Point(25, 94);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(185, 69);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "NHẬP TÀI SẢN";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(158, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÀI SẢN";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.Location = new System.Drawing.Point(254, 196);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 69);
            this.button1.TabIndex = 4;
            this.button1.Text = "KHẤU HAO TÀI SẢN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnThanhLy;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}