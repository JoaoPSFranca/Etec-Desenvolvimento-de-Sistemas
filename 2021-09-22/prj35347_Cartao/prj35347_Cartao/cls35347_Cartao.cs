using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj35347_Cartao
{
    class cls35347_Cartao
    {

        #region NCartao
        public static string NCartao
        { get; set; }
        #endregion

        #region ReturnNumeroMudado
        public static string ReturnNumeroMudado
        {
            get
            {
                #region Variáveis
                int X = 0;
                int M = 0;
                string NumeroMudado = "";
                #endregion

                #region MudarNumeros
                for (int i = 0; i < 16; i++)
                {
                    #region VariávelSubstring
                    string Numero = NCartao;
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

                    #region AtualizarNumeroMudado
                    NumeroMudado = NumeroMudado + Numero;
                    #endregion
                }
                #endregion

                return NumeroMudado;
            }
        }
        #endregion

        #region ReturnSoma
        public static int ReturnSoma(string Teste)
        {
            int soma = 0;

            #region Somar
            for (int j = 0; j < 16; j++)
            {
                string Numero = Teste;
                Numero = Numero.Substring(j, 1);

                soma = soma + (int.Parse(Numero));
            }
            #endregion

            return soma;
        }
        #endregion

        #region ReturnBool
        public static bool ReturnBool(int X) { if (X % 10 == 0) { return true; } else { return false; } }
        #endregion
    }
}
