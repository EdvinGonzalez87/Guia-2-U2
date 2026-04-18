internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculadora");

        Console.WriteLine("Ingrese el primer numero:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Seleccione una opcion:");
        Console.WriteLine("1 - Sumar");
        Console.WriteLine("2 - Restar");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");

        int opcion = Convert.ToInt32(Console.ReadLine());
        double resultado;

        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case 2:
                resultado = num1 - num2;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case 3:
                resultado = num1 * num2;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine("Resultado: " + resultado);
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre 0");
                }
                break;

            default:
                Console.WriteLine("Opcion no valida (1-4)");
                break;
        }
    }
}