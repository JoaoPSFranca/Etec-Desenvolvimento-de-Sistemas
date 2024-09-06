using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj35347_TituloEleitor
{
    class cls35347_TituloEleitor
    {
        #region NCD
        public static string NCD
        { get; set; }
        #endregion

        #region VerificarUF
        public static string VerificarUF
        {
            get{
                #region Variáveis
                string numero = NCD;
                string NumeroUF = numero.Substring(8, 2);
                int UF = int.Parse(NumeroUF);
                string resposta = "";
                #endregion

                #region IF
                if (UF == 00 || UF > 28)
                {
                    return "Número Inválido";
                }
                else
                {
                    #region switchCase
                    switch (UF)
                    {
                        case (01): resposta = "SP - São Paulo"; break;
                        case (02): resposta = "MG - Minas Gerais"; break;
                        case (03): resposta = "RJ - Rio de Janeiro"; break;
                        case (04): resposta = "RS - Rio Grande do Sul"; break;
                        case (05): resposta = "BA - Bahia"; break;
                        case (06): resposta = "PR - Pará"; break;
                        case (07): resposta = "CE - Ceará"; break;
                        case (08): resposta = "PE - Pernambuco"; break;
                        case (09): resposta = "SC - Santa Catarina"; break;
                        case (10): resposta = "GO - Goiás"; break;
                        case (11): resposta = "MA - Maranhão"; break;
                        case (12): resposta = "PB - Paraíba"; break;
                        case (13): resposta = "PA - Pará"; break;
                        case (14): resposta = "ES - Espírito Santo"; break;
                        case (15): resposta = "PI - Piauí"; break;
                        case (16): resposta = "RN - Rio Grande do Norte"; break;
                        case (17): resposta = "AL - Alagoas"; break;
                        case (18): resposta = "MT - Mato Grosso"; break;
                        case (19): resposta = "MS - Mato Grosso do Sul"; break;
                        case (20): resposta = "DF - Distrito Federal"; break;
                        case (21): resposta = "SE - Sergipe"; break;
                        case (22): resposta = "AM - Amazonas"; break;
                        case (23): resposta = "RO - Rondônia"; break;
                        case (24): resposta = "AC - Acre"; break;
                        case (25): resposta = "AP - Amapá"; break;
                        case (26): resposta = "RR - Roraima"; break;
                        case (27): resposta = "TO - Tocantins"; break;
                        case (28): resposta = "ZZ - Exterior"; break;
                    }
                    #endregion

                    return resposta;
                }
                #endregion
            }
        }
        #endregion

        #region VerificarDV
        public static string VerificarDV (string numeroDV, string DV){
            #region Variáveis
            int X = 0;
            int M = 2;
            int soma = 0;
            int divisao = 0;
            int DV1 = int.Parse(DV.Substring(2, 1));
            int DV2 = int.Parse(DV.Substring(3,1));
            #endregion

            #region numeroDV

            #region For
            for (int i = 0; i < 8; i++)
            {
                X = int.Parse(numeroDV.Substring(i, 1));
                soma += X * M;
                M++;
            }
            #endregion

            divisao = soma % 11;

            if (divisao != DV1)
            {
                return "Número Inválido";
            }
            #endregion

            #region DV
            else
            {
                #region Variáveis
                M = 7;
                soma = 0;
                #endregion

                #region For
                for (int k = 0; k < 3; k++)
                {
                    X = int.Parse(DV.Substring(k, 1));
                    soma += X * M;
                    M++;
                }
                #endregion

                divisao = soma % 11;

                if (divisao != DV2)
                {
                    return "Número Inválido";
                }
                else
                {
                    return "Número Válido";
                }
            }
            #endregion
        }
        #endregion
    }
}
