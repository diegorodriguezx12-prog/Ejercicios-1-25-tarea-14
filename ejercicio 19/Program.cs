Console.Write("¿Qué tabla de multiplicar deseas ver?: ");
int tabla = int.Parse(Console.ReadLine());
int i = 1;
Console.WriteLine($"--- Tabla del {tabla} ---");
while (i <= 10)
{
    int resultado = tabla * i;
    Console.WriteLine($"{tabla} x {i} = {resultado}");
    i++;
}