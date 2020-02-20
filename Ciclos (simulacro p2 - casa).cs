using System;

namespace Ciclos__simulacro_p2___casa_
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            Console.WriteLine("Inicio del juego");
            int dado1 = 0, total = 0, cvidas = 3, cturnos = 0, dadoprovisional = 0;
            string continuar = "s";
            while (continuar == "s")
            {
                dado1 = aleatorio.Next(1, 7);
                Console.WriteLine("Dado1 = " + dado1);
                Console.WriteLine("¿Desea continuar? (s/n)");
                continuar = Console.ReadLine();
                if (continuar == "s")
                {
                    total += dado1;
                    Console.WriteLine("Su puntaje actual es de: " + total);

                }
                if (continuar != "s")
                {
                    Console.WriteLine("Usted ha decidido retirarse");
                    break;
                }
                cturnos += 1;
                if (cturnos % 2 != 0)
                {
                    cvidas -= 1;
                    Console.WriteLine("Usted perdió una vida");
                    Console.WriteLine("Usted tiene " + cvidas + " vidas");
                }
                if (cturnos % 2 == 0)
                {
                    Console.WriteLine("Se le ha otorgado un dado por llegar al turno 3");
                    dadoprovisional = aleatorio.Next(1, 7);
                    Console.WriteLine("Dado otorgado cada 3 turnos es: " + dadoprovisional);
                    if (dadoprovisional == dado1)
                    {
                        Console.WriteLine("Sus dados son pares, se le ha otorgado una vida");
                        cvidas += 1;
                        Console.WriteLine("Usted tiene " + cvidas + " vidas");
                    }
                    total += (dado1 + dadoprovisional);
                    Console.WriteLine("Su puntaje actual es de: " + total);

                }
                
                if (total >= 100)
                {
                    Console.WriteLine("Usted ganó el juego");
                    break;
                }
                if (cvidas <= 0)
                {
                    Console.WriteLine("Usted perdió el juego");
                    break;
                }
            }



        }
    }
}
