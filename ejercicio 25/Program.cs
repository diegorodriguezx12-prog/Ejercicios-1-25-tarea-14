int opcion = 0;
while (opcion != 3)
{
    Console.WriteLine("--- MENÚ CON WHILE ---");
    Console.WriteLine("1. Saludar");
    Console.WriteLine("2. Ver fecha actual");
    Console.WriteLine("3. Salir");
    Console.Write("Seleccione una opción: ");
    opcion = int.Parse(Console.ReadLine());
    if (opcion == 1)
    {
        Console.WriteLine("¡Hola! Estás usando un ciclo while.");
    }
    else if (opcion == 2)
    {
        Console.WriteLine("Hoy es: ");
    }
    else if (opcion == 3)
    {
        Console.WriteLine("Saliendo del programa...");
    }
    else
    {
        Console.WriteLine("Opción no válida.");
    }
}