using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Clasificaciones");
        Console.WriteLine("Ingrese su letra de calificacion");
        Char letra = Convert.ToChar(Console.ReadLine().ToUpper());
        switch (letra)
        {
            case 'A':
                Console.WriteLine("Exelente");
                break;
            case 'B':
                Console.WriteLine("Bueno");
                break;
            case 'C':
                Console.WriteLine("Regular");
                break;
            case 'D':
                Console.WriteLine("Deficiente");
                break;
            case 'F':
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Digite una letra valida A, B, C, D, F");
                break;
        }
    }
}