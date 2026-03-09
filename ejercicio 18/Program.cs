Console.Write("Ingrese un número para calcular su factorial: ");
int n = int.Parse(Console.ReadLine());
long factorial = 1;
int i = n;
if (n < 0)
{
    Console.WriteLine("El factorial no está definido para números negativos.");
}
else
{
    while (i > 1)
    {
        factorial *= i;
        i--;
    }
    Console.WriteLine($"El factorial de {n} es: {factorial}");
}