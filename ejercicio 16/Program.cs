int numero = -1;
while (numero != 0)
{
    Console.Write("Ingrese un número (0 para salir): ");
    numero = int.Parse(Console.ReadLine());

    if (numero != 0)
    {
        Console.WriteLine($"Ingresaste el: {numero}");
    }
}
Console.WriteLine("Programa finalizado.");