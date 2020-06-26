using Xunit;

namespace Euler.Tests
{
    public class Even_Fibonacci_numbers_Test
    {
        [Theory]
        [InlineData(8, 10)]
        [InlineData(400, 188)]

        public void Should_Return_Sum_Even_Of_Fibonacci(int max, int expected)
        {
            var f = new Even_Fibonacci_numbers();

            var actual = f.Calculate(max);

            Assert.Equal(expected, actual);
        }
    }
}
