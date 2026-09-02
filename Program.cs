using System;
using System.Collections.Generic;
using AprendeCSharp;

using System.Text.Json;

class Program
{
    static void Main()
    {
        Material material1 = new Material
        {
            Codigo = "MAT001",
            Descripcion = "Tuercas",
            Precio = 10.5m
        };

        Material material2 = new Material
        {
            Codigo = "MAT002",
            Descripcion = "Pinzas",
            Precio = 35m
        };

        Material material3 = new Material
        {
            Codigo = "MAT003",
            Descripcion = "Desarmador",
            Precio = 22m
        };

        List<Material> materiales = new List<Material>();

        materiales.Add(material1);
        materiales.Add(material2);
        materiales.Add(material3);

        var materialesFiltrados =
            materiales.Where(m => m.Precio > 30)
                      .ToList();

        Console.WriteLine(materiales.Count); // Imprime 3
        foreach (var material in materialesFiltrados)
        {
            Console.WriteLine(material.Descripcion);
        }

        // m: representa la lista de materiales
        // m.Precio > 20: representa la condifición del código del material que se está buscando
        // al final .ToList() convierte en una lista de materiales que cumplen con la condición

        //List<Material> materialesCaros = 
        //    materiales.Where(m => 
        //        m.Precio > 20 &&
        //        m.Codigo == "MAT003" &&
        //        m.Descripcion.Contains("Des"))
        //    .ToList();

        //foreach (Material material in materialesCaros)
        //{
        //    Console.WriteLine($"Código: {material.Codigo}, Descripción: {material.Descripcion}, Precio: {material.Precio}");
        //}

        // m: representa la lista de materiales
        // m.codigo == "MAT002": representa la condifición del código del material que se está buscando

        //Material? materialEncontrado =
        //    materiales.FirstOrDefault(m => m.Codigo == "MAT002");

        //if (materialEncontrado != null)
        //{
        //    Console.WriteLine(materialEncontrado.Descripcion);
        //}   



    }

}
