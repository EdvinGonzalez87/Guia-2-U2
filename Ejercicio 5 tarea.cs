internal class Program
{
    private static void Main(string[] args)
    {
        int cantidad, opcion;
        double precioUnitario = 650;
        double iva = 0.12;
        double precioConIVA, totalSinDescuento, descuento = 0, totalPagar;
        string formaPago = "";

        // Calcular precio con IVA
        precioConIVA = precioUnitario + (precioUnitario * iva);

        Console.Write("Ingrese la cantidad de impresoras: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Seleccione la forma de pago:");
        Console.WriteLine("1 → Efectivo (10%)");
        Console.WriteLine("2 → Tarjeta de crédito (5%)");
        Console.WriteLine("3 → Vale de regalo (15%)");
        opcion = Convert.ToInt32(Console.ReadLine());

        // Total sin descuento (con IVA)
        totalSinDescuento = cantidad * precioConIVA;

        switch (opcion)
        {
            case 1:
                formaPago = "Efectivo";
                descuento = totalSinDescuento * 0.10;
                break;

            case 2:
                formaPago = "Tarjeta de credito";
                descuento = totalSinDescuento * 0.05;
                break;

            case 3:
                formaPago = "Vale de regalo";
                descuento = totalSinDescuento * 0.15;
                break;

            default:
                Console.WriteLine("Opcion no valida");
                return;
        }

        totalPagar = totalSinDescuento - descuento;

        Console.WriteLine("\n===== DETALLE DE PAGO =====");
        Console.WriteLine("Cantidad de impresoras: " + cantidad);
        Console.WriteLine("Precio unitario con IVA: Q" + precioConIVA);
        Console.WriteLine("Total sin descuento: Q" + totalSinDescuento);
        Console.WriteLine("Forma de pago: " + formaPago);
        Console.WriteLine("Descuento aplicado: Q" + descuento);
        Console.WriteLine("Total a pagar: Q" + totalPagar);
    }
}