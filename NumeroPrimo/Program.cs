using System;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            // Contador de divisores
            int contadorDivisores = 0;

            // Verificar número de divisores
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contadorDivisores++;
                }
            }

            // Un número primo tiene exactamente 2 divisores: 1 y el mismo número
            if (contadorDivisores == 2)
            {
                Console.WriteLine("El número " + numero + " es primo.");
            }
            else
            {
                Console.WriteLine("El número " + numero + " no es primo.");
            }
        }

    }
}
