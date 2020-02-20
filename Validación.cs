using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacion
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int a = 0, b = 0, suma = 0, sumaCorrecta = 0, cintentos = 3;
            while (cintentos > 0)
            {
                a = aleatorio.Next(0, 11);
                Console.WriteLine("El primer número es: " + a);
                b = aleatorio.Next(0, 11);
                Console.WriteLine("El segundo número es: " + b);
                Console.WriteLine("Escriba la suma de ambos números");
                suma = int.Parse(Console.ReadLine());
                sumaCorrecta = (a + b);

                if (sumaCorrecta == suma)
                {
                    Console.WriteLine("Inicio del programa");
                    break;                                
                }
                
                else if (cintentos > 0)
                {                    
                    cintentos -= 1;
                    if (cintentos != 0)
                    {
                        Console.WriteLine("Le quedan " + cintentos + " intentos, sume nuevamente");
                    }
                }
                

                if (cintentos == 0)
                {
                    Console.WriteLine("Error, no se pudo verificar que usted es humano");
                    break;
                }


            }

        }
    }
}
