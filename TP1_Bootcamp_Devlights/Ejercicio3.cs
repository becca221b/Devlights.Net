using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bootcamp_Devlights
{
    internal class Ejercicio3
    {
        public void multiplosDe3()
        {

            int[] inputs = ValidateIntInput.validarEntrada(2);
           
            if (inputs[0] % inputs[1] == 0)
            {
                Console.Write($"{inputs[0]} es multiplo de {inputs[1]}");
            }
            else
            {
                Console.Write($"{inputs[0]} NO es multiplo de {inputs[1]}");
            }

        }

        
    }
}
