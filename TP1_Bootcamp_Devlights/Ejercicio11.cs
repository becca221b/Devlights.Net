using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bootcamp_Devlights
{
    internal class Ejercicio11
    {
        /*
         11. Menú con switch: Crear un menú con opciones (1. Sumar, 2. Restar, 3. Multiplicar, 4.
        Dividir). Pedir dos números y ejecutar la operación elegida.
         */
        public void menu()
        {
            string texto;
            do
            {
                
                Console.WriteLine("Ingrese una opción: ");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                texto = Console.ReadLine();
                Console.WriteLine("Ingrese el primer numero: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                double num2 = double.Parse(Console.ReadLine());

                switch (texto)
                {
                    case "1":
                        Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
                        break;
                    case "2":
                        Console.WriteLine("El resultado de la resta es: " + (num2 - num1));
                        break;
                    case "3":
                        Console.WriteLine("El resultado de la multiplicación es: " + (num1 * num2));
                        break;
                    case "4":
                        Console.WriteLine("El resultado de la división es: " + (num1 / num2));
                        break;
                    case "5":
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no valida");
                        break;
                }

            } while (texto != "5");
        }
    }
}
