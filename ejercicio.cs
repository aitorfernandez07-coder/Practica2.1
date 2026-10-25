bool salir = false;
string carpetaDatos = "Datos";

Directory.CreateDirectory(carpetaDatos);

while (!salir)
{
    Console.Clear();

    Console.WriteLine("==== MENU DE OPCIONES ====");
    Console.WriteLine("1. Crear nuevo fichero.");
    Console.WriteLine("2. Añadir nuevo registro.");
    Console.WriteLine("3. Eliminar todos los registros.");
    Console.WriteLine("4. Eliminar el fichero.");
    Console.WriteLine("5. Visualizar registros.");
    Console.WriteLine("6. Cerrar aplicación.");
    Console.WriteLine();
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine() ?? string.Empty;

    switch (opcion)
    {
        case "1":
        {
            string rutaFichero = ObtenerRutaFichero();

            if (rutaFichero == string.Empty)
            {
                Console.WriteLine("El nombre del fichero no es válido.");
            }
            else if (File.Exists(rutaFichero))
            {
                Console.WriteLine("Ya existe un fichero con ese nombre.");
            }
            else
            {
                File.WriteAllText(rutaFichero, string.Empty);
                Console.WriteLine("Fichero creado correctamente.");
            }

            break;
        }

        case "2":
        {
            string rutaFichero = ObtenerRutaFichero();

            if (rutaFichero == string.Empty)
            {
                Console.WriteLine("El nombre del fichero no es válido.");
            }
            else if (!File.Exists(rutaFichero))
            {
                Console.WriteLine("No existe un fichero con ese nombre.");
            }
            else
            {
                Console.Write("Escriba el registro que desea añadir: ");
                string registro = Console.ReadLine() ?? string.Empty;
                File.AppendAllText(rutaFichero, registro + Environment.NewLine);
                Console.WriteLine("Registro añadido correctamente.");
            }

            break;
        }

        case "3":
        {
            string rutaFichero = ObtenerRutaFichero();

            if (rutaFichero == string.Empty)
            {
                Console.WriteLine("El nombre del fichero no es válido.");
            }
            else if (!File.Exists(rutaFichero))
            {
                Console.WriteLine("No existe un fichero con ese nombre.");
            }
            else
            {
                File.WriteAllText(rutaFichero, string.Empty);
                Console.WriteLine("Se han eliminado todos los registros.");
            }

            break;
        }

        case "4":
        {
            string rutaFichero = ObtenerRutaFichero();

            if (rutaFichero == string.Empty)
            {
                Console.WriteLine("El nombre del fichero no es válido.");
            }
            else if (!File.Exists(rutaFichero))
            {
                Console.WriteLine("No existe un fichero con ese nombre.");
            }
            else
            {
                File.Delete(rutaFichero);
                Console.WriteLine("Fichero eliminado correctamente.");
            }

            break;
        }

        case "5":
        {
            string rutaFichero = ObtenerRutaFichero();

            if (rutaFichero == string.Empty)
            {
                Console.WriteLine("El nombre del fichero no es válido.");
            }
            else if (!File.Exists(rutaFichero))
            {
                Console.WriteLine("No existe un fichero con ese nombre.");
            }
            else
            {
                string[] registros = File.ReadAllLines(rutaFichero);

                if (registros.Length == 0)
                {
                    Console.WriteLine("El fichero no contiene registros.");
                }
                else
                {
                    Console.WriteLine("Registros del fichero:");

                    for (int i = 0; i < registros.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {registros[i]}");
                    }
                }
            }

            break;
        }

        case "6":
            salir = true;
            Console.WriteLine("Aplicación cerrada.");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    if (!salir)
    {
        Console.WriteLine();
        Console.WriteLine("Pulse una tecla para continuar...");
        Console.ReadKey();
    }
}

string ObtenerRutaFichero()
{
    Console.Write("Indique el nombre del fichero: ");
    string nombreFichero = (Console.ReadLine() ?? string.Empty).Trim();

    if (nombreFichero == string.Empty || nombreFichero.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
    {
        return string.Empty;
    }

    return Path.Combine(carpetaDatos, nombreFichero + ".txt");
}
