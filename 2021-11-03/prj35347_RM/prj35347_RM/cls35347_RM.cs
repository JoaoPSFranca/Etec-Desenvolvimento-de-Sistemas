using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj35347_RM
{
    class cls35347_RM
    {
        #region NRM
        public static string NRM
        { get; set; }
        #endregion

        #region NG
        public static string NG {
            get 
            {
                #region Variáveis
                int X = 0;
                int M = 0;
                string NG = "";
                #endregion

                #region MudarNumeros
                for (int i = 0; i < 5; i++)
                {
                    #region VariávelSubstring
                    string Numero = NRM;
                    Numero = Numero.Substring(i, 1);
                    #endregion

                    #region FazerCalculo
                    if (X == 0) { M = 2; X++; } else { M = 1; X = 0; }
                    Numero = ((int.Parse(Numero)) * M).ToString();
                    #endregion

                    #region VerificarValor
                    if (int.Parse(Numero) > 9)
                    {
                        Numero = ((int.Parse(Numero)) - 9).ToString();
                    }
                    #endregion

                    #region AtualizarNG
                    NG = NG + Numero;
                    #endregion
                }
                #endregion

                return NG;
            }
        }
        #endregion

        #region Soma
        public static int Soma(string NumeroG)
        {
            int soma = 0;

            #region Somar
            for (int j = 0; j < 5; j++)
            {
                string Numero = NumeroG.Substring(j, 1);

                soma = soma + (int.Parse(Numero));
            }
            #endregion

            return soma;
        }
        #endregion

        #region NGF
        public static string NGF (int X)
        {
            return NRM + "-" + (X % 10).ToString();
        }
        #endregion
    }
}
