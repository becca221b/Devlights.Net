using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bootcamp_Devlights
{
    internal class Ejercicio7
    {
        //Número dentro de rango: Pedir un número y verificar si está dentro del rango 1–100
        //(inclusive).
        public bool rango()
        {
            Console.WriteLine("Ingrese un numero");
            string inputNumber = Console.ReadLine();

            double decimalValue;
            bool isInRange = false;
            if (double.TryParse(inputNumber, out decimalValue))
            {
                
                if (decimalValue >= 0 && decimalValue <= 100) {
                    Console.WriteLine("está dentro del rango 1–100");
                    isInRange = true;
                }
                else
                {
                    Console.WriteLine("NO está dentro del rango 1–100");
                    
                }
                
            }
            else
            {
                Console.WriteLine("valor no válido");
            }
            return isInRange;
        }
    }
}
