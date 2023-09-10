namespace Biblioteca
{
    public class Validador
    {
        /// <summary>
        /// Solicita al usuario el ingreso de un valor numérico entero
        /// </summary>
        /// <returns>Un dígito de tipo string</returns>
        public static string ingresarValor()
        {
            string numeroString;
            Console.WriteLine("Ingrese un número entero: ");
            numeroString = Console.ReadLine();
            
            return numeroString;
        }

        /// <summary>
        /// Parsea un sitring ingresado por usuario a un entero
        /// </summary>
        /// <returns>Número entero</returns>
        public static int? parsearAEntero(string numeroString)
        {
            int? numero;
            {
                try
                {
                    numero = int.Parse(numeroString);
                    return numero;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato de número inválido. Debe ser un entero");
                    return null;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("El número es demasiado grande o chico");
                    return null;
                }
            
            }
        }
    }
}