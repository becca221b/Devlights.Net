using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bootcamp_Devlights
{
    internal class Ejercicio9
    {
        //Cálculo de impuestos: Pedir un ingreso anual y calcular el impuesto:
        public void calcularImpuesto()
        {
            Console.WriteLine("Ingrese un numero");
            string inputNumber = Console.ReadLine();

            double decimalValue;
            double impuesto=0;

            if (double.TryParse(inputNumber, out decimalValue))
            {
                
                if (decimalValue > 10000 && decimalValue< 50000) {
                    impuesto = decimalValue * 0.1;
                }
                else if(decimalValue >= 50000 )
                {
                    impuesto = decimalValue*0.2;
                }

            }
            else
            {
                Console.WriteLine("valor no válido");
            }
            Console.WriteLine($"Impuesto: {impuesto}");
        }
    }
    
}
