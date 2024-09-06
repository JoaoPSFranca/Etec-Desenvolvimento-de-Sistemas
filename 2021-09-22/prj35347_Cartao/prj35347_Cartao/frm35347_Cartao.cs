using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Cartao
{
    public partial class frm35347_Cartao : Form
    {
        #region Inicializar
        public frm35347_Cartao()
        {
            InitializeComponent();
        }
        #endregion

        #region btnCalc
        private void btnCalc_Click(object sender, EventArgs e)
        {
            #region Variáveis
            string Numero2 = cls35347_Cartao.ReturnNumeroMudado;
            int soma = cls35347_Cartao.ReturnSoma(Numero2);
            #endregion

            #region Mostrar
            if (cls35347_Cartao.ReturnBool(soma))
            {
                lblResultado.Text = "Código Correto";
            }
            else
            {
                lblResultado.Text = "Código Incorreto";
            }
            #endregion
        }
        #endregion

        #region btnLimpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            lblResultado.Text = "";
        }
        #endregion

        #region txtNumero
        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            #region Variáveis
            double X = 0;
            lblResultado.Text = "";
            #endregion

            #region VerificarNúmero
            if (txtNumero.Text != "")
            {
                try
                {
                    X = double.Parse(txtNumero.Text);
                    cls35347_Cartao.NCartao = X.ToString();
                }
                catch
                {
                    lblResultado.Text = "Insira apenas números";
                }
            }
            #endregion

            #region VerificarTamanho
            if (txtNumero.TextLength == 16)
            {
                btnCalc.Enabled = true;
                lblResultado.Text = "";
            }
            else
            {
                btnCalc.Enabled = false;

                if (txtNumero.TextLength > 16)
                {
                    lblResultado.Text = "Digite apenas 16 números";
                }
            }
            #endregion

            #region VerificarBtnLimpar
            if (txtNumero.Text != "" || lblResultado.Text != "")
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
    }
}
