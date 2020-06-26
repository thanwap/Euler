namespace Euler
{
    public class Sum_square_difference
    {
        public int SumSquare(int number)
        {
            var result = 0;
            int i = 1;

            while (i <= number)
            {
                result += (i * i);
                i++;
            }

            return result;
        }

        public int SquareSum(int number)
        {
            int i = 1;
            int sum = 0;

            while (i <= number)
            {
                sum += i;
                i++;
            }

            return sum * sum;
        }

        public int Diff(int number)
        {
            return SquareSum(number) - SumSquare(number);
        }
    }
}
