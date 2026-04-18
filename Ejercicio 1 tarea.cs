internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el angulo en grados: ");
        double grados = Convert.ToDouble(Console.ReadLine());

        // Convertir a radianes
        double radianes = grados * Math.PI / 180;

        Console.WriteLine("Seleccione una opcion:");
        Console.WriteLine("1 → Seno");
        Console.WriteLine("2 → Coseno");
        Console.WriteLine("3 → Tangente");

        int opcion = Convert.ToInt32(Console.ReadLine());
        double resultado;

        switch (opcion)
        {
            case 1:
                resultado = Math.Sin(radianes);
                Console.WriteLine("Seno: " + resultado);
                break;

            case 2:
                resultado = Math.Cos(radianes);
                Console.WriteLine("Coseno: " + resultado);
                break;

            case 3:
                resultado = Math.Tan(radianes);
                Console.WriteLine("Tangente: " + resultado);
                break;

            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }
}