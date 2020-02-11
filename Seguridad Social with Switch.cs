using System;

namespace Seguridad_Social_Switch
{
        class Program
        {
            static void Main(string[] args)
            {              
                Console.WriteLine("Ingrese su salario mensual: ");
                double SalarioInicial = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese 1 si su contrato es dependiente o 2 si es independiente: ");
                int contrato = int.Parse(Console.ReadLine());
            

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

                switch (contrato)
                {
                    case 2:
                        Console.WriteLine("Ingrese un número de 1 a 5 según su clase de riesgo: ");
                        int claseRiesgo = int.Parse(Console.ReadLine());
                        eps = baseCotizacion * 0.125;
                        pension = baseCotizacion * 0.16;
                        switch (claseRiesgo)
                        {                            
                            case 1:
                                arl = baseCotizacion * 0.00522;
                                break;
                            case 2:
                                arl = baseCotizacion * 0.01044;
                                break;
                            case 3:
                                arl = baseCotizacion * 0.02436;
                                break;
                            case 4:
                                arl = baseCotizacion * 0.04350;
                                break;
                            default:
                                arl = baseCotizacion * 0.0690;
                                break;
                        }
                        deduccion = (eps + arl + pension);
                        break;



                    default:

                        eps = baseCotizacion * 0.04;
                        pension = baseCotizacion * 0.04;
                        bonificacion = SalarioInicial;
                        deduccion = (eps + pension);
                        break;

                }
                
                double salarioMensual = SalarioInicial - deduccion;
                Console.WriteLine("Su salario mensual real es de: " + salarioMensual);
                double salarioAnual = salarioMensual * 12 + bonificacion;
                Console.WriteLine("Su salario anual es de: " + salarioAnual);
            }
        }
}