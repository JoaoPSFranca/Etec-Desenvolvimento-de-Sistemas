namespace prj35347_ImpostoRenda
{
    partial class frm35347_ImpostoRenda
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
            this.components = new System.ComponentModel.Container();
            this.gpbDadosCliente = new System.Windows.Forms.GroupBox();
            this.mtxtSexo = new System.Windows.Forms.MaskedTextBox();
            this.mtxtIdade = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtQtdH = new System.Windows.Forms.TextBox();
            this.txtValH = new System.Windows.Forms.TextBox();
            this.lblQtdH = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblValH = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbDadosCalc = new System.Windows.Forms.GroupBox();
            this.lblValExtenso = new System.Windows.Forms.Label();
            this.txtImpostoR = new System.Windows.Forms.TextBox();
            this.txtSalarioB = new System.Windows.Forms.TextBox();
            this.txtIdadeC = new System.Windows.Forms.TextBox();
            this.txtSalarioL = new System.Windows.Forms.TextBox();
            this.txtSexoC = new System.Windows.Forms.TextBox();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.lblSalarioL = new System.Windows.Forms.Label();
            this.lblSexoC = new System.Windows.Forms.Label();
            this.lblExtenso = new System.Windows.Forms.Label();
            this.lblImpostoR = new System.Windows.Forms.Label();
            this.lblSalarioB = new System.Windows.Forms.Label();
            this.lblIdadeC = new System.Windows.Forms.Label();
            this.lblNomeC = new System.Windows.Forms.Label();
            this.ttpSexo = new System.Windows.Forms.ToolTip(this.components);
            this.gpbDadosCliente.SuspendLayout();
            this.gpbDadosCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosCliente
            // 
            this.gpbDadosCliente.Controls.Add(this.mtxtSexo);
            this.gpbDadosCliente.Controls.Add(this.mtxtIdade);
            this.gpbDadosCliente.Controls.Add(this.btnLimpar);
            this.gpbDadosCliente.Controls.Add(this.btnCalc);
            this.gpbDadosCliente.Controls.Add(this.txtQtdH);
            this.gpbDadosCliente.Controls.Add(this.txtValH);
            this.gpbDadosCliente.Controls.Add(this.lblQtdH);
            this.gpbDadosCliente.Controls.Add(this.txtNome);
            this.gpbDadosCliente.Controls.Add(this.lblValH);
            this.gpbDadosCliente.Controls.Add(this.lblSexo);
            this.gpbDadosCliente.Controls.Add(this.lblIdade);
            this.gpbDadosCliente.Controls.Add(this.lblNome);
            this.gpbDadosCliente.Location = new System.Drawing.Point(12, 12);
            this.gpbDadosCliente.Name = "gpbDadosCliente";
            this.gpbDadosCliente.Size = new System.Drawing.Size(219, 307);
            this.gpbDadosCliente.TabIndex = 0;
            this.gpbDadosCliente.TabStop = false;
            this.gpbDadosCliente.Text = "Dados Cliente";
            // 
            // mtxtSexo
            // 
            this.mtxtSexo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mtxtSexo.Location = new System.Drawing.Point(120, 107);
            this.mtxtSexo.Mask = "L";
            this.mtxtSexo.Name = "mtxtSexo";
            this.mtxtSexo.PromptChar = ' ';
            this.mtxtSexo.Size = new System.Drawing.Size(72, 20);
            this.mtxtSexo.TabIndex = 2;
            this.mtxtSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpSexo.SetToolTip(this.mtxtSexo, "F para Feminino\r\nM para Masculino");
            // 
            // mtxtIdade
            // 
            this.mtxtIdade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mtxtIdade.Location = new System.Drawing.Point(42, 107);
            this.mtxtIdade.Mask = "000";
            this.mtxtIdade.Name = "mtxtIdade";
            this.mtxtIdade.PromptChar = ' ';
            this.mtxtIdade.Size = new System.Drawing.Size(72, 20);
            this.mtxtIdade.TabIndex = 1;
            this.mtxtIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLimpar.Location = new System.Drawing.Point(117, 257);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 40);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalc.Enabled = false;
            this.btnCalc.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCalc.Location = new System.Drawing.Point(36, 257);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 40);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtQtdH
            // 
            this.txtQtdH.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtQtdH.Location = new System.Drawing.Point(55, 222);
            this.txtQtdH.Name = "txtQtdH";
            this.txtQtdH.Size = new System.Drawing.Size(122, 20);
            this.txtQtdH.TabIndex = 4;
            this.txtQtdH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtdH.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtValH
            // 
            this.txtValH.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtValH.Location = new System.Drawing.Point(67, 167);
            this.txtValH.Name = "txtValH";
            this.txtValH.Size = new System.Drawing.Size(100, 20);
            this.txtValH.TabIndex = 3;
            this.txtValH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValH.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblQtdH
            // 
            this.lblQtdH.Location = new System.Drawing.Point(52, 199);
            this.lblQtdH.Name = "lblQtdH";
            this.lblQtdH.Size = new System.Drawing.Size(125, 20);
            this.lblQtdH.TabIndex = 0;
            this.lblQtdH.Text = "Quantidade de Horas:";
            this.lblQtdH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNome.Location = new System.Drawing.Point(7, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(206, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblValH
            // 
            this.lblValH.Location = new System.Drawing.Point(67, 144);
            this.lblValH.Name = "lblValH";
            this.lblValH.Size = new System.Drawing.Size(100, 20);
            this.lblValH.TabIndex = 0;
            this.lblValH.Text = "Valor da Hora:";
            this.lblValH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSexo
            // 
            this.lblSexo.Location = new System.Drawing.Point(120, 84);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(72, 20);
            this.lblSexo.TabIndex = 0;
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdade
            // 
            this.lblIdade.Location = new System.Drawing.Point(42, 84);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(72, 20);
            this.lblIdade.TabIndex = 0;
            this.lblIdade.Text = "Idade:";
            this.lblIdade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(7, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(206, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbDadosCalc
            // 
            this.gpbDadosCalc.Controls.Add(this.lblValExtenso);
            this.gpbDadosCalc.Controls.Add(this.txtImpostoR);
            this.gpbDadosCalc.Controls.Add(this.txtSalarioB);
            this.gpbDadosCalc.Controls.Add(this.txtIdadeC);
            this.gpbDadosCalc.Controls.Add(this.txtSalarioL);
            this.gpbDadosCalc.Controls.Add(this.txtSexoC);
            this.gpbDadosCalc.Controls.Add(this.txtNomeC);
            this.gpbDadosCalc.Controls.Add(this.lblSalarioL);
            this.gpbDadosCalc.Controls.Add(this.lblSexoC);
            this.gpbDadosCalc.Controls.Add(this.lblExtenso);
            this.gpbDadosCalc.Controls.Add(this.lblImpostoR);
            this.gpbDadosCalc.Controls.Add(this.lblSalarioB);
            this.gpbDadosCalc.Controls.Add(this.lblIdadeC);
            this.gpbDadosCalc.Controls.Add(this.lblNomeC);
            this.gpbDadosCalc.Enabled = false;
            this.gpbDadosCalc.Location = new System.Drawing.Point(237, 12);
            this.gpbDadosCalc.Name = "gpbDadosCalc";
            this.gpbDadosCalc.Size = new System.Drawing.Size(219, 307);
            this.gpbDadosCalc.TabIndex = 1;
            this.gpbDadosCalc.TabStop = false;
            this.gpbDadosCalc.Text = "Dados Cálculo";
            // 
            // lblValExtenso
            // 
            this.lblValExtenso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblValExtenso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValExtenso.Location = new System.Drawing.Point(7, 224);
            this.lblValExtenso.Name = "lblValExtenso";
            this.lblValExtenso.Padding = new System.Windows.Forms.Padding(5);
            this.lblValExtenso.Size = new System.Drawing.Size(206, 75);
            this.lblValExtenso.TabIndex = 7;
            this.lblValExtenso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImpostoR
            // 
            this.txtImpostoR.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtImpostoR.Location = new System.Drawing.Point(56, 176);
            this.txtImpostoR.Name = "txtImpostoR";
            this.txtImpostoR.ReadOnly = true;
            this.txtImpostoR.Size = new System.Drawing.Size(105, 20);
            this.txtImpostoR.TabIndex = 5;
            this.txtImpostoR.TabStop = false;
            this.txtImpostoR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSalarioB
            // 
            this.txtSalarioB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSalarioB.Location = new System.Drawing.Point(6, 130);
            this.txtSalarioB.Name = "txtSalarioB";
            this.txtSalarioB.ReadOnly = true;
            this.txtSalarioB.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioB.TabIndex = 3;
            this.txtSalarioB.TabStop = false;
            this.txtSalarioB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdadeC
            // 
            this.txtIdadeC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtIdadeC.Location = new System.Drawing.Point(34, 84);
            this.txtIdadeC.Name = "txtIdadeC";
            this.txtIdadeC.ReadOnly = true;
            this.txtIdadeC.Size = new System.Drawing.Size(72, 20);
            this.txtIdadeC.TabIndex = 1;
            this.txtIdadeC.TabStop = false;
            this.txtIdadeC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSalarioL
            // 
            this.txtSalarioL.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSalarioL.Location = new System.Drawing.Point(112, 130);
            this.txtSalarioL.Name = "txtSalarioL";
            this.txtSalarioL.ReadOnly = true;
            this.txtSalarioL.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioL.TabIndex = 4;
            this.txtSalarioL.TabStop = false;
            this.txtSalarioL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSexoC
            // 
            this.txtSexoC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSexoC.Location = new System.Drawing.Point(112, 83);
            this.txtSexoC.Name = "txtSexoC";
            this.txtSexoC.ReadOnly = true;
            this.txtSexoC.Size = new System.Drawing.Size(72, 20);
            this.txtSexoC.TabIndex = 2;
            this.txtSexoC.TabStop = false;
            this.txtSexoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeC
            // 
            this.txtNomeC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNomeC.Location = new System.Drawing.Point(6, 38);
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.ReadOnly = true;
            this.txtNomeC.Size = new System.Drawing.Size(206, 20);
            this.txtNomeC.TabIndex = 0;
            this.txtNomeC.TabStop = false;
            this.txtNomeC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSalarioL
            // 
            this.lblSalarioL.Location = new System.Drawing.Point(112, 107);
            this.lblSalarioL.Name = "lblSalarioL";
            this.lblSalarioL.Size = new System.Drawing.Size(100, 20);
            this.lblSalarioL.TabIndex = 0;
            this.lblSalarioL.Text = "Salário Líquido:";
            this.lblSalarioL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSexoC
            // 
            this.lblSexoC.Location = new System.Drawing.Point(112, 61);
            this.lblSexoC.Name = "lblSexoC";
            this.lblSexoC.Size = new System.Drawing.Size(72, 20);
            this.lblSexoC.TabIndex = 0;
            this.lblSexoC.Text = "Sexo:";
            this.lblSexoC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExtenso
            // 
            this.lblExtenso.Location = new System.Drawing.Point(6, 199);
            this.lblExtenso.Name = "lblExtenso";
            this.lblExtenso.Size = new System.Drawing.Size(206, 20);
            this.lblExtenso.TabIndex = 0;
            this.lblExtenso.Text = "Extenso:";
            this.lblExtenso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImpostoR
            // 
            this.lblImpostoR.Location = new System.Drawing.Point(56, 153);
            this.lblImpostoR.Name = "lblImpostoR";
            this.lblImpostoR.Size = new System.Drawing.Size(105, 20);
            this.lblImpostoR.TabIndex = 0;
            this.lblImpostoR.Text = "Imposto Retido:";
            this.lblImpostoR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalarioB
            // 
            this.lblSalarioB.Location = new System.Drawing.Point(6, 107);
            this.lblSalarioB.Name = "lblSalarioB";
            this.lblSalarioB.Size = new System.Drawing.Size(100, 20);
            this.lblSalarioB.TabIndex = 0;
            this.lblSalarioB.Text = "Salário Bruto:";
            this.lblSalarioB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdadeC
            // 
            this.lblIdadeC.Location = new System.Drawing.Point(34, 61);
            this.lblIdadeC.Name = "lblIdadeC";
            this.lblIdadeC.Size = new System.Drawing.Size(72, 20);
            this.lblIdadeC.TabIndex = 0;
            this.lblIdadeC.Text = "Idade:";
            this.lblIdadeC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeC
            // 
            this.lblNomeC.Location = new System.Drawing.Point(6, 16);
            this.lblNomeC.Name = "lblNomeC";
            this.lblNomeC.Size = new System.Drawing.Size(206, 20);
            this.lblNomeC.TabIndex = 0;
            this.lblNomeC.Text = "Nome:";
            this.lblNomeC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm35347_ImpostoRenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 331);
            this.Controls.Add(this.gpbDadosCalc);
            this.Controls.Add(this.gpbDadosCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm35347_ImpostoRenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo do IRPF";
            this.gpbDadosCliente.ResumeLayout(false);
            this.gpbDadosCliente.PerformLayout();
            this.gpbDadosCalc.ResumeLayout(false);
            this.gpbDadosCalc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosCliente;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtValH;
        private System.Windows.Forms.Label lblValH;
        private System.Windows.Forms.TextBox txtQtdH;
        private System.Windows.Forms.Label lblQtdH;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox gpbDadosCalc;
        private System.Windows.Forms.TextBox txtImpostoR;
        private System.Windows.Forms.TextBox txtSalarioB;
        private System.Windows.Forms.TextBox txtIdadeC;
        private System.Windows.Forms.TextBox txtSalarioL;
        private System.Windows.Forms.TextBox txtSexoC;
        private System.Windows.Forms.TextBox txtNomeC;
        private System.Windows.Forms.Label lblSalarioL;
        private System.Windows.Forms.Label lblSexoC;
        private System.Windows.Forms.Label lblExtenso;
        private System.Windows.Forms.Label lblImpostoR;
        private System.Windows.Forms.Label lblSalarioB;
        private System.Windows.Forms.Label lblIdadeC;
        private System.Windows.Forms.Label lblNomeC;
        private System.Windows.Forms.Label lblValExtenso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtxtIdade;
        private System.Windows.Forms.MaskedTextBox mtxtSexo;
        private System.Windows.Forms.ToolTip ttpSexo;
    }
}

