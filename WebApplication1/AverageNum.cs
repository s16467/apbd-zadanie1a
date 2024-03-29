namespace WebApplication1;

public class AverageNum
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica liczb jest pusta lub null.");
        }
        
        int sum3 = 0;
        foreach (int num3 in numbers)
        {
            sum3 += num3;
        }

        return (double)sum3 / numbers.Length;
    }
}