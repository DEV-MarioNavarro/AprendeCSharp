using System;
using System.Collections.Generic;
using AprendeCSharp;

using System.Text.Json;


// crea una lista de materiales
List<Material> materiales = new List<Material>()
{
    new Material
    {
        Codigo = "M001",
        Descripcion = "Material 1",
        Precio = 10.5m
    },

    new Material
    {
        Codigo = "M002",
        Descripcion = "Material 2",
        Precio = 20.0m
    },

    new Material
    {
        Codigo = "M003",
        Descripcion = "Material 3",
        Precio = 15.75m
    }
};

// verifica si existe un material con el código "M002"
bool existe =
    materiales.Any(m => m.Codigo == "M002");

if (existe)
{
    Console.WriteLine("El material con código M002 existe en la lista.");
}else
    {
    Console.WriteLine("El material con código M002 no existe en la lista.");
}

// verifica si existe un material con el código "M004"
if (materiales.Any(m => m.Codigo == "M004"))
{
    Console.WriteLine("El material con código M004 existe en la lista.");
}
else
{
    Console.WriteLine("El material con código M004 no existe en la lista.");
}