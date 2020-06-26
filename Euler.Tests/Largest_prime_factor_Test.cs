using Xunit;

namespace Euler.Tests
{

    public class Largest_prime_factor_Test
    {
        [Theory]
        [InlineData(13195, 29)]
        public void Should_Return_Largerst_Prime_Of_Factors(int factors, int expected)
        {
            var o = new Largest_prime_factor();
            var actual = o.Calculate(factors);

            Assert.Equal(expected, actual);
        }
    }
}
