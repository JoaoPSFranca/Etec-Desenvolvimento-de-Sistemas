using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj35347_IMC_Classe
{
    public class ClsIMC
    {
        private double _altura;
        private double _peso;
        private double _imc;

        public double Altura
        {
            set { _altura = value; }
            get { return _altura; }
        }

        public double Peso
        {
            set { _peso = value; }
            get { return _peso; }
        }

        public double imc
        {
            get { return _imc = _peso / (_altura * _altura); }
        }

        public string Resultado
        {
            get
            {
                if (_imc < 20)
                {
                    return "Abaixo do Peso";
                }
                else
                {
                    if (20 >= _imc && _imc <= 25)
                    {
                        return "Peso Ideal";
                    }
                    else
                    {
                        return "Acima do Peso";
                    }
                }
            }
        }
    }
}
