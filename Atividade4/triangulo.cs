using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    internal class triangulo
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;

        public triangulo() { }

        public triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }

        public void setLadoA(double ladoA)
        {
            this.ladoA = ladoA;
        }

        public double getLadoA()
        {
            return this.ladoA;
        }

        public void setLadoB(double ladoB)
        {
            this.ladoB = ladoB;
        }

        public double getLadoB()
        {
            return this.ladoB;
        }

        public void setLadoC(double ladoC)
        {
            this.ladoC = ladoC;
        }

        public double getLadoC()
        {
            return this.ladoC;
        }
    }
}

