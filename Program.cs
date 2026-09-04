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

// selecciona los códigos de los materiales usando LINQ
var codigos =
    materiales.Select(m => new { 
        m.Codigo,
        m.Descripcion,
        PrecioConIVA = m.Precio * 1.16m
    });

// imprime los códigos de los materiales
foreach (var codigo in codigos)
{
    Console.WriteLine($"Código: {codigo.Codigo}, Descripción: {codigo.Descripcion}, Precio con IVA: {codigo.PrecioConIVA}");

}

