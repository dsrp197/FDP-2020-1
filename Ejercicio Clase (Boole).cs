using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_clase_Boole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de votos para el partido 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de votos para el partido 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de votos en blanco: ");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de votos anulados: ");
            int  anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número total de población: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de población mayor de edad: ");
            int p = int.Parse(Console.ReadLine());

            double votantes = (a + b + blancos + anulados);
            double mayores = (n * p / 100);
            double abstencion = (mayores - votantes);

            Console.WriteLine("Número de votantes: " + votantes);
            Console.WriteLine("Número de personas mayores: " + mayores);
            Console.WriteLine("Abstención total: " + abstencion);

            bool Cond1 = (anulados < ((a + b) * 0.3));
            bool Cond2 = ((a + b) > blancos);
            bool Cond3 = (abstencion < votantes);

            if ((Cond1 || Cond2) && Cond3) 
            {
                Console.WriteLine("Las votaciones fueron exitosas");   
                if (a > b)
                {
                    Console.WriteLine("Gana A");
                }

                else
                {
                    Console.WriteLine("Gana B");
                }
            }

            else
            {
                Console.WriteLine("Las elecciones deben ser realizadas nuevamente");
            }                              

            

        }
    }
}
