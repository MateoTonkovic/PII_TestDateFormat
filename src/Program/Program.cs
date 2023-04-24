namespace TestDateFormat;

/// <summary>
/// El programa principal.
/// </summary>
public static class Program
{
    /// <summary>
    /// Punto de entrada al programa principal.
    /// </summary>
    public static void Main()
    {
        string testDate = "10/11/1997";

        if (DateFormatter.CheckFormat(testDate))
        {
            Console.WriteLine($"{testDate} tiene el formato correcto.");
        }
        else
        {
            Console.WriteLine($"{testDate} no tiene el formato correcto.");
        }

        if (DateFormatter.CheckIfBlank(testDate))
        {
            Console.WriteLine($"{testDate} está en blanco.");
        }
        

        Console.WriteLine($"{testDate} se convierte a {DateFormatter.ChangeFormat(testDate)}");
    }
}