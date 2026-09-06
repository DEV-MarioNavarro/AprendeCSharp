using System;
using System.Collections.Generic;
using AprendeCSharp;

using System.Text.Json;


// crea una lista de materiales
List<Material> materiales = new List<Material>()
{
    new Material
    {
        Codigo = "1001",
        Almacen = "QRO",
        Centro = "C001",
        Descripcion = "Tornillo",
        Precio = 1.5m
    },

    new Material
    {
        Codigo = "1002",
        Almacen = "QRO",
        Centro = "C001",
        Descripcion = "Tuerca",
        Precio = 0.5m
    },

    new Material
    {
        Codigo = "1003",
        Almacen = "MTY",
        Centro = "C002",
        Descripcion = "Taladro",
        Precio = 50m
    },

    new Material
    {
        Codigo = "1004",
        Almacen = "MTY",
        Centro = "C002",
        Descripcion = "Martillo",
        Precio = 10m
    }
};

List<Inventario> inventarios = new List<Inventario>()
{
    new Inventario
    {
        Codigo = "1001",
        Almacen = "QRO",
        Centro = "C001",
        Existencia = 150
    },

    new Inventario
    {
        Codigo = "1002",
        Almacen = "QRO",
        Centro = "C001",
        Existencia = 200
    },

    new Inventario
    {
        Codigo = "1003",
        Almacen = "MTY",
        Centro = "C002",
        Existencia = 50
    },

    new Inventario
    {
        Codigo = "1004",
        Almacen = "MTY",
        Centro = "C002",
        Existencia = 75
    }
};

List<Categoria> categorias = new List<Categoria>()
{
    new Categoria
    {
        Codigo = "1001",
        Almacen = "QRO",
        CategoriaNombre = "Ferreteria"
    },

    new Categoria
    {
        Codigo = "1002",
        Almacen = "QRO",
        CategoriaNombre = "Ferreteria"
    },

    new Categoria
    {
        Codigo = "1003",
        Almacen = "MTY",
        CategoriaNombre = "Herramienta"
    },

    new Categoria
    {
        Codigo = "1004",
        Almacen = "MTY",
        CategoriaNombre = "Herramienta"
    }
};


//Tomar una colección y convertirla en un único resultado acumulando valores.
// Aggregate() te permite definir tu propia lógica de acumulación.

var resultado =
    materiales.Aggregate(
        "",
        (acumulado, material) =>
            acumulado + material.Descripcion + ", ");

Console.WriteLine(resultado);

var total =
    materiales.Aggregate(
        0m,
        (acumulado, material) =>
            acumulado + material.Precio);

Console.WriteLine(total);
