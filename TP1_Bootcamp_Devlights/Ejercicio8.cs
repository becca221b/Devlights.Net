using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bootcamp_Devlights
{
    internal class Ejercicio8
    {
        //Operador ternario: Pedir un número y mostrar "Par" o "Impar" usando el operador
        //ternario.
        public void ternario()
        {
            Console.WriteLine("Ingrese un numero");
            var inputNumber = Console.ReadLine();

            double decimalValue;
            string result;
            
            if (double.TryParse(inputNumber, out decimalValue))
            {
                result = (decimalValue%2)== 0 ? "Par" : "Impar";
                
            }
            else
            {
                Console.WriteLine("valor no válido");
            }
        }
    }
}
