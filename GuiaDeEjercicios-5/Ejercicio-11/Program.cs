using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contadorPositivo = 0, contadorNegativo = 0, contadorPar = 0, divisor = 2, contadorNoPrimo = 0, contadorPrimo = 0;

            Console.WriteLine("Ingrese números hasta presionar el cero");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {  
                if (n > 0)
                {
                    contadorPositivo ++;

                    while (divisor < n)
                    {
                        if (n % divisor == 0)
                            contadorNoPrimo ++;        
                    
                        divisor ++;
                    }

                    divisor = 2;

                    if (contadorNoPrimo == 0)
                        contadorPrimo ++;
                }
                else 
                    contadorNegativo ++;        

                if (n % 2 == 0)
                    contadorPar ++;  

                contadorNoPrimo = 0;    

                n = int.Parse(Console.ReadLine());
            }

            if (contadorPrimo == 0)
                Console.WriteLine("No ingresó números primos");
            else if (contadorPrimo == 1)
                Console.WriteLine("Se ingresó " + contadorPrimo + " número primo");
            else 
                Console.WriteLine("Se ingresaron " + contadorPrimo + " números primos");   

            if (contadorPar == 0)
                Console.WriteLine("No ingresó números pares"); 
            else if (contadorPar == 1)
                Console.WriteLine("Se ingresó " + contadorPar + " número par");
            else 
                Console.WriteLine("Se ingresaron " + contadorPar + " números pares");    

            if (contadorPositivo == 0)
                Console.WriteLine("No ingresó números positivos"); 
            else if (contadorPositivo == 1)
                Console.WriteLine("Se ingresó " + contadorPositivo + " número positivo");
            else 
                Console.WriteLine("Se ingresaron " + contadorPositivo + " números positivos");    

             if (contadorNegativo == 0)
                Console.WriteLine("No ingresó números negativos"); 
            else if (contadorNegativo == 1)
                Console.WriteLine("Se ingresó " + contadorNegativo + " número negativo");
            else 
                Console.WriteLine("Se ingresaron " + contadorNegativo + " números negativos");   
        }
    }
}
