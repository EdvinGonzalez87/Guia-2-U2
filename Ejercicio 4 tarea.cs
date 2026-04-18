internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        double valor, metros, pies, cm, pulgadas;

        Console.WriteLine("===== CONVERSOR DE LONGITUD =====");
        Console.WriteLine("1 → Metros");
        Console.WriteLine("2 → Pies");
        Console.WriteLine("3 → Centimetros");
        Console.WriteLine("4 → Pulgadas");
        Console.Write("Seleccione la unidad: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el valor: ");
        valor = Convert.ToDouble(Console.ReadLine());

        // Convertir todo a metros primero
        switch (opcion)
        {
            case 1:
                metros = valor;
                break;
            case 2:
                metros = valor * 0.3048;
                break;
            case 3:
                metros = valor / 100;
                break;
            case 4:
                metros = valor * 0.0254;
                break;
            default:
                Console.WriteLine("Opcion no valida");
                return;
        }

        // Convertir desde metros a otras unidades
        pies = metros / 0.3048;
        cm = metros * 100;
        pulgadas = metros / 0.0254;

        Console.WriteLine("\n===== RESULTADOS =====");
        Console.WriteLine("Metros: " + metros);
        Console.WriteLine("Pies: " + pies);
        Console.WriteLine("Centimetros: " + cm);
        Console.WriteLine("Pulgadas: " + pulgadas);
    }
}