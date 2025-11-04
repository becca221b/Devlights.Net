
class Program
{
    static void Main()
    {
        Ejercicio1();
        //Ejercicio2();
        //Ejercicio3();
        //Ejercicio4();
        //Ejercicio5();
        //Ejercicio6();
        //Ejercicio7();
        //Ejercicio8();
        //Ejercicio9();
        //Extra();
    }
    /*
     1. Dado que se tiene almacenado en una lista, los resultados de los últimos 10
    exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10 notas de
    los exámenes y el promedio resultante.
     */
    static void Ejercicio1()
    {
        List<double> list = new List<double>() { 10, 5, 6, 7, 8, 9, 6, 8, 9, 5 };
        double result = 0;
        int contador = 0;

        foreach (double d in list)
        {
            contador++;
            result += d;
            Console.WriteLine($"Nota {contador}: {d}");
        }
        Console.WriteLine($"El promedio es de {result / list.Count}");
    }
    /*
     2. Dada las edades de 20 personas guardadas en una lista, imprimir por pantalla
     cuántos son mayores de edad y cuántos no.
     */
    static void Ejercicio2()
    {
        Random random = new Random();

        List<int> listEdades = new List<int>();

        for (int i = 0; i < 20; i++)
        {
            listEdades.Add(random.Next(12, 65));
        }

        int mayores = 0;
        int menores = 0;
        foreach (int edad in listEdades)
        {
            Console.Write(edad + " ");
            if (edad >= 18)
            {
                mayores++;
            }
            else
            {
                menores++;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Hay {mayores} mayores de edad");
        Console.WriteLine($"Hay {menores} menores de edad");
    }

    /*
     3. Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y el que
     tenga menos letras de todos.
     */
    static void Ejercicio3()
    {
        //Dado una lista de nombres de estudiantes,
        //imprimir el que tenga más letras, y el que
        //tenga menos letras de todos.
        List<string> list = new List<string>() { "Connor", "John", "Sarah" };


        string mayor = list.MaxBy(s => s.Length);
        Console.WriteLine(mayor);

        string menor = list.MinBy(s => s.Length);
        Console.WriteLine(menor);
    }

    /*
     4. Crear una variable para guardar los nombres de elementos para una “lista de
        supermercado”. Solicitar al usuario que ingrese el nombre de un elemento que va a
        comprar en el super y verificar que el elemento esté en la lista. Si no está, agregarlo
        e indicar que no estaba. Si está, quitarlo de la lista, y avisar que sí estaba. Al
        finalizar mostrar por pantalla los elementos que no compró y los que compró, pero
        no estaban en la lista. Si se quiere, mostrar también todos los elementos que el
        usuario compró. Para salir el usuario debe ingresar “fin”.
      */
    static void Ejercicio4()
    {
        //Crear una variable para guardar los nombres de elementos para una “lista de
        //supermercado”. Solicitar al usuario que ingrese el nombre de un elemento que va a
        //comprar en el super y verificar que el elemento esté en la lista. Si no está, agregarlo
        //e indicar que no estaba. Si está, quitarlo de la lista, y avisar que sí estaba.Al
        //finalizar mostrar por pantalla los elementos que no compró y los que compró, pero
        //no estaban en la lista.Si se quiere, mostrar también todos los elementos que el
        //usuario compró.Para salir el usuario debe ingresar “fin”.

        List<string> listaSuper = new List<string>() { "fruta", "huevo" };
        List<string> listaNueva = new List<string>();

        string item = "";
        while (item != "fin")
        {
            Console.WriteLine("Agregue un elemento a la lista del super. Si desea finalizar ingrese la palabra fin: ");

            item = Console.ReadLine().ToLower();
            if (item != "fin")
            {
                if (!listaSuper.Contains(item))
                {
                    Console.WriteLine("Ese elemento no está en la lista");
                    listaNueva.Add(item);
                }
                else
                {
                    Console.WriteLine($"{item} sí estaba en la lista");
                    listaNueva.Add(item);
                    listaSuper.Remove(item);
                }
            }

        }

        Console.WriteLine("Los items comprados fueron: ");
        foreach (string element in listaNueva)
        {
            Console.WriteLine($"{element}");
        }
        Console.WriteLine($"Los items no comprados fueron: ");
        foreach (string element in listaSuper)
        {
            Console.WriteLine($"{element}");
        }
    }

     /*
     5. Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en lugares
        pares. Imprimir la matriz por pantalla
     */
    static void Ejercicio5()
    {
        //Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en lugares
        //pares.Imprimir la matriz por pantalla
        string[,] matriz = new string[5, 5];
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (i % 2 == 0 && j % 2 == 0)
                {
                    matriz[i, j] = "P";
                }
                else
                {
                    matriz[i, j] = "I";
                }
                Console.Write($"{matriz[i, j]}");
            }
            Console.WriteLine();
        }
    }

    /*
    6. Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los días de
    la semana. La estructura es para registrar la temperatura diaria de una cabina de
    pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la matriz de forma
    aleatoria para el mes de mayo donde el primer día inicia en lunes y el último (31) se
    ubica en el miércoles (la matriz puede ser inicializada con valores aleatorios desde el
    principio del programa, no es necesario pedir los valores al usuario para cada
    posición). Se nos pide hacer lo siguiente:
    a. Obtener la temperatura más alta y baja de la semana y que día se produjo
    (lunes, martes, etc.)
    b. Promedio de temperatura de la semana.
    c. Temperatura más alta del mes y su día.
     */
    static void Ejercicio6()
    {
        int[,] matriz = new int[5, 7];
        Random random = new Random();
        int mayorIndex;
        int menorIndex;
        int mayor;
        int menor;
        int sumatoria;
        int mayorDelMes = 0;
        int mayorDelMesIndex = 0;
        string[] diasSemana = ["lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo"];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            mayorIndex = 6;
            menorIndex = 0;
            mayor = 0;
            menor = 38;
            sumatoria = 0;
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (!(i == 4 && j > 2))
                {
                    matriz[i, j] = random.Next(7, 38);

                    Console.Write($"{matriz[i, j]}, ");
                    if (matriz[i, j] > mayor)
                    {
                        mayor = matriz[i, j];
                        mayorIndex = j;

                    }
                    if (matriz[i, j] < menor)
                    {
                        menor = matriz[i, j];
                        menorIndex = j;
                    }
                    sumatoria += matriz[i, j];
                }

            }
            Console.WriteLine();
            Console.WriteLine($"La mayor temp de la semana es: {mayor} y ocurrió el día {diasSemana[mayorIndex]}");
            Console.WriteLine($"La menor temp de la semana es: {menor} y ocurrió el día {diasSemana[menorIndex]}");
            Console.WriteLine($"El promedio de temp es de {sumatoria / 7}");
            Console.WriteLine();
            if (mayorDelMes < mayor)
            {

                mayorDelMes = mayor;
                mayorDelMesIndex = mayorIndex;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"La mayor temp del mes es {mayorDelMes} y ocurrió un día {diasSemana[mayorDelMesIndex]}");
    }

    /*
    7. Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la primera
    fila y la primera columna se debe guardar los números (de 0 a 9), estando el cero en
    la primera posición (fila 0, columna 0). El resto de los lugares debe ser calculado
    usando los números que se dispone, por ejemplo, en la fila 1, calcular 1*1, 1*2, 1*3,
    etc. usando las posiciones del array o arreglo. Al finalizar el cálculo, mostrar la matriz
    por pantalla
     */
    static void Ejercicio7()
    {
        int[,] matriz = new int[10,10];
    
        for(int i = 0; i<10; i++)
        {
            matriz[i,0] = i;
            matriz[0, i] = i;
        }
    
        for (int i = 1; i < matriz.GetLength(0); i++)
        {
            for (int j = 1; j < matriz.GetLength(1); j++)
            {
                matriz[i,j] = i * j;
            }
          
        }
    
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {  
                Console.Write(matriz[i, j] + ", ");
            }
            Console.WriteLine();
            matriz[i, 0] = i;
            matriz[0, i] = i;
        }
    
    }

/*
 8. Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la
cantidad que el programador decida, pero no más de la mitad de los lugares
disponibles en la matriz). El usuario deberá ingresar el lugar donde cree que hay una
X, ingresando la fila y la columna por separado. Informar si acertó o no por cada
ingreso. Se debe pedir al usuario ingresar valores por tantas X que se haya
guardado. El usuario tiene 3 intentos para fallar. Al finalizar (Ya sea porque se
terminaron los 3 intentos, o el jugador acertó todas las X) imprimir por pantalla la
matriz con sus correspondientes X, mostrando un * donde no haya nada.
 */
    static void Ejercicio8() {
        char [,] matriz = new char [10,10];
        Random random = new Random();
        int fila;
        int columna;
        
    
        for (int i = 0; i < 6; i++)
        {
            matriz.SetValue('X',random.Next(0,10), random.Next(0, 10));
        }
        
        int contador = 0;
        while ( contador< 3){
            Console.WriteLine($"Oportunidad numero {contador+1}");
            Console.WriteLine("Ingrese la fila donde cree que está la X");
            fila = int.Parse(Console.ReadLine());
    
            Console.WriteLine("Ingrese la fila donde cree que está la X");
            columna = int.Parse(Console.ReadLine());
    
            if (matriz[fila, columna].Equals('X'))
            {
                Console.WriteLine("Acertaste!") ;
            }
            else
            {
                Console.WriteLine("Fallaste");
            }
    
                contador++;
        }
    
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if(!matriz[i, j].Equals('X'))
                {
                    matriz[i, j] = '*';
                }
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
            
        }
    
    }


    /*
    9. Diccionario de calificaciones: Crear un diccionario donde la clave sea el nombre del
    alumno y el valor sea su nota. El programa debe permitir:
    a. Agregar alumnos y sus notas.
    b. Mostrar el promedio general del curso.
    c. Indicar el alumno con mejor nota y el de peor nota.
    d. Hint: usar Dictionary<string, double> y recorrer con foreach
    */
    static void Ejercicio9() {
            var calificaciones = new Dictionary<string, double>();
        
            while (true)
            {
                Console.Write("Ingrese el nombre del alumno o 'salir' para terminar: ");
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
    
    static void Ejercicio10()
    {
        Queue<string> cola = new Queue<string>();
        cola.Enqueue("Pepito");
        cola.Enqueue("Kike");
        cola.Enqueue("Pepa");
        
    
        while (cola.Count > 0) 
        {
            Console.WriteLine($"{cola.Dequeue()} está siendo atendido") ;
            Console.WriteLine($"Quedan {cola.Count} elementos");
        }
    
    }

    /*
     EXTRA
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
