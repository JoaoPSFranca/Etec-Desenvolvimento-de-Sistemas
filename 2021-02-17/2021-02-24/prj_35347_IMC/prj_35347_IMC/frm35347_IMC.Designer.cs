namespace prj_35347_IMC
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblResp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(20, 38);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(51, 14);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso (kg)";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(12, 54);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(69, 20);
            this.txtPeso.TabIndex = 0;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(92, 38);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(64, 14);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura (mts)";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(87, 54);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(69, 20);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(181, 38);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(34, 14);
            this.lblIMC.TabIndex = 0;
            this.lblIMC.Text = "I M C";
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(162, 54);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.ReadOnly = true;
            this.txtIMC.Size = new System.Drawing.Size(69, 20);
            this.txtIMC.TabIndex = 1;
            this.txtIMC.TabStop = false;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 179);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(69, 29);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(87, 179);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(69, 29);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(162, 179);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(69, 29);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblResp
            // 
            this.lblResp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(12, 77);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(219, 99);
            this.lblResp.TabIndex = 0;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm35347_IMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 224);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.lblPeso);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_IMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo Índice da Massa Corporal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblResp;
    }
}

