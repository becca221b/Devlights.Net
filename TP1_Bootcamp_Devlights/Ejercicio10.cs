using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bootcamp_Devlights
{
    internal class Ejercicio10
    {
        public void diaSemana()
        {
            //Día de la semana con switch: Pedir un número del 1 al 7 y mostrar el día de la
            //semana correspondiente.
            Console.WriteLine("Ingrese el numero del 1 al 7");
            bool result = int.TryParse(Console.ReadLine(), out int dia);
            if(result ) {
                switch (dia)
                {   
                    case 1:
                        Console.WriteLine("Domingo");
                        break;
                    case 2:
                        Console.WriteLine("Lunes");
                        break;
                    case 3:
                        Console.WriteLine("Martes");
                        break;
                    case 4:
                        Console.WriteLine("Miércoles");
                        break;
                    case 5:
                        Console.WriteLine("Jueves");
                        break;
                    case 6:
                        Console.WriteLine("Viernes");
                        break;
                    case 7:
                        Console.WriteLine("Sábado");
                        break;
                    default: Console.WriteLine("Opción no válida"); break;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número entero");
            }
        }
    }
}
