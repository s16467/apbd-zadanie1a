namespace WebApplication1;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{Environment.NewLine}Zadanie 1: ");
        Console.WriteLine("Hello World");
        
        Console.WriteLine($"{Environment.NewLine}Zadanie 2: ");
        Console.WriteLine("Modification 1");
        Console.WriteLine("Modification 2");
        Console.WriteLine("Modification 3");
        
        
        Console.WriteLine($"{Environment.NewLine}Zadanie3: ");
        Console.WriteLine("Policz śrenią liczb:");
        int[] numbers = { 2, 4, 6, 8, 10 };
        double average = WebApplication1.AverageNum.CalculateAverage(numbers);
        Console.WriteLine("Średnia liczb wynosi: " + average);
    }
}