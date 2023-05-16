using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, maximoNegativo = 0, minimoPositivo = 0;
            bool primerNegativo = false, primerPositivo = false;

            Console.WriteLine("Ingrese números hasta apretar el cero");
            n = double.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (n < 0)
                {
                    if (primerNegativo == false)
                    {
                        maximoNegativo = n;
                        primerNegativo = true;
                    }
                    else if (n > maximoNegativo)
                        maximoNegativo = n;
                }           
                else if (n > 0)
                {
                    if (primerPositivo == false)
                    {
                        minimoPositivo = n;
                        primerPositivo = true;
                    }
                    else if (n < minimoPositivo)
                        minimoPositivo = n;
                }

                n = double.Parse(Console.ReadLine());       
            }

            Console.WriteLine("El máximo de los números negativos es: " + maximoNegativo);
            Console.WriteLine("El mínimo de los números positivos es: " + minimoPositivo);
        }
    }
}
