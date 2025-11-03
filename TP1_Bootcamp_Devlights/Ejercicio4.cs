using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bootcamp_Devlights
{
    internal class Ejercicio4
    {
        //Descuento en tienda: Pedir el precio de un producto y aplicar un descuento del 10%
        //si el precio es mayor a $1000.
        public double discount()
        {
            string inputPrice;
            double finalPrice;
            bool result;
            
            Console.WriteLine("Ingrese el precio del producto");
            inputPrice = Console.ReadLine();

            result = int.TryParse(inputPrice, out int price);
            finalPrice = price;

            if (result == true)
            {
                if (price > 1000)
                {
                    finalPrice = price - (0.1 * price);
                }
                Console.WriteLine($"El precio final es {finalPrice}");
                
            }
            else
            {
                Console.WriteLine("Debe ingresar un número");
            }
            return finalPrice;
        }


    }
}
