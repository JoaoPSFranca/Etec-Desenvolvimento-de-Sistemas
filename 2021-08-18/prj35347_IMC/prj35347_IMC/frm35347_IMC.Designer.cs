namespace prj35347_IMC
{
    partial class frm35347_IMC
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(31, 157);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 40);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPeso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(31, 35);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 0;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPeso
            // 
            this.lblPeso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(31, 9);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(100, 23);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso:";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(137, 157);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAltura.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(137, 35);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAltura
            // 
            this.lblAltura.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(137, 9);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(100, 23);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(243, 157);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 40);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtIMC
            // 
            this.txtIMC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtIMC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMC.Location = new System.Drawing.Point(243, 35);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.ReadOnly = true;
            this.txtIMC.Size = new System.Drawing.Size(100, 22);
            this.txtIMC.TabIndex = 2;
            this.txtIMC.TabStop = false;
            this.txtIMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIMC
            // 
            this.lblIMC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(243, 9);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(100, 23);
            this.lblIMC.TabIndex = 2;
            this.lblIMC.Text = "IMC:";
            this.lblIMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResposta
            // 
            this.lblResposta.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(28, 60);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(315, 94);
            this.lblResposta.TabIndex = 2;
            this.lblResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm35347_IMC
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
            this.Name = "frm35347_IMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC com a Classe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm35347_IMC_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblResposta;
    }
}

