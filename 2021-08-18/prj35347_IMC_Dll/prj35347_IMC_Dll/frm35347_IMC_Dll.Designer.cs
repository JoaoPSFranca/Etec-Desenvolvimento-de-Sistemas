namespace prj35347_IMC_Dll
{
    partial class frm35347_IMC_Dll
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
            this.lblIMC = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIMC
            // 
            this.lblIMC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(247, 10);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(100, 23);
            this.lblIMC.TabIndex = 12;
            this.lblIMC.Text = "IMC:";
            this.lblIMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIMC
            // 
            this.txtIMC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtIMC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMC.Location = new System.Drawing.Point(247, 36);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.ReadOnly = true;
            this.txtIMC.Size = new System.Drawing.Size(100, 22);
            this.txtIMC.TabIndex = 10;
            this.txtIMC.TabStop = false;
            this.txtIMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAltura
            // 
            this.lblAltura.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(141, 10);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(100, 23);
            this.lblAltura.TabIndex = 11;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAltura.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(141, 36);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 7;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(247, 158);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 40);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(32, 61);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(315, 94);
            this.lblResposta.TabIndex = 9;
            this.lblResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeso
            // 
            this.lblPeso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(35, 10);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(100, 23);
            this.lblPeso.TabIndex = 8;
            this.lblPeso.Text = "Peso:";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(141, 158);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPeso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(35, 36);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 6;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(35, 158);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 40);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frm35347_IMC_Dll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(378, 208);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.btnCalc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_IMC_Dll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC com Dll";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm35347_IMC_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnCalc;
    }
}

