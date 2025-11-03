/*
 Diccionario de calificaciones: Crear un diccionario donde la clave sea el nombre del
    alumno y el valor sea su nota. El programa debe permitir:
    a. Agregar alumnos y sus notas.
    b. Mostrar el promedio general del curso.
    c. Indicar el alumno con mejor nota y el de peor nota.
    d. Hint: usar Dictionary<string, double> y recorrer con foreach
*/
class Program
{
    static void Main()
    {
        //Ejercicio9();
        Extra();
    }
    static void Ejercicio9() {
        var calificaciones = new Dictionary<string, double>();
        
        while (true)
        {
            Console.Write("Ingrese el nombre del alumno (o 'salir' para terminar): ");
            string nombre = Console.ReadLine();
            if (nombre.ToLower() == "salir") break;
            Console.Write("Ingrese la nota del alumno: ");
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                calificaciones[nombre] = nota;
            }
            else
            {
                Console.WriteLine("Nota inválida. Intente de nuevo.");
            }
        }
        
        Console.WriteLine($"El promedio es de {calificaciones.Values.Average().ToString("F2")}");

        var mejorNota = calificaciones.MaxBy(kv => kv.Value);
        var peorNota = calificaciones.MinBy(kv => kv.Value);

        Console.WriteLine($"El alumno con mejor nota es {mejorNota.Key} con una nota de {mejorNota.Value}");
        Console.WriteLine($"El alumno con peor nota es {peorNota.Key} con una nota de {peorNota.Value}");

    }
    /*
     Inventario con múltiples colecciones: Diseñar un sistema de inventario básico
    usando distintas colecciones:
        a. Un List<string> con los productos disponibles.
        b. Un Dictionary<string, int> para registrar el stock de cada producto.
        c. Un Stack<string> para llevar el historial de acciones realizadas (agregar,
        quitar, vender).
        d. El programa debe permitir:
        i. Agregar un producto y su cantidad.
        ii. Vender un producto (restando stock).
        iii. Mostrar el inventario actual.
        iv. Mostrar las últimas 3 acciones registradas.
        e. Hint: combina listas, diccionarios y pilas para manipular distintos tipos de
        información.
     */
    static void Extra()
    {
        List<string> productos = new List<string>();
        Dictionary<string, int> stock = new Dictionary<string, int>();
        Stack<string> historial = new Stack<string>();
       
        
        string[] opciones = { "Agregar producto", "Vender producto", "Mostrar inventario", "Mostrar últimas 3 acciones", "Salir" };
        bool seguir = true;

        while (seguir)
        {
            Console.WriteLine("Qué acción desea realizar?");
            for (int i = 0; i < opciones.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {opciones[i]}");
            }
            Console.Write("Seleccione una opción: ");
            if (int.TryParse(Console.ReadLine(), out int opcion) && opcion >= 1 && opcion <= opciones.Length)
            {
                
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nombre del producto: ");
                        string producto = Console.ReadLine();
                        Console.Write("Ingrese la cantidad: ");
                        if (int.TryParse(Console.ReadLine(), out int cantidad))
                        {
                            productos.Add(producto);
                            stock[producto] = cantidad;
                            historial.Push($"Agregado {cantidad} de {producto}");
                        }
                        break;
                    case 2:
                        Console.Write("Ingrese el nombre del producto a vender: ");
                        string prodVender = Console.ReadLine();
                        Console.Write("Ingrese la cantidad del producto a vender: ");
                        int cantidadVender = int.Parse(Console.ReadLine());
                        if (stock.ContainsKey(prodVender) && stock[prodVender] > cantidadVender)
                        {
                            stock[prodVender] = stock[prodVender]-cantidadVender;
                            historial.Push($"Vendido {cantidadVender} de {prodVender}");
                        }
                        else
                        {
                            Console.WriteLine("Producto no disponible o con stock insuficiente.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Inventario actual:");
                        foreach (var item in stock)
                        {
                            Console.WriteLine($"{item.Key}: {item.Value}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Últimas 3 acciones:");
                        foreach (var accion in historial.Take(3))
                        {
                            Console.WriteLine(accion);
                        }
                        break;
                    case 5:
                        seguir = false;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción inválida. Intente de nuevo.");
            }
        }
    }
}
