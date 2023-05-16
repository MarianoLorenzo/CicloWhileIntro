using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (n <= 100)
            {
                Console.WriteLine(n);

                n = n += 5;
            }            
        }
    }
}
