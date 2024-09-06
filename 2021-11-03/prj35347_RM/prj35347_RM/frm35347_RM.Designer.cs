namespace prj35347_RM
{
    partial class frm35347_RM
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
            this.lblRM = new System.Windows.Forms.Label();
            this.lblNG = new System.Windows.Forms.Label();
            this.txtNG = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtRM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRM
            // 
            this.lblRM.Location = new System.Drawing.Point(12, 9);
            this.lblRM.Name = "lblRM";
            this.lblRM.Size = new System.Drawing.Size(100, 23);
            this.lblRM.TabIndex = 0;
            this.lblRM.Text = "RM:";
            this.lblRM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNG
            // 
            this.lblNG.Location = new System.Drawing.Point(118, 9);
            this.lblNG.Name = "lblNG";
            this.lblNG.Size = new System.Drawing.Size(100, 23);
            this.lblNG.TabIndex = 0;
            this.lblNG.Text = "Número Gerado:";
            this.lblNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNG
            // 
            this.txtNG.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNG.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNG.Location = new System.Drawing.Point(122, 35);
            this.txtNG.Name = "txtNG";
            this.txtNG.ReadOnly = true;
            this.txtNG.Size = new System.Drawing.Size(100, 29);
            this.txtNG.TabIndex = 1;
            this.txtNG.TabStop = false;
            this.txtNG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalc.Enabled = false;
            this.btnCalc.Location = new System.Drawing.Point(14, 82);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 38);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Location = new System.Drawing.Point(121, 82);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 38);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtRM
            // 
            this.txtRM.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtRM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRM.Location = new System.Drawing.Point(12, 35);
            this.txtRM.MaxLength = 5;
            this.txtRM.Name = "txtRM";
            this.txtRM.Size = new System.Drawing.Size(100, 29);
            this.txtRM.TabIndex = 0;
            this.txtRM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRM.TextChanged += new System.EventHandler(this.txtRM_TextChanged);
            // 
            // frm35347_RM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(238, 137);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtRM);
            this.Controls.Add(this.txtNG);
            this.Controls.Add(this.lblNG);
            this.Controls.Add(this.lblRM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_RM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nome: João, Franca  RM: 35347";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm35347_RM_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRM;
        private System.Windows.Forms.Label lblNG;
        private System.Windows.Forms.TextBox txtNG;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtRM;
    }
}

