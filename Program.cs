using System;
using System.Collections.Generic;
using AprendeCSharp;

using System.Text.Json;

class Program
{
    static void Main()
    {
        // Serialiazación de un objeto Material a JSON
        Console.WriteLine("Serialización de un objeto Material a JSON:");

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

        string jsonOutput = JsonSerializer.Serialize(
            materiales,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        Console.WriteLine($"Material en formato JSON: {jsonOutput}");

        // Deserialización de JSON a un objeto Material
        string jsonInput = """
            [
              {
                "Codigo": "MAT101",
                "Descripcion": "Taladro",
                "Precio": 150.00
              },
              {
                "Codigo": "MAT102",
                "Descripcion": "Broca",
                "Precio": 25.00
              },
              {
                "Codigo": "MAT103",
                "Descripcion": "Martillo",
                "Precio": 75.00
              }
            ]
            """;

        Console.WriteLine($"\nDeserialización de JSON a un objeto Material: {jsonInput}");

        List<Material>? materialesDeserializados = 
            JsonSerializer.Deserialize<List<Material>>(jsonInput);

        if (materialesDeserializados != null)
        {
            foreach (var material in materialesDeserializados)
            {
                Console.WriteLine($"Código: {material.Codigo}, Descripción: {material.Descripcion}, Precio: {material.Precio}");
            }
        }   

    }

}
