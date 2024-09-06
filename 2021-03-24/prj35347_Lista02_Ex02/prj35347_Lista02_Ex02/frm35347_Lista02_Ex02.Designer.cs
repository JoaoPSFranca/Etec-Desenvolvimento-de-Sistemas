namespace prj35347_Lista02_Ex02
{
    partial class frm35347_Lista02_Ex02
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
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.lblBinario = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(12, 48);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(100, 20);
            this.txtBinario.TabIndex = 0;
            this.txtBinario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBinario.TextChanged += new System.EventHandler(this.txtBinario_TextChanged);
            // 
            // lblBinario
            // 
            this.lblBinario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinario.Location = new System.Drawing.Point(12, 9);
            this.lblBinario.Name = "lblBinario";
            this.lblBinario.Size = new System.Drawing.Size(100, 36);
            this.lblBinario.TabIndex = 1;
            this.lblBinario.Text = "Binário:";
            this.lblBinario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(149, 48);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.ReadOnly = true;
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 0;
            this.txtDecimal.TabStop = false;
            this.txtDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDecimal
            // 
            this.lblDecimal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimal.Location = new System.Drawing.Point(149, 9);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(100, 36);
            this.lblDecimal.TabIndex = 1;
            this.lblDecimal.Text = "Decimal:";
            this.lblDecimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResp
            // 
            this.lblResp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(12, 71);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(237, 131);
            this.lblResp.TabIndex = 1;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 205);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(93, 205);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(174, 205);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frm35347_Lista02_Ex02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(262, 242);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.lblBinario);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBinario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_Lista02_Ex02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binário para Decimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.Label lblBinario;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}

