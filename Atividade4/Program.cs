using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bc, bc2;

            //declarando um objeto para classe triangulo
            triangulo t = new triangulo();            

            Console.WriteLine("Digite o valor do lado A:");
            t.setLadoA(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o valor do lado B:");
            t.setLadoB(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o valor do lado C:");
            t.setLadoC(double.Parse(Console.ReadLine()));

            //CRIADO PARA SEPARAR
            Console.WriteLine("");
            //variaveis
            bc = t.getLadoB() + t.getLadoC();
            bc2 = Math.Pow(t.getLadoB(), 2) + Math.Pow(t.getLadoC(), 2);

            if(t.getLadoA() >= bc)
            {
                Console.WriteLine("R: NÃO FORMA TRIANGULO");
            }

            else if(Math.Pow(t.getLadoA(), 2) == bc2)
            {
                Console.WriteLine("R: TRIANGULO RETANGULO");
            }

            else if (Math.Pow(t.getLadoA(), 2) > bc2)
            {
                Console.WriteLine("R: TRIANGULO OBTUSANGULO");
            }

            else if (Math.Pow(t.getLadoA(), 2) < bc2)
            {
                Console.WriteLine("R: TRIANGULO ACUTANGULO");
            }

            else if (t.getLadoA() == t.getLadoB() && t.getLadoB() == t.getLadoC())
            {
                Console.WriteLine("R: TRIANGULO EQUILATERO");
            }

            else
            {
                Console.WriteLine("R: TRIANGULO ISOSCELES");
            }

            



        }
    }
}
