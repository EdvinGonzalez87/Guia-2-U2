internal class Program
{
    private static void Main(string[] args)
    {
        int sector, cantidad;
        double precio = 0, total;

        Console.WriteLine("===== ESTADIO =====");
        Console.WriteLine("1  Palco (Q300.00)");
        Console.WriteLine("2  Tribuna (Q100 - Q125)");
        Console.WriteLine("3  Preferencia (Q50 - Q75)");
        Console.WriteLine("4  Generales (Q30 - Q50)");
        Console.Write("Seleccione el sector: ");
        sector = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la cantidad de entradas: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        switch (sector)
        {
            case 1:
                precio = 300;
                break;

            case 2:
                Console.Write("Ingrese el precio (100 - 125): ");
                precio = Convert.ToDouble(Console.ReadLine());
                if (precio < 100 || precio > 125)
                {
                    Console.WriteLine("Precio fuera de rango");
                    return;
                }
                break;

            case 3:
                Console.Write("Ingrese el precio (50 - 75): ");
                precio = Convert.ToDouble(Console.ReadLine());
                if (precio < 50 || precio > 75)
                {
                    Console.WriteLine("Precio fuera de rango");
                    return;
                }
                break;

            case 4:
                Console.Write("Ingrese el precio (30 - 50): ");
                precio = Convert.ToDouble(Console.ReadLine());
                if (precio < 30 || precio > 50)
                {
                    Console.WriteLine("Precio fuera de rango");
                    return;
                }
                break;

            default:
                Console.WriteLine("Opcion no valida");
                return;
        }

        total = precio * cantidad;

        Console.WriteLine("Total a pagar: Q" + total);
    }
}
