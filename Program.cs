using System;
using System.Collections.Generic;
using AprendeCSharp;

using System.Text.Json;

HttpClient client = new();

string json = 
    await client.GetStringAsync(
        "https://jsonplaceholder.typicode.com/users");

//Console.WriteLine(json);

// Deserialize the JSON into a list of Usuario objects
//
// The '?' operator is used to indicate that the result can be null
// The '!' operator is used to indicate that the result will not be null
// This is safe here because we expect the API to return a valid JSON array
// If the API returns null or an invalid JSON, this will throw an exception

List<Usuario>? usuarios =
    JsonSerializer.Deserialize<List<Usuario>>(json);

var usuariosFiltrados =
    usuarios?
        .Where(u => u.id > 5)
        .OrderBy(u => u.name)
        .Take(3);
        
foreach (var usuario in usuariosFiltrados!)
{
    Console.WriteLine(
        $"{usuario.id} - {usuario.name}");
}