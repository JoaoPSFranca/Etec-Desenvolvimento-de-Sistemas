namespace prj35347_Triangulos
{
    partial class frm35347_Triangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm35347_Triangulo));
            this.gpbEscolha = new System.Windows.Forms.GroupBox();
            this.rdbAreaTri = new System.Windows.Forms.RadioButton();
            this.rdbTipoTri = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.gpbLimpar = new System.Windows.Forms.GroupBox();
            this.cbxLimpar = new System.Windows.Forms.CheckBox();
            this.gpbAreaTri = new System.Windows.Forms.GroupBox();
            this.ltbLista = new System.Windows.Forms.ListBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblAreaTri = new System.Windows.Forms.Label();
            this.txtAreaTri = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.gpbTipoTri = new System.Windows.Forms.GroupBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblTipoTri = new System.Windows.Forms.Label();
            this.txtTipoTri = new System.Windows.Forms.TextBox();
            this.txtValZ = new System.Windows.Forms.TextBox();
            this.txtValY = new System.Windows.Forms.TextBox();
            this.txtValX = new System.Windows.Forms.TextBox();
            this.pbxTipoTri = new System.Windows.Forms.PictureBox();
            this.lblZ = new System.Windows.Forms.Label();
            this.gpbEscolha.SuspendLayout();
            this.gpbLimpar.SuspendLayout();
            this.gpbAreaTri.SuspendLayout();
            this.gpbTipoTri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTipoTri)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbEscolha
            // 
            this.gpbEscolha.Controls.Add(this.rdbAreaTri);
            this.gpbEscolha.Controls.Add(this.rdbTipoTri);
            this.gpbEscolha.Location = new System.Drawing.Point(12, 12);
            this.gpbEscolha.Name = "gpbEscolha";
            this.gpbEscolha.Size = new System.Drawing.Size(248, 48);
            this.gpbEscolha.TabIndex = 0;
            this.gpbEscolha.TabStop = false;
            this.gpbEscolha.Text = "Escolha";
            // 
            // rdbAreaTri
            // 
            this.rdbAreaTri.AutoSize = true;
            this.rdbAreaTri.Location = new System.Drawing.Point(130, 19);
            this.rdbAreaTri.Name = "rdbAreaTri";
            this.rdbAreaTri.Size = new System.Drawing.Size(109, 17);
            this.rdbAreaTri.TabIndex = 86;
            this.rdbAreaTri.Text = "Área do Triângulo";
            this.rdbAreaTri.UseVisualStyleBackColor = true;
            this.rdbAreaTri.CheckedChanged += new System.EventHandler(this.rdbAreaTri_CheckedChanged);
            // 
            // rdbTipoTri
            // 
            this.rdbTipoTri.AutoSize = true;
            this.rdbTipoTri.Location = new System.Drawing.Point(13, 18);
            this.rdbTipoTri.Name = "rdbTipoTri";
            this.rdbTipoTri.Size = new System.Drawing.Size(108, 17);
            this.rdbTipoTri.TabIndex = 86;
            this.rdbTipoTri.Text = "Tipo de Triângulo";
            this.rdbTipoTri.UseVisualStyleBackColor = true;
            this.rdbTipoTri.CheckedChanged += new System.EventHandler(this.rdbTipoTri_CheckedChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalc.BackgroundImage")));
            this.btnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalc.Location = new System.Drawing.Point(12, 203);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(116, 46);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpar.Location = new System.Drawing.Point(133, 203);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 46);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLimparLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimparLista.BackgroundImage")));
            this.btnLimparLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimparLista.Enabled = false;
            this.btnLimparLista.Location = new System.Drawing.Point(255, 203);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(116, 46);
            this.btnLimparLista.TabIndex = 6;
            this.btnLimparLista.Text = "Limpar Lis&ta";
            this.btnLimparLista.UseVisualStyleBackColor = false;
            // 
            // gpbLimpar
            // 
            this.gpbLimpar.Controls.Add(this.cbxLimpar);
            this.gpbLimpar.Location = new System.Drawing.Point(266, 12);
            this.gpbLimpar.Name = "gpbLimpar";
            this.gpbLimpar.Size = new System.Drawing.Size(105, 48);
            this.gpbLimpar.TabIndex = 2;
            this.gpbLimpar.TabStop = false;
            this.gpbLimpar.Text = "Limpar Lista";
            // 
            // cbxLimpar
            // 
            this.cbxLimpar.AutoSize = true;
            this.cbxLimpar.Location = new System.Drawing.Point(13, 18);
            this.cbxLimpar.Name = "cbxLimpar";
            this.cbxLimpar.Size = new System.Drawing.Size(53, 17);
            this.cbxLimpar.TabIndex = 2;
            this.cbxLimpar.TabStop = false;
            this.cbxLimpar.Text = "Ativar";
            this.cbxLimpar.UseVisualStyleBackColor = true;
            this.cbxLimpar.CheckedChanged += new System.EventHandler(this.cbxLimpar_CheckedChanged);
            // 
            // gpbAreaTri
            // 
            this.gpbAreaTri.Controls.Add(this.ltbLista);
            this.gpbAreaTri.Controls.Add(this.lblBase);
            this.gpbAreaTri.Controls.Add(this.lblAltura);
            this.gpbAreaTri.Controls.Add(this.lblAreaTri);
            this.gpbAreaTri.Controls.Add(this.txtAreaTri);
            this.gpbAreaTri.Controls.Add(this.txtAltura);
            this.gpbAreaTri.Controls.Add(this.txtBase);
            this.gpbAreaTri.Location = new System.Drawing.Point(12, 66);
            this.gpbAreaTri.Name = "gpbAreaTri";
            this.gpbAreaTri.Size = new System.Drawing.Size(359, 131);
            this.gpbAreaTri.TabIndex = 1;
            this.gpbAreaTri.TabStop = false;
            this.gpbAreaTri.Text = "Área do Triângulo";
            this.gpbAreaTri.Visible = false;
            // 
            // ltbLista
            // 
            this.ltbLista.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ltbLista.FormattingEnabled = true;
            this.ltbLista.Location = new System.Drawing.Point(199, 13);
            this.ltbLista.Name = "ltbLista";
            this.ltbLista.Size = new System.Drawing.Size(154, 108);
            this.ltbLista.TabIndex = 6;
            // 
            // lblBase
            // 
            this.lblBase.Location = new System.Drawing.Point(10, 17);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(84, 16);
            this.lblBase.TabIndex = 5;
            this.lblBase.Text = "Base";
            this.lblBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAltura
            // 
            this.lblAltura.Location = new System.Drawing.Point(100, 17);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(84, 16);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "Altura";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAreaTri
            // 
            this.lblAreaTri.Location = new System.Drawing.Point(6, 74);
            this.lblAreaTri.Name = "lblAreaTri";
            this.lblAreaTri.Size = new System.Drawing.Size(180, 16);
            this.lblAreaTri.TabIndex = 5;
            this.lblAreaTri.Text = "Área do Triângulo";
            this.lblAreaTri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAreaTri
            // 
            this.txtAreaTri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAreaTri.Location = new System.Drawing.Point(6, 93);
            this.txtAreaTri.Name = "txtAreaTri";
            this.txtAreaTri.ReadOnly = true;
            this.txtAreaTri.Size = new System.Drawing.Size(180, 20);
            this.txtAreaTri.TabIndex = 0;
            this.txtAreaTri.TabStop = false;
            this.txtAreaTri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAltura.Location = new System.Drawing.Point(100, 36);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(84, 20);
            this.txtAltura.TabIndex = 4;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBase
            // 
            this.txtBase.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtBase.Location = new System.Drawing.Point(10, 36);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(84, 20);
            this.txtBase.TabIndex = 3;
            this.txtBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpbTipoTri
            // 
            this.gpbTipoTri.Controls.Add(this.lblX);
            this.gpbTipoTri.Controls.Add(this.lblY);
            this.gpbTipoTri.Controls.Add(this.lblTipoTri);
            this.gpbTipoTri.Controls.Add(this.txtTipoTri);
            this.gpbTipoTri.Controls.Add(this.txtValZ);
            this.gpbTipoTri.Controls.Add(this.txtValY);
            this.gpbTipoTri.Controls.Add(this.txtValX);
            this.gpbTipoTri.Controls.Add(this.pbxTipoTri);
            this.gpbTipoTri.Controls.Add(this.lblZ);
            this.gpbTipoTri.Location = new System.Drawing.Point(12, 66);
            this.gpbTipoTri.Name = "gpbTipoTri";
            this.gpbTipoTri.Size = new System.Drawing.Size(359, 131);
            this.gpbTipoTri.TabIndex = 9;
            this.gpbTipoTri.TabStop = false;
            this.gpbTipoTri.Text = "Tipo de Triângulo";
            this.gpbTipoTri.Visible = false;
            // 
            // lblX
            // 
            this.lblX.Location = new System.Drawing.Point(6, 17);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(56, 16);
            this.lblX.TabIndex = 5;
            this.lblX.Text = " X";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblY
            // 
            this.lblY.Location = new System.Drawing.Point(68, 17);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(56, 16);
            this.lblY.TabIndex = 5;
            this.lblY.Text = " Y";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipoTri
            // 
            this.lblTipoTri.Location = new System.Drawing.Point(6, 74);
            this.lblTipoTri.Name = "lblTipoTri";
            this.lblTipoTri.Size = new System.Drawing.Size(180, 16);
            this.lblTipoTri.TabIndex = 5;
            this.lblTipoTri.Text = " Tipo de Triângulo";
            this.lblTipoTri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTipoTri
            // 
            this.txtTipoTri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTipoTri.Location = new System.Drawing.Point(6, 93);
            this.txtTipoTri.Name = "txtTipoTri";
            this.txtTipoTri.ReadOnly = true;
            this.txtTipoTri.Size = new System.Drawing.Size(180, 20);
            this.txtTipoTri.TabIndex = 3;
            this.txtTipoTri.TabStop = false;
            this.txtTipoTri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValZ
            // 
            this.txtValZ.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtValZ.Location = new System.Drawing.Point(130, 36);
            this.txtValZ.Name = "txtValZ";
            this.txtValZ.Size = new System.Drawing.Size(56, 20);
            this.txtValZ.TabIndex = 2;
            this.txtValZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValY
            // 
            this.txtValY.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtValY.Location = new System.Drawing.Point(68, 36);
            this.txtValY.Name = "txtValY";
            this.txtValY.Size = new System.Drawing.Size(56, 20);
            this.txtValY.TabIndex = 1;
            this.txtValY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValX
            // 
            this.txtValX.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtValX.Location = new System.Drawing.Point(6, 36);
            this.txtValX.Name = "txtValX";
            this.txtValX.Size = new System.Drawing.Size(56, 20);
            this.txtValX.TabIndex = 0;
            this.txtValX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbxTipoTri
            // 
            this.pbxTipoTri.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pbxTipoTri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxTipoTri.Location = new System.Drawing.Point(199, 13);
            this.pbxTipoTri.Name = "pbxTipoTri";
            this.pbxTipoTri.Size = new System.Drawing.Size(154, 112);
            this.pbxTipoTri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTipoTri.TabIndex = 2;
            this.pbxTipoTri.TabStop = false;
            // 
            // lblZ
            // 
            this.lblZ.Location = new System.Drawing.Point(130, 17);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(56, 16);
            this.lblZ.TabIndex = 5;
            this.lblZ.Text = " Z";
            this.lblZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm35347_Triangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(384, 259);
            this.Controls.Add(this.gpbTipoTri);
            this.Controls.Add(this.gpbAreaTri);
            this.Controls.Add(this.gpbLimpar);
            this.Controls.Add(this.btnLimparLista);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.gpbEscolha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_Triangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triângulos";
            this.gpbEscolha.ResumeLayout(false);
            this.gpbEscolha.PerformLayout();
            this.gpbLimpar.ResumeLayout(false);
            this.gpbLimpar.PerformLayout();
            this.gpbAreaTri.ResumeLayout(false);
            this.gpbAreaTri.PerformLayout();
            this.gpbTipoTri.ResumeLayout(false);
            this.gpbTipoTri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTipoTri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEscolha;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.RadioButton rdbAreaTri;
        private System.Windows.Forms.RadioButton rdbTipoTri;
        private System.Windows.Forms.GroupBox gpbLimpar;
        private System.Windows.Forms.CheckBox cbxLimpar;
        private System.Windows.Forms.GroupBox gpbAreaTri;
        private System.Windows.Forms.ListBox ltbLista;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblAreaTri;
        private System.Windows.Forms.TextBox txtAreaTri;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.GroupBox gpbTipoTri;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblTipoTri;
        private System.Windows.Forms.TextBox txtTipoTri;
        private System.Windows.Forms.TextBox txtValZ;
        private System.Windows.Forms.TextBox txtValY;
        private System.Windows.Forms.TextBox txtValX;
        private System.Windows.Forms.PictureBox pbxTipoTri;
        private System.Windows.Forms.Label lblZ;
    }
}

