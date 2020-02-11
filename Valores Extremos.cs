using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valores_Extremos
{
    class Program
    {
        static void Main()
        {
            double total = 0;
            Console.Write("Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 200;            
            string NombreMayor = "";
            string NombreMenor = "";            

            while (i < n)
            {                
                Console.WriteLine("Nombre: ");
                string Nombre = Console.ReadLine();
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    max = edad;
                    min = edad;
                    NombreMayor = Nombre;
                    NombreMenor = Nombre;

                }
                if (edad > max)
                {
                    max = edad;
                    NombreMayor = Nombre;
                }
                if (edad < min)
                {
                    min = edad;
                    NombreMenor = Nombre;
                }

                total += edad;
                i++;
            }


            double promedio = total / n;
            Console.WriteLine("el promedio de edad es: " + promedio);
            Console.WriteLine("La edad máxima es: " + max);
            Console.WriteLine("El nombre del mayor es: " + NombreMayor);
            Console.WriteLine("La edad mínima es: " + min);
            Console.WriteLine("El nombre del menor es: " + NombreMenor);

          
        }
    }
}
