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

// Quieres conocer el precio promedio de los 3 materiales más caros cuyo precio sea mayor a 10.
var promedio =
    materiales
        .Where(m => m.Precio > 10)
        .OrderByDescending(m => m.Precio)
        .Take(3)
        .Average(m => m.Precio);

Console.WriteLine(
    $"Promedio de los 3 materiales más caros: {promedio:F3}");