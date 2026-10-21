bool salir = false;
string nombreFichero = "";

while (!salir)
{
    Console.Clear();

    Console.WriteLine("====MENU DE OPCIONES====");
    Console.WriteLine("1. Crear nuevo fichero.");
    Console.WriteLine("2. Añadir nuevo registro.");
    Console.WriteLine("3. Eliminar todos los registros.");
    Console.WriteLine("4. Eliminar el fichero.");
    Console.WriteLine("5. Visualizar registros existentes.");
    Console.WriteLine("6. Cerrar aplicación.");
    Console.WriteLine();
    Console.WriteLine("Seleccione una opción:");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            if (!Directory.Exists(@"Datos"))
            {
                Directory.CreateDirectory(@"Datos");
            }
            
            Console.WriteLine("Indique el nombre del fichero:");
            nombreFichero = Console.ReadLine();

            File.Create(@"Datos\" + nombreFichero + ".txt").Close();

            Console.WriteLine();
            Console.WriteLine("¡¡Fichero creado correctamente!!");

            break;
        case "2":

            break;

        case "3":

            break;

        case "4":

            break;

        case "5":

            break;

        case "6":
            salir = true;
            break;

        default:
            Console.WriteLine("¡¡Opción no válida!!");
            break;
    }

    if (!salir)
    {
        Console.WriteLine("Pulse una tecla para continuar...");
        Console.ReadKey();
    }
}
