namespace prj35347_Acad
{
    partial class frm35347_Acad
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
            this.gpbEntrada = new System.Windows.Forms.GroupBox();
            this.mtxtMatricula = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.gpbPeriodo = new System.Windows.Forms.GroupBox();
            this.rdbNoite = new System.Windows.Forms.RadioButton();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.rdbManha = new System.Windows.Forms.RadioButton();
            this.gpbSemana = new System.Windows.Forms.GroupBox();
            this.cbxSex = new System.Windows.Forms.CheckBox();
            this.cbxTer = new System.Windows.Forms.CheckBox();
            this.cbxSab = new System.Windows.Forms.CheckBox();
            this.cbxQua = new System.Windows.Forms.CheckBox();
            this.cbxQui = new System.Windows.Forms.CheckBox();
            this.cbxSeg = new System.Windows.Forms.CheckBox();
            this.gpbModalidade = new System.Windows.Forms.GroupBox();
            this.ltbModalidade = new System.Windows.Forms.ListBox();
            this.gpbEscolhidas = new System.Windows.Forms.GroupBox();
            this.ltbEscolhidas = new System.Windows.Forms.ListBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblVal = new System.Windows.Forms.Label();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.gpbEntrada.SuspendLayout();
            this.gpbPeriodo.SuspendLayout();
            this.gpbSemana.SuspendLayout();
            this.gpbModalidade.SuspendLayout();
            this.gpbEscolhidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbEntrada
            // 
            this.gpbEntrada.Controls.Add(this.mtxtMatricula);
            this.gpbEntrada.Controls.Add(this.txtNome);
            this.gpbEntrada.Controls.Add(this.lblNome);
            this.gpbEntrada.Controls.Add(this.lblMatricula);
            this.gpbEntrada.Location = new System.Drawing.Point(12, 12);
            this.gpbEntrada.Name = "gpbEntrada";
            this.gpbEntrada.Size = new System.Drawing.Size(348, 81);
            this.gpbEntrada.TabIndex = 0;
            this.gpbEntrada.TabStop = false;
            // 
            // mtxtMatricula
            // 
            this.mtxtMatricula.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mtxtMatricula.Location = new System.Drawing.Point(112, 19);
            this.mtxtMatricula.Mask = "0000";
            this.mtxtMatricula.Name = "mtxtMatricula";
            this.mtxtMatricula.PromptChar = ' ';
            this.mtxtMatricula.Size = new System.Drawing.Size(100, 20);
            this.mtxtMatricula.TabIndex = 0;
            this.mtxtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtMatricula.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtMatricula_MaskInputRejected);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNome.Location = new System.Drawing.Point(112, 50);
            this.txtNome.MaxLength = 35;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(6, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 23);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatricula
            // 
            this.lblMatricula.Location = new System.Drawing.Point(6, 16);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(100, 23);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            this.lblMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbPeriodo
            // 
            this.gpbPeriodo.Controls.Add(this.rdbNoite);
            this.gpbPeriodo.Controls.Add(this.rdbTarde);
            this.gpbPeriodo.Controls.Add(this.rdbManha);
            this.gpbPeriodo.Location = new System.Drawing.Point(12, 99);
            this.gpbPeriodo.Name = "gpbPeriodo";
            this.gpbPeriodo.Size = new System.Drawing.Size(106, 92);
            this.gpbPeriodo.TabIndex = 1;
            this.gpbPeriodo.TabStop = false;
            this.gpbPeriodo.Text = " Período ";
            // 
            // rdbNoite
            // 
            this.rdbNoite.AutoSize = true;
            this.rdbNoite.Location = new System.Drawing.Point(6, 65);
            this.rdbNoite.Name = "rdbNoite";
            this.rdbNoite.Size = new System.Drawing.Size(50, 17);
            this.rdbNoite.TabIndex = 2;
            this.rdbNoite.TabStop = true;
            this.rdbNoite.Text = "Noite";
            this.rdbNoite.UseVisualStyleBackColor = true;
            this.rdbNoite.CheckedChanged += new System.EventHandler(this.rdbNoite_CheckedChanged);
            // 
            // rdbTarde
            // 
            this.rdbTarde.AutoSize = true;
            this.rdbTarde.Location = new System.Drawing.Point(6, 42);
            this.rdbTarde.Name = "rdbTarde";
            this.rdbTarde.Size = new System.Drawing.Size(53, 17);
            this.rdbTarde.TabIndex = 1;
            this.rdbTarde.TabStop = true;
            this.rdbTarde.Text = "Tarde";
            this.rdbTarde.UseVisualStyleBackColor = true;
            this.rdbTarde.CheckedChanged += new System.EventHandler(this.rdbTarde_CheckedChanged);
            // 
            // rdbManha
            // 
            this.rdbManha.AutoSize = true;
            this.rdbManha.Location = new System.Drawing.Point(6, 19);
            this.rdbManha.Name = "rdbManha";
            this.rdbManha.Size = new System.Drawing.Size(58, 17);
            this.rdbManha.TabIndex = 0;
            this.rdbManha.TabStop = true;
            this.rdbManha.Text = "Manhã";
            this.rdbManha.UseVisualStyleBackColor = true;
            this.rdbManha.CheckedChanged += new System.EventHandler(this.rdbManha_CheckedChanged);
            // 
            // gpbSemana
            // 
            this.gpbSemana.Controls.Add(this.cbxSex);
            this.gpbSemana.Controls.Add(this.cbxTer);
            this.gpbSemana.Controls.Add(this.cbxSab);
            this.gpbSemana.Controls.Add(this.cbxQua);
            this.gpbSemana.Controls.Add(this.cbxQui);
            this.gpbSemana.Controls.Add(this.cbxSeg);
            this.gpbSemana.Location = new System.Drawing.Point(124, 99);
            this.gpbSemana.Name = "gpbSemana";
            this.gpbSemana.Size = new System.Drawing.Size(236, 92);
            this.gpbSemana.TabIndex = 2;
            this.gpbSemana.TabStop = false;
            this.gpbSemana.Text = " Dias da Semana ";
            // 
            // cbxSex
            // 
            this.cbxSex.AutoSize = true;
            this.cbxSex.Location = new System.Drawing.Point(86, 57);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(53, 17);
            this.cbxSex.TabIndex = 4;
            this.cbxSex.Text = "Sexta";
            this.cbxSex.UseVisualStyleBackColor = true;
            this.cbxSex.CheckedChanged += new System.EventHandler(this.cbxSex_CheckedChanged);
            // 
            // cbxTer
            // 
            this.cbxTer.AutoSize = true;
            this.cbxTer.Location = new System.Drawing.Point(86, 25);
            this.cbxTer.Name = "cbxTer";
            this.cbxTer.Size = new System.Drawing.Size(54, 17);
            this.cbxTer.TabIndex = 1;
            this.cbxTer.Text = "Terça";
            this.cbxTer.UseVisualStyleBackColor = true;
            this.cbxTer.CheckedChanged += new System.EventHandler(this.cbxTer_CheckedChanged);
            // 
            // cbxSab
            // 
            this.cbxSab.AutoSize = true;
            this.cbxSab.Location = new System.Drawing.Point(161, 56);
            this.cbxSab.Name = "cbxSab";
            this.cbxSab.Size = new System.Drawing.Size(63, 17);
            this.cbxSab.TabIndex = 5;
            this.cbxSab.Text = "Sábado";
            this.cbxSab.UseVisualStyleBackColor = true;
            this.cbxSab.CheckedChanged += new System.EventHandler(this.cbxSab_CheckedChanged);
            // 
            // cbxQua
            // 
            this.cbxQua.AutoSize = true;
            this.cbxQua.Location = new System.Drawing.Point(161, 24);
            this.cbxQua.Name = "cbxQua";
            this.cbxQua.Size = new System.Drawing.Size(58, 17);
            this.cbxQua.TabIndex = 2;
            this.cbxQua.Text = "Quarta";
            this.cbxQua.UseVisualStyleBackColor = true;
            this.cbxQua.CheckedChanged += new System.EventHandler(this.cbxQua_CheckedChanged);
            // 
            // cbxQui
            // 
            this.cbxQui.AutoSize = true;
            this.cbxQui.Location = new System.Drawing.Point(11, 57);
            this.cbxQui.Name = "cbxQui";
            this.cbxQui.Size = new System.Drawing.Size(57, 17);
            this.cbxQui.TabIndex = 3;
            this.cbxQui.Text = "Quinta";
            this.cbxQui.UseVisualStyleBackColor = true;
            this.cbxQui.CheckedChanged += new System.EventHandler(this.cbxQui_CheckedChanged);
            // 
            // cbxSeg
            // 
            this.cbxSeg.AutoSize = true;
            this.cbxSeg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbxSeg.Location = new System.Drawing.Point(11, 25);
            this.cbxSeg.Name = "cbxSeg";
            this.cbxSeg.Size = new System.Drawing.Size(69, 17);
            this.cbxSeg.TabIndex = 0;
            this.cbxSeg.Text = "Segunda";
            this.cbxSeg.UseVisualStyleBackColor = false;
            this.cbxSeg.CheckedChanged += new System.EventHandler(this.cbxSeg_CheckedChanged);
            // 
            // gpbModalidade
            // 
            this.gpbModalidade.Controls.Add(this.ltbModalidade);
            this.gpbModalidade.Location = new System.Drawing.Point(12, 197);
            this.gpbModalidade.Name = "gpbModalidade";
            this.gpbModalidade.Size = new System.Drawing.Size(120, 125);
            this.gpbModalidade.TabIndex = 3;
            this.gpbModalidade.TabStop = false;
            this.gpbModalidade.Text = " Modalidade ";
            // 
            // ltbModalidade
            // 
            this.ltbModalidade.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ltbModalidade.FormattingEnabled = true;
            this.ltbModalidade.Items.AddRange(new object[] {
            "Balé",
            "Hidroginástica",
            "Judô",
            "Karatê",
            "Musculação",
            "Natação",
            "Ritmíca",
            "Spinning"});
            this.ltbModalidade.Location = new System.Drawing.Point(6, 19);
            this.ltbModalidade.Name = "ltbModalidade";
            this.ltbModalidade.Size = new System.Drawing.Size(108, 95);
            this.ltbModalidade.TabIndex = 0;
            this.ltbModalidade.SelectedIndexChanged += new System.EventHandler(this.ltbModalidade_SelectedIndexChanged);
            // 
            // gpbEscolhidas
            // 
            this.gpbEscolhidas.Controls.Add(this.ltbEscolhidas);
            this.gpbEscolhidas.Location = new System.Drawing.Point(240, 197);
            this.gpbEscolhidas.Name = "gpbEscolhidas";
            this.gpbEscolhidas.Size = new System.Drawing.Size(120, 125);
            this.gpbEscolhidas.TabIndex = 6;
            this.gpbEscolhidas.TabStop = false;
            this.gpbEscolhidas.Text = " Escolhidas ";
            // 
            // ltbEscolhidas
            // 
            this.ltbEscolhidas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ltbEscolhidas.FormattingEnabled = true;
            this.ltbEscolhidas.Location = new System.Drawing.Point(6, 19);
            this.ltbEscolhidas.Name = "ltbEscolhidas";
            this.ltbEscolhidas.Size = new System.Drawing.Size(108, 95);
            this.ltbEscolhidas.TabIndex = 0;
            this.ltbEscolhidas.SelectedIndexChanged += new System.EventHandler(this.ltbEscolhidas_SelectedIndexChanged);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInserir.Enabled = false;
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInserir.Location = new System.Drawing.Point(149, 222);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 30);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir.Location = new System.Drawing.Point(149, 271);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 30);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalc.Enabled = false;
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalc.Location = new System.Drawing.Point(12, 328);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(131, 30);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calcular Modalidade";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblVal
            // 
            this.lblVal.Location = new System.Drawing.Point(149, 333);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(105, 23);
            this.lblVal.TabIndex = 0;
            this.lblVal.Text = "Valor da Modalidade";
            this.lblVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVal
            // 
            this.txtVal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtVal.Enabled = false;
            this.txtVal.Location = new System.Drawing.Point(260, 336);
            this.txtVal.Name = "txtVal";
            this.txtVal.ReadOnly = true;
            this.txtVal.Size = new System.Drawing.Size(100, 20);
            this.txtVal.TabIndex = 8;
            this.txtVal.TabStop = false;
            this.txtVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm35347_Acad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(372, 368);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.gpbSemana);
            this.Controls.Add(this.gpbEscolhidas);
            this.Controls.Add(this.gpbModalidade);
            this.Controls.Add(this.gpbPeriodo);
            this.Controls.Add(this.gpbEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_Acad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia";
            this.gpbEntrada.ResumeLayout(false);
            this.gpbEntrada.PerformLayout();
            this.gpbPeriodo.ResumeLayout(false);
            this.gpbPeriodo.PerformLayout();
            this.gpbSemana.ResumeLayout(false);
            this.gpbSemana.PerformLayout();
            this.gpbModalidade.ResumeLayout(false);
            this.gpbEscolhidas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEntrada;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.GroupBox gpbPeriodo;
        private System.Windows.Forms.RadioButton rdbNoite;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.RadioButton rdbManha;
        private System.Windows.Forms.GroupBox gpbSemana;
        private System.Windows.Forms.CheckBox cbxSex;
        private System.Windows.Forms.CheckBox cbxTer;
        private System.Windows.Forms.CheckBox cbxSab;
        private System.Windows.Forms.CheckBox cbxQua;
        private System.Windows.Forms.CheckBox cbxQui;
        private System.Windows.Forms.CheckBox cbxSeg;
        private System.Windows.Forms.GroupBox gpbModalidade;
        private System.Windows.Forms.ListBox ltbModalidade;
        private System.Windows.Forms.GroupBox gpbEscolhidas;
        private System.Windows.Forms.ListBox ltbEscolhidas;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.MaskedTextBox mtxtMatricula;
    }
}

