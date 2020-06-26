using Xunit;

namespace Euler.Tests
{
    public class Multiples_of_3_and_5_Test
    {
        [Theory]
        [InlineData(10, 23)]
        public void Should_Return_Sum_Of_Below_Number(int below, int expected)
        {
            var multiple = new Multiples_of_3_and_5();

            var actual = multiple.CalculateBelow(below);

            Assert.Equal(expected, actual);
        }
    }
}
