// See https://aka.ms/new-console-template for more information

List<string> materiales = new List<string>
{
"Tornillo",
"Tuerca",
"Arandela",
"Rondana",
"Pija"
};

Console.WriteLine("=== Catálogo de Materiales ===");

foreach (string material in materiales)
{
    Console.WriteLine(material);
}