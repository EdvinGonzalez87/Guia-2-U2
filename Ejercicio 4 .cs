internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Menu de comida");
        Console.WriteLine("Ingrese una opcion:");
        Console.WriteLine("1 - Hamburguesa");
        Console.WriteLine("2 - Pizza");
        Console.WriteLine("3 - Pollo frito");
        Console.WriteLine("4 - Ensalada");

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Usted ha pedido Hamburguesa");
                break;

            case 2:
                Console.WriteLine("Usted ha pedido Pizza");
                break;

            case 3:
                Console.WriteLine("Usted ha pedido Pollo frito");
                break;

            case 4:
                Console.WriteLine("Usted ha pedido Ensalada");
                break;

            default:
                Console.WriteLine("Digite una opcion valida: 1, 2, 3 o 4");
                break;
        }
    }
}