namespace PhieuNhapTaiSan
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSTS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tkdu = new System.Windows.Forms.Label();
            this.txtTkdu = new System.Windows.Forms.TextBox();
            this.txtPSO = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "so tien";
            // 
            // txtst
            // 
            this.txtst.Location = new System.Drawing.Point(417, 35);
            this.txtst.Margin = new System.Windows.Forms.Padding(2);
            this.txtst.Name = "txtst";
            this.txtst.Size = new System.Drawing.Size(76, 20);
            this.txtst.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MSTS";
            // 
            // txtMSTS
            // 
            this.txtMSTS.Location = new System.Drawing.Point(255, 35);
            this.txtMSTS.Margin = new System.Windows.Forms.Padding(2);
            this.txtMSTS.Name = "txtMSTS";
            this.txtMSTS.Size = new System.Drawing.Size(76, 20);
            this.txtMSTS.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "pso";
            // 
            // tkdu
            // 
            this.tkdu.AutoSize = true;
            this.tkdu.Location = new System.Drawing.Point(34, 32);
            this.tkdu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tkdu.Name = "tkdu";
            this.tkdu.Size = new System.Drawing.Size(28, 13);
            this.tkdu.TabIndex = 0;
            this.tkdu.Text = "tkdu";
            // 
            // txtTkdu
            // 
            this.txtTkdu.Location = new System.Drawing.Point(84, 32);
            this.txtTkdu.Margin = new System.Windows.Forms.Padding(2);
            this.txtTkdu.Name = "txtTkdu";
            this.txtTkdu.Size = new System.Drawing.Size(76, 20);
            this.txtTkdu.TabIndex = 1;
            // 
            // txtPSO
            // 
            this.txtPSO.Location = new System.Drawing.Point(84, 81);
            this.txtPSO.Margin = new System.Windows.Forms.Padding(2);
            this.txtPSO.Name = "txtPSO";
            this.txtPSO.Size = new System.Drawing.Size(76, 20);
            this.txtPSO.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(210, 188);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 19);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtPSO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtst);
            this.Controls.Add(this.txtMSTS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTkdu);
            this.Controls.Add(this.tkdu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSTS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tkdu;
        private System.Windows.Forms.TextBox txtTkdu;
        private System.Windows.Forms.TextBox txtPSO;
        private System.Windows.Forms.Button btnThem;
    }
}