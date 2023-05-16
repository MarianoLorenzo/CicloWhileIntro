using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, menor = 0, contadorN = 0, segMenor = 0;

            Console.WriteLine("Ingrese, por lo menos, tres números hasta presionar el cero");
            n = double.Parse(Console.ReadLine());  

            while (n != 0)
            {    
                contadorN ++;

                if (contadorN == 1)
                    menor = n;
                else if (contadorN == 2)
                {
                    if (n < menor)
                    {
                        segMenor = menor;
                        menor = n;
                    }
                    else if (n > menor)                   
                        segMenor = n;
                }
                else
                    if (n < menor)
                    {
                        segMenor = menor;
                        menor = n;
                    }
                    else if (n > menor && n < segMenor)
                        segMenor = n;
                
                n = double.Parse(Console.ReadLine());                  
            }

            if (contadorN < 3)
                Console.WriteLine("No ingresó, por lo menos, tres números distintos a cero");
            else 
            {
                Console.WriteLine("El número menor es: " + menor);
                Console.WriteLine("El segundo número menor es: " + segMenor);
            }    
        }
    }
}
