using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_ImpostoRenda
{
    public partial class frm35347_ImpostoRenda : Form
    {
        #region Inicializar
        public frm35347_ImpostoRenda()
        {
            InitializeComponent();
        }
        #endregion

        //#region FormClosing
        //private void frm35347_ImpostoRenda_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("Deseja Sair?", "Cálculo do IRPF", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}
        //#endregion

        #region Verificar

        #region Método Verificar
        private void Verificar()
        {
            #region btnCalc
            if (txtNome.TextLength > 0 & mtxtIdade.TextLength > 0 & mtxtSexo.TextLength > 0 & txtValH.TextLength > 0 & txtQtdH.TextLength > 0)
            {
                btnCalc.Enabled = true;
            }
            else 
            {
                btnCalc.Enabled = false;
            }
            #endregion

            #region btnLimpar
            if (txtNome.TextLength > 0 | mtxtIdade.TextLength > 0 | mtxtSexo.TextLength > 0 | txtValH.TextLength > 0 | txtQtdH.TextLength > 0)
            {
                btnLimpar.Enabled = true;
            }
            else
            {
                btnLimpar.Enabled = false;
            }
            #endregion
        }
        #endregion

        #region TxtNome
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Verificar();
            LimparCalculo();
        }
        #endregion

        #endregion

        #region btnCalc
        private void btnCalc_Click(object sender, EventArgs e)
        {
            #region Variáveis
            double ValH = 0.0;
            double QtdH = 0.0;
            double SalarioB = 0.0;
            double SalarioL = 0.0;
            double ImpostoR = 0.0;
            double IR = 0.0;
            double Ded = 0.0;
            #endregion

            #region TryValH
            try
            {
                ValH = double.Parse(txtValH.Text);
            }
            catch
            {
                MessageBox.Show("Insira apenas números na caixa de textos 'Valor da Hora'", "Cálculo do IRPF", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtValH.Text = "";
                txtValH.Focus();
                return;
            }
            #endregion

            #region TryQtdH
            try
            {
                QtdH = double.Parse(txtQtdH.Text);
            }
            catch
            {
                MessageBox.Show("Insira apenas números na caixa de textos 'Quantidade de Horas'", "Cálculo do IRPF", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtQtdH.Text = "";
                txtQtdH.Focus();
                return;
            }
            #endregion

            #region Definir Salário Bruto
            SalarioB = QtdH * ValH;
            #endregion

            #region If's IR e Ded

            #region If < 1,903.99
            if (SalarioB < 1903.99)
            {
                IR = 0.0;
                Ded = 0.0;
            }
            #endregion

            #region If > 1903.99
            else
            {
                #region If < 2826.66
                if (SalarioB < 2826.66)
                {
                    IR = 7.5;
                    Ded = 142.80;
                }
                #endregion

                #region If > 2826.66
                else
                {
                    #region if < 3751.06
                    if (SalarioB < 3751.06)
                    {
                        IR = 15;
                        Ded = 354.80;
                    }
                    #endregion

                    #region If > 3751.06
                    else
                    {
                        #region If < 4664.39
                        if (SalarioB < 4664.69)
                        {
                            IR = 22.5;
                            Ded = 638.13;
                        }
                        #endregion

                        #region If > 4664.39
                        else
                        {
                            IR = 27.5;
                            Ded = 869.36;
                        }
                        #endregion
                    }
                    #endregion
                }
                #endregion
            }
            #endregion

            #endregion

            #region Calculo
            ImpostoR = (SalarioB * IR / 100) - Ded;
            SalarioL = SalarioB - ImpostoR;
            #endregion

            #region Mostrar Valores
            txtNomeC.Text = txtNome.Text;
            txtIdadeC.Text = mtxtIdade.Text;
            txtSexoC.Text = mtxtSexo.Text;
            txtSalarioB.Text = SalarioB.ToString("c");
            txtSalarioL.Text = SalarioL.ToString("c");
            txtImpostoR.Text = ImpostoR.ToString("c");

            gpbDadosCalc.Enabled = true;
            #endregion

            #region ClsEtenso
            clsExtenso.clsExtenso ClsExtenso = new clsExtenso.clsExtenso();

            string ImpostoValR = "";

            ImpostoValR = ClsExtenso.Extenso_Valor(Convert.ToDecimal(ImpostoR));

            lblValExtenso.Text = ImpostoValR;
            #endregion
        }
        #endregion

        #region Limpar

        #region Método LimparCliente
        private void LimparCliente()
        {
            txtNome.Text = "";
            mtxtIdade.Text = "";
            mtxtSexo.Text = "";
            txtValH.Text = "";
            txtQtdH.Text = "";
            btnLimpar.Enabled = false;
            txtNome.Focus();
        }
        #endregion

        #region Método LimparCalculo
        private void LimparCalculo()
        {
            txtNomeC.Text = "";
            txtIdadeC.Text = "";
            txtSexoC.Text = "";
            txtSalarioB.Text = "";
            txtSalarioL.Text = "";
            txtImpostoR.Text = "";
            lblValExtenso.Text = "";
        }
        #endregion

        #region btnLimpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCalculo();
            LimparCliente();
        }
        #endregion

        #endregion
    }
}
