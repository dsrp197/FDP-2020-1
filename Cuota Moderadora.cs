using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_Tarifa
{
        class Program
        {
            static void Main(string[] args)
        {
            //Ingreso de salario
            Console.WriteLine("Ingrese su salario en cuestión de smmlv. Teniendo en cuenta que 1 smmlv = 877.803  COP");
            int salario = int.Parse(Console.ReadLine());

            //Condiciones teniendo en cuenta el número de smmlv que gana la persona

            if (salario < 2)
            {
                Console.WriteLine("Tarifa A");
                Console.WriteLine("Cuota moderadora = 3.400");

            }

            else if (2 <= salario && salario < 5)
            {
                Console.WriteLine("Tarifa B");
                Console.WriteLine("Cuota moderadora = 13500");
            }

            else
            {
                Console.WriteLine("Tarifa C");
                Console.WriteLine("Cuota moderadora = 35600");
            }
        }
    }
}


