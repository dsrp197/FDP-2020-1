using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_002
{
    class Program
    {
        static void Main()
        {
            Console.Write("Inserte un valor entre 0 y 1: ");
            int B4 = int.Parse(Console.ReadLine());
            Console.Write("Inserte nuevamente un valor entre 0 y 1: ");
            int B3 = int.Parse(Console.ReadLine());
            Console.Write("Inserte nuevamente un valor entre 0 y 1: ");
            int B2 = int.Parse(Console.ReadLine());
            Console.Write("Inserte nuevamente un valor entre 0 y 1: ");
            int B1 = int.Parse(Console.ReadLine());
            Console.Write("Inserte nuevamente un valor entre 0 y 1: ");
            int B0 = int.Parse(Console.ReadLine());

            double Resultado1 = (B4 * (Math.Pow(2, 4)));
            double Resultado2 = (B3 * (Math.Pow(2, 3)));
            double Resultado3 = (B2 * (Math.Pow(2, 2)));
            double Resultado4 = (B1 * (Math.Pow(2, 1)));
            double Resultado5 = (B0 * (Math.Pow(2, 0)));

            Console.WriteLine("El correspondiente en decimal a el número ingresado es: ");
            Console.WriteLine(Resultado1 + Resultado2 + Resultado3 + Resultado4 + Resultado5);
        }
    }
}
