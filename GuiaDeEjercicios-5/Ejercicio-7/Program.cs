using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, maximo = 0, contadorN = 0, posicion = 0;

            Console.WriteLine("Ingrese números, hasta que presione el cero");
            n = double.Parse(Console.ReadLine());

            contadorN ++;

            while (n != 0)
            {
                if (contadorN == 1)
                {
                    maximo = n;
                    posicion = contadorN;
                }   
                else if (n > maximo)
                {
                    maximo = n;
                    posicion = contadorN;
                }
                      
                n = double.Parse(Console.ReadLine());

                contadorN ++;
            }

            Console.WriteLine("El mayor número ingresado es: " + maximo);
            Console.WriteLine("Fue ingresado en la posición: " + posicion);
        }
    }
}
