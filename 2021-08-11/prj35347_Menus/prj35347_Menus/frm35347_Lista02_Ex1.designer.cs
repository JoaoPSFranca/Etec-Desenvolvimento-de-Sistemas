namespace prj35347_Lista02_Ex1
{
    partial class frm35347_Lista02_Ex1
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
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.lblBinario = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDecimal
            // 
            this.txtDecimal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDecimal.Location = new System.Drawing.Point(12, 44);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(108, 20);
            this.txtDecimal.TabIndex = 0;
            this.txtDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDecimal.TextChanged += new System.EventHandler(this.txtDecimal_TextChanged);
            // 
            // lblDecimal
            // 
            this.lblDecimal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDecimal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimal.Location = new System.Drawing.Point(12, 9);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(108, 32);
            this.lblDecimal.TabIndex = 1;
            this.lblDecimal.Text = "Decimal:";
            this.lblDecimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBinario
            // 
            this.txtBinario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBinario.Location = new System.Drawing.Point(140, 44);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.ReadOnly = true;
            this.txtBinario.Size = new System.Drawing.Size(108, 20);
            this.txtBinario.TabIndex = 0;
            this.txtBinario.TabStop = false;
            this.txtBinario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBinario
            // 
            this.lblBinario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBinario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinario.Location = new System.Drawing.Point(140, 9);
            this.lblBinario.Name = "lblBinario";
            this.lblBinario.Size = new System.Drawing.Size(108, 32);
            this.lblBinario.TabIndex = 1;
            this.lblBinario.Text = "Binário:";
            this.lblBinario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResp
            // 
            this.lblResp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(13, 67);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(236, 113);
            this.lblResp.TabIndex = 2;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalc.Location = new System.Drawing.Point(11, 183);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpar.Location = new System.Drawing.Point(92, 183);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFechar.Location = new System.Drawing.Point(173, 183);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frm35347_Lista02_Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(260, 218);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.lblBinario);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.txtDecimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_Lista02_Ex1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decimal para Binário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.Label lblBinario;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}

