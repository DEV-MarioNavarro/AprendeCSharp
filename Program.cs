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

        Material material = new Material
        {
            Codigo = "MAT001",
            Descripcion = "Material de ejemplo",
            Precio = 10.5m
        };

        string json = JsonSerializer.Serialize(
            material,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        Console.WriteLine($"Material en formato JSON: {json}");

        // Deserialización de JSON a un objeto Material
        Console.WriteLine("\nDeserialización de JSON a un objeto Material:");

        string jsonInput = """
            {
            "Codigo": "MAT002",
            "Descripcion": "Otro material",
            "Precio": 20.75
            }
            """;
        Console.WriteLine(jsonInput);

        Material? deserializedMaterial = JsonSerializer.Deserialize<Material>(jsonInput);
        if (deserializedMaterial != null)
        {
            Console.WriteLine($"Material deserializado: {deserializedMaterial.Codigo}, {deserializedMaterial.Descripcion}, {deserializedMaterial.Precio}");
        }

    }
}
