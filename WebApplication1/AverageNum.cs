namespace WebApplication1;

public class AverageNum
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica liczb jest pusta lub null.");
        }
        
        int sumConfilict2 = 0;
        foreach (int numConflict2 in numbers)
        {
            sumConfilict2 += numConflict2;
        }

        return (double)sumConfilict2 / numbers.Length;
    }
}