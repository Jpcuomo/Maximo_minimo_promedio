using Biblioteca;
using System.Collections.Concurrent;
using System.Net.NetworkInformation;

namespace EjercicioI01_max_min_promedio
{
    internal class Program
    {
        static string valorString;
        static int? numero;
        static int ? numeroMax = null;
        static int? numeroMin = null;
        static double promedio = 0;
        static int sumaNumeros = 0;
        static int iteraciones = 5;

        static void Main(string[] args)
        {
            for (int i = 0; i < iteraciones; i++) 
            {
                do
                {
                    valorString = Validador.ingresarValor();
                    numero = Validador.parsearAEntero(valorString);
                } while (!(numero.HasValue));

                numeroMax = Calculos.CalcularMaximo(numero, numeroMax);
                numeroMin = Calculos.CalcularMinimo(numero, numeroMin);
                sumaNumeros += (int)numero;
            }
            
            promedio = (double)sumaNumeros / iteraciones;

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Máximo: {numeroMax}");
            Console.WriteLine($"Mínimo: {numeroMin}");
            Console.WriteLine($"Promedio: {promedio:N2}");
            Console.WriteLine("Fin del programa!");
        }
    }
}