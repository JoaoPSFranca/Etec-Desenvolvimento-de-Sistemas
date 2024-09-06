using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cls35347_E2GClass
{
    public class clsE2G
    {
        private double _valorA;
        private double _valorB;
        private double _valorC;

        public double ValorA
        {
            set { _valorA = value; }
            get { return _valorA; }
        }

        public double ValorB
        {
            set { _valorB = value; }
            get { return _valorB; }
        }

        public double ValorC
        {
            set { _valorC = value; }
            get { return _valorC; }
        }

        public double Delta
        {
            get { return ((Math.Pow(_valorB, 2)) - 4 * _valorA * _valorC); }
        }

        public double X1
        {
            get { return ((-_valorB + Math.Sqrt(Delta)) / 2 * _valorA); }
        }

        public double X2
        {
            get { return ((-_valorB - Math.Sqrt(Delta)) / 2 * _valorA); }
        }

        public string OBS
        {
            get
            {
                if (Delta < 0)
                {
                    return "Delta Negativo";
                }
                else
                {
                    if (X1 == X2)
                    {
                        return "Delta Positivo com X1 e X2 Iguais";
                    }
                    else
                    {
                        return "Delta Positivo com X1 e X2 Diferentes";
                    }
                }
            }
        }
    }
}
