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

var materialInventario =
    materiales.Join(
        inventarios,
        m => new
        {
            m.Codigo,
            m.Almacen,
            m.Centro
        },
        i => new
        {
            i.Codigo,
            i.Almacen,
            i.Centro
        },
        (m, i) => new
        {
            Material = m,
            Inventario = i
        });

var reporte =
    materialInventario.Join(
        categorias,
        mi => new
        {
            mi.Material.Codigo,
            mi.Material.Almacen
        },
        c => new
        {
            c.Codigo,
            c.Almacen
        },
        (mi, c) => new
        {
            mi.Material.Codigo,
            mi.Material.Descripcion,
            Categoria = c.CategoriaNombre,
            mi.Inventario.Existencia,
            mi.Material.Centro,
            mi.Material.Almacen
        });

foreach (var item in reporte)
{
    Console.WriteLine(
        $"{item.Codigo} | " +
        $"{item.Descripcion} | " +
        $"{item.Categoria} | " +
        $"{item.Existencia} | " +
        $"{item.Almacen} | " +
        $"{item.Centro}");
}