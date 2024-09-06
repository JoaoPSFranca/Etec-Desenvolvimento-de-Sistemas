using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista02_Ex02
{
    public partial class frm35347_Lista02_Ex02 : Form
    {
        #region Inicializar
        public frm35347_Lista02_Ex02()
        {
            InitializeComponent();
        }
        #endregion

        #region Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Decimal para Binário", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion

        #region Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

            #region Método Limpar
            private void Limpar()
            {
                txtBinario.Text = "";
                txtDecimal.Text = "";
                lblResp.Text = "";
            }
            #endregion

        #endregion

        #region Calcular
        private void btnCalc_Click(object sender, EventArgs e)
        {
            #region Variáveis
                int Binario = 0;
                int j = 0;
                double Decimal = 0;
                int k = 7;
            #endregion

            #region TryBinário
            try
            {
                Binario = int.Parse(txtBinario.Text);
            }
            catch
            {
                txtBinario.Text = "";
                txtBinario.Focus();
                lblResp.Text = "Digite somente números na caixa de textos 'Binário'";
                return;
            }
            #endregion

            #region If > 8
            if (txtBinario.TextLength > 8)
            {
                txtBinario.Text = "";
                txtBinario.Focus();
                lblResp.Text = "Digite somente números binários com até 8 dígitos na caixa de textos 'Binário:'";
                return;
            }
            #endregion

            #region txtLength < 8
            txtDecimal.Text = txtBinario.Text;
            while (txtDecimal.TextLength < 8)
            {
                txtDecimal.Text = 0 + txtDecimal.Text;
            }
            #endregion

            #region Substring
            for (int i = 1; i < 9; i++)
            {
                j = int.Parse(txtDecimal.Text.Substring(i-1, 1));
                if (j == 0)
                {
                    
                }
                else
                {
                    if (j == 1)
                    {
                        Decimal = Decimal + Math.Pow(2, k);
                    }
                    else
                    {
                        txtDecimal.Text = "";
                        txtBinario.Text = "";
                        txtBinario.Focus();
                        lblResp.Text = "Digite somente números binários na caixa de textos 'Binário:'";
                        return;
                    }
                }
                k--;
            }   
            #endregion

            #region Mostrar
            txtDecimal.Text = Decimal.ToString();
            lblResp.Text = Decimal.ToString();
            #endregion
        }
        #endregion

        #region TxtBinario
        private void txtBinario_TextChanged(object sender, EventArgs e)
        {
            txtDecimal.Text = "";
            lblResp.Text = "";
        }
        #endregion

        //#region FormClosing
        //private void frm35347_Lista02_Ex02_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("Deseja Sair?", "Binário para Decimal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}
        //#endregion
    }
}