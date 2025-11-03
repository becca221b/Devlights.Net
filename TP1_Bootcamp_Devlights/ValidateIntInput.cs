using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bootcamp_Devlights
{
    public static class ValidateIntInput
    {
        public static int[] validarEntrada(int length)
        {
            int[] inputs = new int[length];
            for (int i = 0; i < inputs.Length; i++)
            {
                int numero;
                bool isValid = false;

                while (!isValid)
                {
                    Console.WriteLine("Ingrese un número");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out numero))
                    {
                        inputs[i] = numero;
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un número válido.");
                    }
                }

            }
            return inputs;
        }
    }
}
