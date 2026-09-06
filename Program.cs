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
        Descripcion = "Tornillo"
    },

    new Material
    {
        Codigo = "1002",
        Almacen = "QRO",
        Centro = "C001",
        Descripcion = "Tuerca"
    },

    new Material
    {
        Codigo = "1003",
        Almacen = "MTY",
        Centro = "C002",
        Descripcion = "Taladro"
    },

    new Material
    {
        Codigo = "1004",
        Almacen = "MTY",
        Centro = "C002",
        Descripcion = "Martillo"
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


// Cuál es el precio más alto de los 3 materiales más caros de cada categoría?

var reporte =
    materiales
        .Join(
            inventarios,
            m => m.Codigo,
            i => i.Codigo,
            (m, i) => new
            {
                m.Codigo,
                m.Descripcion,
                m.Almacen,
                m.Centro,
                i.Existencia,
                Precio = i.Existencia * 10 // Supongamos que el precio es existencia * 10
            })
        .Join(categorias,
            mi => mi.Codigo,
            c => c.Codigo,
            (mi, c) => new      // mi es el resultado de la primera unión, c es el resultado de la segunda unión
            {
                mi.Codigo,
                mi.Descripcion,
                mi.Almacen,
                mi.Centro,
                mi.Existencia,
                mi.Precio,
                c.CategoriaNombre
            })
        .GroupBy(m => m.CategoriaNombre)
        .Select(grupo => new
        {
            Categoria = grupo.Key,
            PrecioMaximo = grupo.OrderByDescending(m => m.Precio)
                                .Take(3)
                                .Max(m => m.Precio)
        });

foreach (var item in reporte)
{
    Console.WriteLine($"Categoría: {item.Categoria}, Precio Máximo de los 3 materiales más caros: {item.PrecioMaximo}");
}