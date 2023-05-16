using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contadorDivisor = 2, contadorNoPrimo = 0;
            

            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());

            while (contadorDivisor < n)
            {
                if (n % contadorDivisor == 0)
                    contadorNoPrimo ++;

                contadorDivisor++;    
            }

            if (contadorNoPrimo == 0)
                Console.WriteLine(n + " es un número primo");
            else 
                Console.WriteLine(n + " NO es un número primo");  
        }
    }
}
