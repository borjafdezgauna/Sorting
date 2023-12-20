using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{

    public class TestFile
    {
        public void Harl()
        {
            /*Mi número mágico es éste de aquí*/
        }
        public void Harl2()
        {

            // Solicitar al usuario que ingrese un número entero no negativo
            Console.Write("Ingresa un número entero no negativo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verificar si el número ingresado es no negativo
            if (numero < 0)
            {
                Console.WriteLine("El número debe ser no negativo.");
            }
            else
            {
                // Calcular y mostrar el factorial del número ingresado
                long factorial = CalcularFactorial(numero);
                Console.WriteLine($"El factorial de {numero} es: {factorial}");
            }
        }

        /// <summary>
        /// Calcula el factorial de un número.
        /// </summary>
        /// <param name="n">Número para el cual se calculará el factorial.</param>
        /// <returns>Factorial del número.</returns>
        static long CalcularFactorial(int n)
        {
            // Verificar si el número es 0, en cuyo caso el factorial es 1
            if (n == 0)
            {
                return 1;
            }
            else
            {
                // Inicializar el resultado del factorial como 1
                long resultado = 1;

                // Calcular el factorial multiplicando sucesivamente por números desde 1 hasta n
                for (int i = 1; i <= n; i++)
                {
                    resultado *= i;
                }

                // Devolver el resultado del factorial
                return resultado;
            }
        }

    }
}
