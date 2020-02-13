using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementar_al_juego_BlackJack
{
    class Program
    {
        static void Main()
        {
            Random Aleatorio = new Random();

            int C1 = Aleatorio.Next(1, 10);
            Console.WriteLine("Su primera carta es: " + C1);
            int C2 = Aleatorio.Next(1, 10);
            Console.WriteLine("Su segunda carta es: " + C2);

            int NCarta = 0;
            int Puntaje = C1 + C2;
            Console.WriteLine("Su puntaje inicial es: " + Puntaje);

            string continuar = "s";
            while (continuar == "s" && Puntaje <= 21)
            {
                Console.WriteLine("¿Desea continuar pidiendo otra carta? s/n");
                continuar = Console.ReadLine();
                Console.WriteLine("");


                if (continuar == "s")
                {
                    NCarta = Aleatorio.Next(1, 10);
                    Console.WriteLine("Su nueva carta es: " + NCarta);
                    Puntaje = Puntaje + NCarta;
                    Console.WriteLine("Su nuevo puntaje es: " + Puntaje);
                }



                if (Puntaje > 21)
                {                                      
                    Console.WriteLine("Usted fue eliminado");
                    continuar = "n";
                }
            }

            Console.WriteLine("Su puntaje fue de: " + Puntaje);
            Console.WriteLine("Gracias por jugar");
        }
    }
}
