namespace prj35347_CPF
{
    partial class frm35347_CPF
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
            this.lblInserir = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.mtxtNumeros = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblInserir
            // 
            this.lblInserir.Location = new System.Drawing.Point(12, 9);
            this.lblInserir.Name = "lblInserir";
            this.lblInserir.Size = new System.Drawing.Size(206, 23);
            this.lblInserir.TabIndex = 0;
            this.lblInserir.Text = "Insira o Número do CPF:";
            this.lblInserir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Firebrick;
            this.lblResultado.Location = new System.Drawing.Point(12, 58);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(206, 61);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpar.Location = new System.Drawing.Point(118, 122);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalc.Location = new System.Drawing.Point(12, 122);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 30);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // mtxtNumeros
            // 
            this.mtxtNumeros.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mtxtNumeros.Location = new System.Drawing.Point(12, 35);
            this.mtxtNumeros.Mask = "000.000.000-00";
            this.mtxtNumeros.Name = "mtxtNumeros";
            this.mtxtNumeros.Size = new System.Drawing.Size(206, 20);
            this.mtxtNumeros.TabIndex = 1;
            this.mtxtNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtNumeros.TextChanged += new System.EventHandler(this.mtxtNumeros_TextChanged);
            // 
            // frm35347_CPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(233, 168);
            this.Controls.Add(this.mtxtNumeros);
            this.Controls.Add(this.lblInserir);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_CPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInserir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.MaskedTextBox mtxtNumeros;
    }
}

