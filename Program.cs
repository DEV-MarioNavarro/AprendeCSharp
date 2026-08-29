// See https://aka.ms/new-console-template for more information

List<string> materiales = new List<string>{
    "Tornilos",
    "Tuerca",
    "Arandela",
    "Rondana",
    "Pija",
};

Console.WriteLine("=== Catálogo de materiales ===");

foreach (var material in materiales)
{
    Console.WriteLine(material);
}