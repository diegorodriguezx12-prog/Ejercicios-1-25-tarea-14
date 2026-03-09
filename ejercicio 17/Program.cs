int numero;
int contadorPositivos = 0;
do
{
    Console.Write("Ingrese un número (0 para salir): ");
    numero = int.Parse(Console.ReadLine());
    if (numero > 0)
    {
        contadorPositivos++;
    }

} while (numero != 0);
Console.WriteLine($"\nCantidad de números positivos ingresados: {contadorPositivos}");