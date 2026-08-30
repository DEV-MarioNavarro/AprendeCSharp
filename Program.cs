
static string ObtenerDescripcion(string codigo)
{
    switch (codigo)
    {
        case "1001":
            return "Tornillo";

        case "1002":
            return "Tuerca";

        default:
            return "No encontrado";
    }
}

string descripcion = ObtenerDescripcion("1002");

Console.WriteLine(descripcion);