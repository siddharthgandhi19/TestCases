namespace FindMaximumNumber
{
    public class FindMaxNum
    {
        public int FindMaxInteger(int a, int b, int c)
        {
            if (a > b && a > c)
                return a;
            if (b > c && b > a)
                return b;
            else
                return c;

        }
    }
}