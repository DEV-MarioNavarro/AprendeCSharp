// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresa el material:");

string? material = Console.ReadLine();

switch (material)
{
    case "1001":
        Console.WriteLine("Tornillo");
        break;

    case "1002":
        Console.WriteLine("Tuerca");
        break;

    case "1003":
        Console.WriteLine("Arandela");
        break;

    default:
        Console.WriteLine("Material no encontrado");
        break;
}