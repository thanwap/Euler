namespace Euler
{
    public class Even_Fibonacci_numbers
    {
        public int Calculate(int max)
        {
            var sum = 0;
            var f = 1;
            var prev = 1;
            var temp = 0;

            while (f <= max)
            {
                temp = f;
                f += prev;

                if (f % 2 == 0 && f <= max)
                {
                    sum += f;
                }

                prev = temp;
            }

            return sum;
        }
    }
}
