namespace prj35347_Lista01_EX_01
{
    partial class frm35347_lista01_exerc01
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.BtnSoma = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtSoma = new System.Windows.Forms.TextBox();
            this.btnSubtrai = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1º Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "2º Valor";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(27, 33);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(68, 20);
            this.txtValor1.TabIndex = 0;
            this.txtValor1.TextChanged += new System.EventHandler(this.txtValor1_TextChanged);
            // 
            // BtnSoma
            // 
            this.BtnSoma.Location = new System.Drawing.Point(27, 74);
            this.BtnSoma.Name = "BtnSoma";
            this.BtnSoma.Size = new System.Drawing.Size(68, 34);
            this.BtnSoma.TabIndex = 3;
            this.BtnSoma.Text = "&Soma";
            this.BtnSoma.UseVisualStyleBackColor = true;
            this.BtnSoma.Click += new System.EventHandler(this.BtnSoma_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(101, 139);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(68, 34);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(101, 33);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(68, 20);
            this.txtValor2.TabIndex = 1;
            this.txtValor2.TextChanged += new System.EventHandler(this.txtValor2_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(175, 139);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(68, 34);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtSoma
            // 
            this.txtSoma.Location = new System.Drawing.Point(175, 33);
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.ReadOnly = true;
            this.txtSoma.Size = new System.Drawing.Size(68, 20);
            this.txtSoma.TabIndex = 2;
            this.txtSoma.TabStop = false;
            // 
            // btnSubtrai
            // 
            this.btnSubtrai.Location = new System.Drawing.Point(101, 76);
            this.btnSubtrai.Name = "btnSubtrai";
            this.btnSubtrai.Size = new System.Drawing.Size(68, 32);
            this.btnSubtrai.TabIndex = 4;
            this.btnSubtrai.Text = "Su&btrai";
            this.btnSubtrai.UseVisualStyleBackColor = true;
            this.btnSubtrai.Click += new System.EventHandler(this.btnSubtrai_Click);
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.Location = new System.Drawing.Point(175, 76);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(68, 32);
            this.btnMultiplica.TabIndex = 5;
            this.btnMultiplica.Text = "&Multiplica";
            this.btnMultiplica.UseVisualStyleBackColor = true;
            this.btnMultiplica.Click += new System.EventHandler(this.btnMultiplica_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(27, 139);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(68, 32);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "&Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // lblRes
            // 
            this.lblRes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(27, 188);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(216, 72);
            this.lblRes.TabIndex = 1;
            this.lblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm35347_lista01_exerc01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 269);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiplica);
            this.Controls.Add(this.btnSubtrai);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.BtnSoma);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_lista01_exerc01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de 2 valores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Button BtnSoma;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtSoma;
        private System.Windows.Forms.Button btnSubtrai;
        private System.Windows.Forms.Button btnMultiplica;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lblRes;
    }
}

