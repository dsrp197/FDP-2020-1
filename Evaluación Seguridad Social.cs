using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_Seguridad_Social
{
    class Program
    {
        static void Main()
        {   Console.WriteLine("Ingrese su salario mensual: ");
            double SalarioInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese 1 si su contrato es dependiente o 2 si es independiente: ");
            double Contrato = double.Parse(Console.ReadLine());

            double deduccion = 0;
            double arl = 0;
            double pension = 0;
            double eps = 0;
            double bonificacion = 0;
            double baseCotizacion = SalarioInicial * (0.4);

            if (baseCotizacion < 877803)
            {
                baseCotizacion = 877803;
            }

            if (Contrato == 2)
            {
                Console.WriteLine("Ingrese un número de 1 a 5 según su clase de riesgo: ");
                int claseRiesgo  = int.Parse(Console.ReadLine());
                eps = baseCotizacion * 0.125;
                pension = baseCotizacion * 0.16;
                if (claseRiesgo == 1) arl = baseCotizacion * 0.00522;
                else if (claseRiesgo == 2) arl = baseCotizacion * 0.01044;
                else if (claseRiesgo == 3) arl = baseCotizacion * 0.02436;
                else if (claseRiesgo == 4) arl = baseCotizacion * 0.04350;
                else arl = baseCotizacion * 0.0696;

                deduccion = (eps + arl + pension);
            }

            else
            {
                eps = baseCotizacion * 0.04;
                pension = baseCotizacion * 0.04;
                bonificacion = SalarioInicial;
                deduccion = (eps + pension);


            }
                      
            double salarioMensual = SalarioInicial - deduccion;
            Console.WriteLine("Su salario mensual real es de: " + salarioMensual);
            double salarioAnual = salarioMensual * 12 + bonificacion;
            Console.WriteLine("Su salario anual es de: " + salarioAnual);





        }
    }
}
