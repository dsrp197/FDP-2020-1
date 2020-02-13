using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro__Ciclos_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Aleatorio = new Random();
            Console.WriteLine("Inicio del juego");
            int dado1 = 0, dado2 = 0, total = 0, pares = 0, tiradas = 0;
            string continuar = "s";
            double Mas6 = 0;

            while (continuar == "s" && pares < 3)
            {
                dado1 = Aleatorio.Next(1,7);
                Console.WriteLine("Dado1 = " + dado1);
                dado2 = Aleatorio.Next(1, 7);
                Console.WriteLine("Dado2 = " + dado2);
                tiradas += 1;
                if (dado1 == 1 && dado2 == 1)
                {
                    Console.WriteLine("Usted fue eliminado");
                    total = 0;
                    break;
                }
                else
                {
                    total += dado1 + dado2;
                    Console.WriteLine("El total es: " + total);
                    if (dado1 + dado2 > 6)
                    {
                        Mas6 += 1;
                    }
                    else if (dado1 == dado2)
                    {
                        pares += 1;
                    }
                }
                
                if (total >= 100 || pares >= 3)
                {
                    Console.WriteLine("Usted sacó 3 pares o más u/o obtuvo más de 100 puntos, usted ganó el juego");
                    break;
                }
                
                else
                {
                    Console.WriteLine("¿Desea continuar? s/n");
                    continuar = Console.ReadLine();
                }                 
            }
            double mas6 = (Mas6 / tiradas) * 100;
            Console.WriteLine("El porcentaje de turnos en el que sacó más de 6 fue: " + mas6);

            Console.WriteLine("Su total fue de: " + total);

        }
    }
}
