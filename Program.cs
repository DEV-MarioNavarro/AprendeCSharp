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

// Obtén por categoría:
   
// Solo materiales con precio mayor a 10
// Ordenados descendente por precio
// Tomar únicamente los 2 más caros de cada categoría
// Calcular el precio promedio
// Mostrar la categoría, cantidad y promedio

var reporte =
    materiales
        .Where(m => m.Precio > 10)
        .GroupBy(m => m.Categoria)
        .Select(grupo => new
        {
            Categoria = grupo.Key,

            Cantidad = grupo
                .OrderByDescending(m => m.Precio)
                .Take(2)
                .Count(),

            Promedio = grupo
                .OrderByDescending(m => m.Precio)
                .Take(2)
                .Average(m => m.Precio)
        });

foreach (var item in reporte)
{
    Console.WriteLine(
        $"Categoria: {item.Categoria}");

    Console.WriteLine(
        $"Cantidad: {item.Cantidad}");

    Console.WriteLine(
        $"Promedio: {item.Promedio:F3}");

    Console.WriteLine();
}