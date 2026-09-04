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

var primeros =
    materiales.Where(m => m.Precio > 15)
              .OrderBy(m => m.Descripcion)
              .Select(m => new
              {
                    m.Codigo,
                    m.Descripcion,
                    m.Precio
              })
              .Take(2);

foreach (var material in primeros)
{
    Console.WriteLine($"Código: {material.Codigo}, Descripción: {material.Descripcion}, Precio: {material.Precio}");
}