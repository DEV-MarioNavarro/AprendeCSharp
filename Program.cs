using AprendeCSharp;

//Primero creamos los materiales
Material material1 = new Material();

material1.Codigo = "1001";
material1.Descripcion = "Tornillo";
material1.Precio = 12.50m;

Material material2 = new Material();

material2.Codigo = "1002";
material2.Descripcion = "Tuerca";
material2.Precio = 8.50m;

// Luego los agregamos a la lista
List<Material> materiales = new List<Material>();

materiales.Add(material1);
materiales.Add(material2);

// luego, recorremos la lista
foreach (Material material in materiales)
{
    Console.WriteLine(material.Codigo);
    Console.WriteLine(material.Descripcion);
    Console.WriteLine(material.Precio);

    Console.WriteLine();
}

Console.WriteLine("Ingrese el código:");

string? codigo = Console.ReadLine();

foreach (Material material in materiales)
{
    if (material.Codigo == codigo)
    {
        Console.WriteLine(material.Descripcion);
        Console.WriteLine(material.Precio);
    }
}