using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Calculos
    {

        /// <summary>
        /// Calcula el número máximo ingresado
        /// </summary>
        /// <param name="valor">Número recibido a comparar con parámetro máximo</param>
        /// <param name="maximo">Valor que se asume como máximo y el cual se usa para comparar</param>
        /// <returns>Número entero</returns>
        public static int CalcularMaximo (int? valor, int? maximo)
        {  
            if (!maximo.HasValue)
            {
                maximo = valor.Value;
            }
            else
            {
                if(valor > maximo)
                {
                    maximo = valor.Value;
                }
            }
            return maximo.Value;
        }

        /// <summary>
        /// Calcula el número mínimo ingresado
        /// </summary>
        /// <param name="valor">Número recibido a comparar con parámetro mínimo</param>
        /// <param name="minimo">Valor que se asume como máximo y el cual se usa para comparar</param>
        /// <returns>Número entero</returns>
        public static int CalcularMinimo(int? valor, int? minimo)
        {
            if (!minimo.HasValue)
            {
                minimo = valor.Value;
            }
            else
            {
                if (valor < minimo)
                {
                    minimo = valor.Value;
                }
            }
            return minimo.Value;
        }
    }

    
}
