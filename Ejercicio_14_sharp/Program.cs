using System;

namespace Ejercicio_14_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un número: ");
            string numero = Console.ReadLine();
            
            int baseNumero = 10;
            int baseConversion = 2;

            string resultado = Convert.ToString(Convert.ToInt32(numero, baseNumero), baseConversion);
            Console.WriteLine("\nEl número " + numero + " en binario es: " + resultado);
        }
    }
}
