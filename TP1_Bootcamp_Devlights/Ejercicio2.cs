using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bootcamp_Devlights
{
    internal class Ejercicio2
    {
        public void compararNumeros()
        {
            

            int[] inputs = ValidateIntInput.validarEntrada(3);
            int menor= inputs[0];
            int mayor = inputs[0];
            for (int i = 1; i < inputs.Length; i++) {
                if (inputs[i] < menor) { 
                    menor = inputs[i];
                }
                if (inputs[i] > mayor)
                {
                    mayor = inputs[i];
                }
            }

            Console.WriteLine($"El menor valor es: {menor}");
            Console.WriteLine($"El mayor valor es: {mayor}");

        }
    }
}
