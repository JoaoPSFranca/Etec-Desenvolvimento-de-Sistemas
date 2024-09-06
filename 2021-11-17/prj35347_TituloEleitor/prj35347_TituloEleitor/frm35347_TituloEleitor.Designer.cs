namespace prj35347_TituloEleitor
{
    partial class frm35347_TituloEleitor
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
            this.lblCD = new System.Windows.Forms.Label();
            this.txtCD = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblValidade = new System.Windows.Forms.Label();
            this.txtValidade = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCD
            // 
            this.lblCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCD.Location = new System.Drawing.Point(13, 4);
            this.lblCD.Name = "lblCD";
            this.lblCD.Size = new System.Drawing.Size(241, 23);
            this.lblCD.TabIndex = 0;
            this.lblCD.Text = "Insira o número:";
            this.lblCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCD
            // 
            this.txtCD.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCD.Location = new System.Drawing.Point(13, 30);
            this.txtCD.MaxLength = 12;
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(241, 29);
            this.txtCD.TabIndex = 0;
            this.txtCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCD.TextChanged += new System.EventHandler(this.txtCD_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalc.Enabled = false;
            this.btnCalc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(54, 75);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(160, 40);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "&Verificar";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblValidade
            // 
            this.lblValidade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.Location = new System.Drawing.Point(12, 130);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(241, 23);
            this.lblValidade.TabIndex = 0;
            this.lblValidade.Text = "Verificação:";
            this.lblValidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValidade
            // 
            this.txtValidade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtValidade.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidade.Location = new System.Drawing.Point(12, 156);
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.ReadOnly = true;
            this.txtValidade.Size = new System.Drawing.Size(241, 29);
            this.txtValidade.TabIndex = 2;
            this.txtValidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLocal
            // 
            this.lblLocal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(12, 204);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(241, 23);
            this.lblLocal.TabIndex = 0;
            this.lblLocal.Text = "Local:";
            this.lblLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLocal
            // 
            this.txtLocal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtLocal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.Location = new System.Drawing.Point(12, 230);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.ReadOnly = true;
            this.txtLocal.Size = new System.Drawing.Size(241, 29);
            this.txtLocal.TabIndex = 3;
            this.txtLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(53, 277);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 40);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frm35347_TituloEleitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(266, 334);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtValidade);
            this.Controls.Add(this.txtCD);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.lblCD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_TituloEleitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular TE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm35347_TituloEleitor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCD;
        private System.Windows.Forms.TextBox txtCD;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.TextBox txtValidade;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Button btnLimpar;
    }
}

