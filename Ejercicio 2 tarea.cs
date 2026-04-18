internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un caracter:");
        char c = Convert.ToChar(Console.ReadLine());

        switch (c)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine("Es una vocal");
                break;

            default:
                if (c >= '0' && c <= '9')
                {
                    Console.WriteLine("Es un digito");
                }
                else
                {
                    Console.WriteLine("No es vocal ni digito");
                }
                break;
        }
    }
}