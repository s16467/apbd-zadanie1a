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
        
        Console.WriteLine($"{Environment.NewLine}Zadanie4: ");
        int[] numbers1 = { 2, 44, 16, 8, 10 };
        int max = WebApplication1.MaxNum.FindMax(numbers1);
        Console.WriteLine("Maksymalna wartość w tablicy: " + max);
    }
}