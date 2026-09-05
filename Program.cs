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
        Precio = 10.5m,
        Categoria = "Ferretería"
    },
    new Material
    {
        Codigo = "M002",
        Descripcion = "Material 2",
        Precio = 20.0m,
        Categoria = "Ferretería"
    },
    new Material
    {
        Codigo = "M003",
        Descripcion = "Material 3",
        Precio = 15.75m,
        Categoria = "Ferretería"
    },
    new Material
    {
        Codigo = "M004",
        Descripcion = "Material 4",
        Precio = 5.0m,
        Categoria = "Herramienta"
    },
    new Material
    {
        Codigo = "M005",
        Descripcion = "Material 5",
        Precio = 30.0m,
        Categoria = "Herramienta"
    },
    new Material
    {
        Codigo = "M006",
        Descripcion = "Material 6",
        Precio = 25.0m,
        Categoria = "Ferreteria"
    },
    new Material
    {
        Codigo = "M007",
        Descripcion = "Material 7",
        Precio = 8.0m,
        Categoria = "Herramienta"
    },
    new Material
    {
        Codigo = "M008",
        Descripcion = "Material 8",
        Precio = 12.0m,
        Categoria = "Herramienta"
    }
};

// El precio más alto de los 3 materiales más caros cuyo precio sea mayor a 10.

var precioMaximo =
    materiales
        .Where(m => m.Precio > 10)
        .OrderByDescending(m => m.Precio)
        .Take(3)
        .Max(m => m.Precio);

Console.WriteLine(
    $"Precio máximo: {precioMaximo}");