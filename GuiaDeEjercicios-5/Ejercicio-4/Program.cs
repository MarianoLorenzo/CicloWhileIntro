using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n = 0;

            Console.WriteLine("Ingrese dos números");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            if (n1 == n2 || (n2 == (n1 + 1)) || (n1 == (n2 + 1)))    
                Console.WriteLine("No hay números entre los dos números ingresados");
            else if (n1 < n2)
                {
                    n = n1 + 1;

                    while (n < n2)
                    {
                        Console.WriteLine(n + " está entre " + n1 + " y " + n2);
                        n ++;
                    }
                }
            else if (n2 < n1)
                {
                    n = n2 + 1;

                    while (n < n1)
                    {
                        Console.WriteLine(n + " está entre " + n2 + " y " + n1);
                        n ++;
                    }
                }        
        }
    }
}
