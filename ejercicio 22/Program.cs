string claveCorrecta = "admin123";
string intento = "";
while (intento != claveCorrecta)
{
    Console.Write("Ingrese la contraseña: ");
    intento = Console.ReadLine();
    if (intento != claveCorrecta)
    {
        Console.WriteLine("Contraseña incorrecta. Intente de nuevo.\n");
    }
}
Console.WriteLine("¡Acceso concedido!");