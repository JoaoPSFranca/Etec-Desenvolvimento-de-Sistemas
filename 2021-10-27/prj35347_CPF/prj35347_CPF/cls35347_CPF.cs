using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj35347_CPF
{
    class cls35347_CPF
    {
        #region NCPF
        public static string NCPF
        { get; set; }
        #endregion

        #region Return Digito 1
        public static int ReturnDigito1
        {
            get
            {
                #region Variáveis
                int x = 10;
                int soma = 0;
                string numero = NCPF;
                int resto1 = 0;
                int digito1 = 0;
                #endregion

                #region For
                for (int i = 0; i < 9; i++)
                {
                    #region pegarNumero
                    int numero2 = int.Parse(numero.Substring(i, 1));
                    #endregion

                    #region Calculo
                    numero2 = numero2 * x;
                    soma = soma + numero2;
                    #endregion

                    x--;
                }
                #endregion

                resto1 = soma % 11;

                #region Valor do Digito1
                if (resto1 == 0 || resto1 == 1)
                {
                    digito1 = 0;
                }
                else
                {
                    digito1 = 11 - resto1;
                }
                #endregion

                return digito1;
            }
        }
        #endregion

        #region ReturnDigito2
        public static int ReturnDigito2 {
            get
            {
                #region Variáveis
                int x = 11;
                int soma = 0;
                string numero = NCPF;
                int resto2 = 0;
                int digito2 = 0;
                #endregion

                #region For
                for (int i = 0; i < 10; i++)
                {
                    #region pegarNumero
                    int numero2 = int.Parse(numero.Substring(i, 1));
                    #endregion

                    #region Calculo
                    numero2 = numero2 * x;
                    soma = soma + numero2;
                    #endregion

                    x--;
                }
                #endregion

                resto2 = soma % 11;

                #region Valor do Digito2
                if (resto2 == 0 || resto2 == 1)
                {
                    digito2 = 0;
                }
                else
                {
                    digito2 = 11 - resto2;
                }
                #endregion

                return digito2;
            }
        }
        #endregion
    }
}
