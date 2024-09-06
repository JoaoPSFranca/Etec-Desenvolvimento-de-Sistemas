namespace prj35347_Palindromo
{
    partial class frm35347_Palindromo
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
            this.txtPalio = new System.Windows.Forms.TextBox();
            this.btnPalio = new System.Windows.Forms.Button();
            this.lblPalio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalio
            // 
            this.txtPalio.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalio.Location = new System.Drawing.Point(13, 14);
            this.txtPalio.Name = "txtPalio";
            this.txtPalio.Size = new System.Drawing.Size(192, 25);
            this.txtPalio.TabIndex = 0;
            this.txtPalio.TextChanged += new System.EventHandler(this.txtPalio_TextChanged);
            // 
            // btnPalio
            // 
            this.btnPalio.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPalio.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalio.Location = new System.Drawing.Point(211, 12);
            this.btnPalio.Name = "btnPalio";
            this.btnPalio.Size = new System.Drawing.Size(75, 27);
            this.btnPalio.TabIndex = 1;
            this.btnPalio.Text = "&Verificar";
            this.btnPalio.UseVisualStyleBackColor = false;
            this.btnPalio.Click += new System.EventHandler(this.btnPalio_Click);
            // 
            // lblPalio
            // 
            this.lblPalio.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalio.Location = new System.Drawing.Point(13, 49);
            this.lblPalio.Name = "lblPalio";
            this.lblPalio.Size = new System.Drawing.Size(273, 43);
            this.lblPalio.TabIndex = 2;
            this.lblPalio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm35347_Palindromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(298, 110);
            this.Controls.Add(this.lblPalio);
            this.Controls.Add(this.btnPalio);
            this.Controls.Add(this.txtPalio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_Palindromo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palíndromos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalio;
        private System.Windows.Forms.Button btnPalio;
        private System.Windows.Forms.Label lblPalio;
    }
}

