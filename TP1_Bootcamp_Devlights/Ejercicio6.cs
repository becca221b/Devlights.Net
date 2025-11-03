using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bootcamp_Devlights
{
    internal class Ejercicio6
    {
        //Clasificación por edad: Pedir la edad y mostrar si la persona es niño, adolescente,
        //adulto o adulto mayor(usa if-else if-else).
        public void clasificarPorEdad()
        {
            Console.WriteLine("Ingrese la edad");
            string inputAge = Console.ReadLine();

            bool result = int.TryParse(inputAge, out int age);

            if (result == true && age>0)
            {
                if (age <= 12)
                {
                    Console.WriteLine("Niño");
                }
                if(age < 18 && age > 12)
                {
                    Console.WriteLine("Adolescente");
                }
                if (age < 65 && age >= 18)
                {
                    Console.WriteLine("Adulto");
                }
                else
                {
                    Console.WriteLine("Adulto mayor");
                }
            }
            else
            {
                Console.WriteLine("valor no válido");
            }
        }
    }
}
