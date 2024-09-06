using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Palindromo
{
    public partial class frm35347_Palindromo : Form
    {
        #region Inicializar
        public frm35347_Palindromo()
        {
            InitializeComponent();
        }
        #endregion

        #region btn
        private void btnPalio_Click(object sender, EventArgs e)
        {
            #region Variáveis
            string palio = "";
            string Acentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string Normais = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";
            string a = "";
            string Espelhado = "";
            int b = 0;
            #endregion

            #region Atribuir Valor
            palio = txtPalio.Text;
            #endregion

            #region Trim()
            palio = palio.Trim();
            #endregion

            #region Acento
            for (int i = 0; i < Acentos.Length; i++)
            {
                palio = palio.Replace(Acentos[i].ToString(), Normais[i].ToString());
            }
            #endregion

            #region Minúscula
            palio = palio.ToLower();
            #endregion

            #region Espelhar
            b = palio.Length;
            int j = b;
            for (j = b; j > 0; j--)
            {
                a = palio.Substring(j - 1, 1);
                Espelhado = Espelhado + a;
            }
            #endregion

            #region Comparar
            if (String.Equals(Espelhado, palio))
            {
                lblPalio.Text = palio + " é um Palíndromo";
            }
            else
            {
                lblPalio.Text = palio + " não é um Palíndromo";
            }
            #endregion
        }

        #endregion

        #region txt
        private void txtPalio_TextChanged(object sender, EventArgs e)
        {
            lblPalio.Text = "";
        }
        #endregion
    }
}
