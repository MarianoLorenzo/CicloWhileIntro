using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, menor = 0, contadorN = 0, segMenor = 0, posicionMenor = 0, posicionSegMenor = 0;

            Console.WriteLine("Ingrese, por lo menos, tres números hasta presionar el cero");
            n = double.Parse(Console.ReadLine());  

            while (n != 0)
            {    
                contadorN ++;

                if (contadorN == 1)
                {
                    menor = n;
                    posicionMenor = contadorN;
                }                   
                else if (contadorN == 2)
                {
                    if (n < menor)
                    {
                        segMenor = menor;
                        posicionSegMenor = 1;
                        menor = n;
                        posicionMenor = contadorN;
                    }
                    else if (n > menor) 
                    {
                        segMenor = n;
                        posicionSegMenor = 2;
                    }                                        
                }
                else
                    if (n < menor)
                    {
                        segMenor = menor;
                        posicionSegMenor = posicionMenor;
                        menor = n;
                        posicionMenor = contadorN;
                    }
                    else if (n > menor && n < segMenor)
                    {
                        segMenor = n;
                        posicionSegMenor = contadorN;
                    }
                        
                
                n = double.Parse(Console.ReadLine());                  
            }

            if (contadorN < 3)
                Console.WriteLine("No ingresó, por lo menos, tres números distintos a cero");
            else 
            {
                Console.WriteLine("El número menor es: " + menor + " y fue ingresado en la posición " + posicionMenor);
                Console.WriteLine("El segundo número menor es: " + segMenor + " y fue ingresado en la posición " + posicionSegMenor);
            }    
        }
    }
}
