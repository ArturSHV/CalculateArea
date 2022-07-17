using Library;


class Program
{
    public static void Main()
    {
        double s = 0;
        

        Console.WriteLine("Введите 1, если хотите вычислить площадь треугольника");

        Console.WriteLine("Введите 2, если хотите вычислить площадь круга");

        string a = Console.ReadLine();

        s = s.Calculate(a);

        Console.WriteLine("Площадь равна " + s);
    }
}