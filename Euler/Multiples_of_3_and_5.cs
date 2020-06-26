namespace Euler
{
    public class Multiples_of_3_and_5
    {
        public int CalculateBelow(int number)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
