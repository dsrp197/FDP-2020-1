using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese X1: ");
            int X1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese X2: ");
            int X2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese X3: ");
            int Y1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese X4: ");
            int Y2 = int.Parse(Console.ReadLine());

            double m = ((Y2 - Y1) / (X2 - X1));
            Console.WriteLine("La pendiente es: " + m);

            double b = (Y1 - (m * X1));
            Console.WriteLine("La pendiente es: " + b);

            double d = Math.Sqrt((Math.Pow(Y2 - Y1, 2)) + (Math.Pow(X2 - X1, 2)));
            Console.WriteLine("La distancia es: " + d);
        }
    }
}
