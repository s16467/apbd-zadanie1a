namespace WebApplication1;

public class AverageNum
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica liczb jest pusta lub null.");
        }
        
        int sumConflict = 0;
        foreach (int numConflict in numbers)
        {
            sumConflict += numConflict;
        }

        return (double)sumConflict / numbers.Length;
    }
}