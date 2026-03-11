namespace Cw2;

public class StatisticsHelper
{
    public static int GetMin(int[] numbers)
    {
        int min = numbers[0];
        foreach (int n in numbers)
        {
            if (n < min)
                min = n;
        }
        return min;
    }

    public static double GetAverage(int[] values)
    {
        double sum = 0;
        foreach (int n in values)
        {
            sum += n;
        }
        return sum / values.Length;
    }

    public static int CalculateMax(int[] values)
    {
        return values.Max();
    }

    public static int CalculateMin2(int[] values)
    {
        return 0;
    }
}