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

var barato =
    materiales.OrderBy(m => m.Precio)
              .FirstOrDefault();

var caro =
    materiales.OrderByDescending(m => m.Precio)
              .FirstOrDefault();

Console.WriteLine($"Material más barato: {barato?.Descripcion} - Precio: {barato?.Precio}");
Console.WriteLine($"Material más caro: {caro?.Descripcion} - Precio: {caro?.Precio}");

var materialesCaros =
    materiales.Where(m => m.Precio > 10)
              .OrderBy(m => m.Precio)
              .ToList();

foreach (var material in materialesCaros)
{
    Console.WriteLine($"Material caro: {material.Descripcion} - Precio: {material.Precio}");
}