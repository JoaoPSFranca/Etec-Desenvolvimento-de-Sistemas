using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista02_Ex1
{
    public partial class frm35347_Lista02_Ex1 : Form
    {
        #region Inicializar
        public frm35347_Lista02_Ex1()
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
            int Decimal = 0;
            int Resto = 0;
            #endregion

            #region TryDecimal
            try
            {
                Decimal = int.Parse(txtDecimal.Text);
            }
            catch
            {
                txtDecimal.Text = "";
                txtDecimal.Focus();
                lblResp.Text = "Digite somente números na caixa de textos 'Decimal'";
                return;
            }
            #endregion

            #region If 199 > D < 2
            if (Decimal > 199)
            {
                txtDecimal.Text = "";
                txtDecimal.Focus();
                lblResp.Text = "Digite somente números entre 1 e 200 na caixa de textos Decimal";
                return;
            }
            else
            {
                if (Decimal < 2)
                {
                    txtDecimal.Text = "";
                    txtDecimal.Focus();
                    lblResp.Text = "Digite somente números entre 1 e 200 na caixa de textos Decimal";
                    return;
                }
            }
            #endregion

            #region Cálculo
                while(Decimal > 1)
                {
                    Resto = Decimal % 2;
                    txtBinario.Text = Resto.ToString() + lblResp.Text;
                    lblResp.Text = Resto.ToString() + lblResp.Text;
                    Decimal = Decimal / 2;
                }
            #endregion

            #region Mostrar
            txtBinario.Text = Decimal.ToString() + lblResp.Text;
            lblResp.Text = Decimal.ToString() + lblResp.Text;
            #endregion

            #region if textlenght
                if (txtBinario.TextLength < 8)
                {
                    while (txtBinario.TextLength < 8)
                    {
                        txtBinario.Text = 0 + txtBinario.Text;
                        lblResp.Text = 0 + lblResp.Text;
                    }
                }
            #endregion
        }
        #endregion

        #region txtDecimal
        private void txtDecimal_TextChanged(object sender, EventArgs e)
        {
            txtBinario.Text = "";
            lblResp.Text = "";
        }
        #endregion
    }
}
