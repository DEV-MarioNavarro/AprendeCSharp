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

//Por cada categoría:
//-Tomar los 2 materiales más caros
//- Calcular el total
//- Calcular el promedio 

var reporte =
    materiales
        .GroupBy(m => m.Categoria)
        .Select(grupo => new
        {
            Categoria = grupo.Key,

            Top2 = grupo
                .OrderByDescending(m => m.Precio)
                .Take(2),

            Total = grupo
                .OrderByDescending(m => m.Precio)
                .Take(2)
                .Sum(m => m.Precio),

            Promedio = grupo
                .OrderByDescending(m => m.Precio)
                .Take(2)
                .Average(m => m.Precio)
        });

foreach (var categoria in reporte)
{
    Console.WriteLine(
        $"Categoria: {categoria.Categoria}");

    foreach (var material in categoria.Top2)
    {
        Console.WriteLine(
            $"{material.Descripcion} - {material.Precio}");
    }

    Console.WriteLine(
        $"Total: {categoria.Total}");

    Console.WriteLine(
        $"Promedio: {categoria.Promedio:F3}");

    Console.WriteLine();
}

// Obtén las categorías cuyo promedio de los 2 materiales más caros sea mayor a 20.

var reporte2 =
    materiales
        .GroupBy(m => m.Categoria)
        .Select(grupo => new
        {
            Categoria = grupo.Key,

            Promedio = grupo
                .OrderByDescending(m => m.Precio)
                .Take(2)
                .Average(m => m.Precio)
        })
        .Where(x => x.Promedio > 20);
