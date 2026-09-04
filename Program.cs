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

// ordena los materiales por descripción
var codigos1 =
    materiales.OrderBy(m => m.Descripcion);

// ordena los materiales por descripción y luego por precio
var codigos2 =
    materiales.OrderBy(m => m.Descripcion)
              .ThenBy(m => m.Precio);

// imprime los códigos de los materiales ordenados por descripción
foreach (var codigo in codigos1)
{
    Console.WriteLine($"Código: {codigo.Codigo}, Descripción: {codigo.Descripcion}");

}

// imprime los códigos de los materiales ordenados por descripción y luego por precio
foreach (var codigo in codigos2)
{
    Console.WriteLine($"Código: {codigo.Codigo}, Descripción: {codigo.Descripcion}, Precio: {codigo.Precio}");
}

var codigos3 = 
    materiales.Select(m => new { m.Codigo, m.Descripcion, m.Precio })
              .OrderBy(m => m.Descripcion)
              .ThenBy(m => m.Precio);

// imprime los códigos de los materiales ordenados por descripción y luego por precio
foreach (var codigo in codigos3)
{
    Console.WriteLine($"Código: {codigo.Codigo}, Descripción: {codigo.Descripcion}, Precio: {codigo.Precio}");
}