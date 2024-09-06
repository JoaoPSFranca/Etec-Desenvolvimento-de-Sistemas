using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjPalindromoClasse
{
    class cls35347
    {

        public static string Verificar(string palio)
        {
            #region Variáveis
            string Acentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string Normais = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";
            string a = "";
            string Espelhado = "";
            int b = 0;
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
                return palio + " é um Palíndromo";
            }
            else
            {
                return palio + " não é um Palíndromo";
            }
            #endregion

        }
    }
}
