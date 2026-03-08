int limiteTablas = 5;
int limiteMultiplicador = 10;
for (int i = 1; i <= limiteTablas; i++)
{
    Console.WriteLine($"--- Tabla del {i} ---");
    for (int j = 1; j <= limiteMultiplicador; j++)
    {
        int resultado = i * j;
        Console.WriteLine($"{i} x {j} = {resultado}");
    }
    Console.WriteLine();
}