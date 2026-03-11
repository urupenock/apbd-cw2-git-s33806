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
}