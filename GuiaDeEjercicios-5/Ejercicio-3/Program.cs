using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, contadorIngreso = 0;

            Console.WriteLine("Ingrese las edades");
            edad = int.Parse(Console.ReadLine());

            while (edad >= 18)
            {
                contadorIngreso ++;

                edad = int.Parse(Console.ReadLine());
            }
            
            if (contadorIngreso == 0)
                Console.WriteLine("No se registraron personas mayores de edad");
            else    
                Console.WriteLine("Se registraron " + contadorIngreso + " personas mayores de edad");
        }
    }
}
