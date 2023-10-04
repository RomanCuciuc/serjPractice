
using SerjPractice1.Refactoring;

public class Program
{
    public static void Main(string[] args)
    {
        new CountryService().StartDraw();
        Console.WriteLine("End program!");
        Console.ReadKey();
    }
}
