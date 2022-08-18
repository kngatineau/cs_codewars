namespace cs_codewars;
/* first kata in C#, opted for the 'old school',
more universal way of solving this */

public static class Kata
{
    public static int Solution(int value)
    {
        int sum = 0;
        if (value < 0)
        {
            return 0;
        }
        
        for (int i = 1; i < (value / 3); i++)
        {
            if (3 * i < value && (3 * i) % 5 != 0)
            {
                sum += (3 * i);
            }
            if (5 * i < value)
            {
                sum += (5 * i);
            }
        }
        return sum;
    }

    static void Main(string[] args)
    {
        Solution(20);
    }
}

/* Best Practice Solution: as of August 18

using System.Linq;
public static class Kata
{
  public static int Solution(int n)
  {
   return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
   }
}
*/