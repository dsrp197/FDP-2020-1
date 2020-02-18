using System;

namespace Ciclos__Casa_
{
    class Program
    {
        static void Main()
        {
            Random Aleatorio = new Random();
            Console.WriteLine("Inicio del juego");
            int dado1 = 0, total = 0, inicial = 0, contador12 = 0, contador10 = 0, final = 0;
            string continuar = "s";
            string repetir = "s";

            while (continuar == "s" || total < 100)
            {
                while (inicial < 3 && repetir == "s")
                {
                    dado1 = Aleatorio.Next(1, 13);
                    Console.WriteLine("Sacó: " + dado1);
                    Console.WriteLine("¿Desea continuar? (s/n)");
                    repetir = Console.ReadLine();
                    inicial += 1;
                    total += dado1;

                    if (repetir != "s")
                    {
                        final = 1;
                        break;
                    }
                }
                if (final == 1) break;

                dado1 = Aleatorio.Next(1, 13);
                Console.WriteLine("Sacaste: " + dado1);
                total += 1;

                if (dado1%2 != 0)
                {
                    Console.WriteLine("Perdiste");
                    Console.WriteLine("Puntaje Total: " + total);
                    break;
                }

                if (dado1 == 12)
                {
                    contador12 = 1;
                    Console.WriteLine("Si sacas un 10 en el siguiente turno ganas el juego");
                    break;
                }
                if (contador12 == 1)
                {
                    if (dado1 == 10) contador10 = 1;
                    else contador10 = 0;
                }
                if (dado1 !=12) contador12 = 0;

                if (contador12 + contador10 == 2)
                {
                    Console.Write("Ganaste");
                    Console.WriteLine("Puntaje Total: " + total);
                    break;
                }

                Console.WriteLine("¿Deseas continuar jugando? (s/n)");
                continuar = Console.ReadLine();
            }          
            Console.WriteLine("Fin del juego, tu puntaje total fue de: " + total);
            if (total >= 100) Console.WriteLine("Ganaste");

            
                
        }
    }
}
