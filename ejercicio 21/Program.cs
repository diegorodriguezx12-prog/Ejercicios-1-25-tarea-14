int suma = 0;
int numero;
Console.WriteLine("Ingresa números para sumar. El programa se detendrá al superar 100.");
while (suma <= 100)
{
    Console.Write($"Suma actual ({suma}). Ingrese un número: ");
    numero = int.Parse(Console.ReadLine());
    suma += numero;
}
Console.WriteLine("¡Límite superado!");
Console.WriteLine($"La suma final es: {suma}");