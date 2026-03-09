Console.Write("Ingrese un número entero: ");
long numero = Math.Abs(long.Parse(Console.ReadLine()));
int contadorDigitos = 0;
if (numero == 0)
{
    contadorDigitos = 1;
}
else
{
    while (numero > 0)
    {
        numero = numero / 10;
        contadorDigitos++;
    }
}
Console.WriteLine($"El número tiene {contadorDigitos} dígitos.");