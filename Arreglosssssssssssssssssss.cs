using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {   
            Console.Write("Ingrese el número de datos que se tienen:");
            int n = int.Parse(Console.ReadLine());
            int[] edades = new int[n];
            int max = 0, min = 100;
            double total = 0;
            string NombreMayor = "";
            string NombreMenor = "";
            string PCP = "";
            string[] nombres = new string[n];

            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                edades[i] = edad;
                total += edades[i];

                if (max < edades[i]) max = edades[i];
                if (min > edades[i]) min = edades[i];


                Console.WriteLine("Nombre: ");
                string nombre = (Console.ReadLine());
                nombres[i] = nombre;

                if (max == edades[i]) NombreMayor = nombres[i];
                if (min == edades[i]) NombreMenor = nombres[i];


            }

            double promedio = total / edades.Length;
            double[] sumatoria = new double[n];
            double suma = 0;

            for (int i = 0; i < edades.Length; i++)
            {
                int xi = edades[i];
                suma += Math.Pow((xi - promedio), 2);
            }

            double desviacion = Math.Sqrt(suma / n);
        
            Console.WriteLine("El promedio de edades es: " + promedio);
            Console.WriteLine("La desviación estandar es: " + desviacion);
            Console.WriteLine("Edad Max: " + max);
            Console.WriteLine("nombre del Myor: " + NombreMayor);

            Console.WriteLine("Edad Min: " + min);
            Console.WriteLine("nombre del Mnor: " + NombreMenor);






        }
    }
}
