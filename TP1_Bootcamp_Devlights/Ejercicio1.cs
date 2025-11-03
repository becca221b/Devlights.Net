using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bootcamp_Devlights
{
    internal class Ejercicio1
    {
        public void VerificarPositivoNegativo()
        {
            string input;
            bool result;
            
            
            do {
                Console.WriteLine("Ingrese un número");
                input = Console.ReadLine();

                result = int.TryParse(input, out int number);
                if (number > 0)
                {
                    Console.WriteLine("El numero ingresado es positivo");
                }
                else if (number < 0)
                {
                    Console.WriteLine("El numero ingresado es negativo");
                }
                else if (result && number == 0)
                {
                    Console.WriteLine("El numero ingresado es 0");
                }
                else
                {
                    Console.WriteLine("Debe ingresar un número");
                }
                
            }while (!result);
            
            
        }
        
    }
}
