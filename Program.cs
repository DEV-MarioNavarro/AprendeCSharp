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

var total1 =
    materiales
        .OrderByDescending(m => m.Precio)
        .Take(3)
        .Sum(m => m.Precio);

Console.WriteLine(total1);

var total2 =
    materiales
        .Where(m => m.Descripcion.Contains("Material"))
        .Sum(m => m.Precio);

Console.WriteLine(total2);

var total3 =
    materiales
        .OrderBy(m => m.Descripcion)
        .Sum(m => m.Precio);

Console.WriteLine(total3);

var top2MasCaros =
    materiales
        .OrderByDescending(m => m.Precio)
        .Take(2)
        .Sum(m => m.Precio);

Console.WriteLine(
    $"Total de los 2 materiales más caros: {top2MasCaros}");