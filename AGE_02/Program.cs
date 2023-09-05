using System.Runtime.Versioning;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("¿Qué categoría desea? :");
        Console.WriteLine(" (A) 3 estrellas");
        Console.WriteLine(" (B) 5 estrellas");
        char catetip = char.Parse(Console.ReadLine());

        Console.WriteLine("¿Cuál es su tiempo de estadía (en días)?: ");
        int dias = int.Parse(Console.ReadLine());

        double tarifadiaria = 0;

        switch (catetip)
        {
            case 'A':
            case 'a':
                if (dias >= 1 && dias >= 5)
                {
                    tarifadiaria = 100;
                }
                if (dias>=6 && dias>=10)
                {
                    tarifadiaria = 85;
                }
                if (dias >= 11)
                {
                    tarifadiaria = 70;
                }
                break;
            case 'B':
            case 'b':
                if (dias >= 1 && dias >= 5)
                {
                    tarifadiaria = 300;
                }
                if (dias >= 6 && dias >= 10)
                {
                    tarifadiaria = 270;
                }
                if (dias >= 11)
                {
                    tarifadiaria = 250;
                }
                break;
            default:
                Console.WriteLine("Categoría de hotel no válida.");
                return;
        }
        double costobase = tarifadiaria* dias;
        double desayuno = 7* dias;
        double total = costobase + desayuno;

        Console.WriteLine("El costo total del hospedaje es: S/"+total);

    }
}