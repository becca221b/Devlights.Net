using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bootcamp_Devlights
{
    internal class Ejercicio5
    {
        //5. Conversión de tipo: Pedir un número decimal y convertirlo a entero (usando
        //conversión explícita). Mostrar ambos valores y comentar la diferencia.
        public void convertir()
        {
            
            Console.WriteLine("Ingrese el precio del producto");
            string input = Console.ReadLine();

            bool result = double.TryParse(input, out double inputDouble);
            
            if (result == true)
            {
                int outputInt = (int)inputDouble;
                Console.WriteLine($"El valor entero es {outputInt}");
                Console.WriteLine($"El valor decimal es {inputDouble}");
                Console.WriteLine($"La direncia es: {(inputDouble- outputInt).ToString("F2")}");
            }
            else
            {
                Console.WriteLine("Debe ingresar un número");
            }
            
        }
    }
}
