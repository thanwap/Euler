using Xunit;

namespace Euler.Tests
{
    public class Sum_square_difference_Test
    {
        public Sum_square_difference _o;

        public Sum_square_difference_Test()
        {
            _o = new Sum_square_difference();
        }

        [Theory]
        [InlineData(10, 385)]
        public void Should_Return_Sum_Of_Square(int number, int expected)
        {
            var actual = _o.SumSquare(number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 3025)]
        public void Should_Return_Squre_Of_Sum(int number, int expected)
        {
            var actual = _o.SquareSum(number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2640)]
        public void Should_Return_Different_OfSqueare_And_Sum(int number, int expected)
        {
            var actual = _o.Diff(number);

            Assert.Equal(expected, actual);
        }
    }
}
