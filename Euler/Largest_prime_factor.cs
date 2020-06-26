namespace Euler
{
    public class Largest_prime_factor
    {
        public int Calculate(long factors)
        {
            int l = 5;
            int n = 5;
            long fac = 1;

            while (fac < factors)
            {
                if (factors % n == 0)
                {
                    l = n;
                    fac *= l;
                }

                n++;
            }

            return l;
        }
    }
}
