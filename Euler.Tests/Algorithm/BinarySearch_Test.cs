using System.Security.Cryptography.X509Certificates;
namespace Euler.Tests.Algorithm
{
    using Euler.Algorithm;
    using Xunit;

    public class BinarySearch_Test
    {
        [Fact]
        public void List_Null_Or_Empty_Should_Return_Null(){
            Assert.Null(BinarySearch.FindIndex(new int[]{}, 0));
            Assert.Null(BinarySearch.FindIndex(null, 1));
        }

        [Theory]
        [InlineData(new int[] {1,2,3,4,5}, 3, 2)]
        [InlineData(new int[] {1,2,3,4,5}, 1, 0)]
        [InlineData(new int[] {1,2,3,4,5}, 5, 4)]
        [InlineData(new int[] {1,2,3,4,5}, 6, null)]
        [InlineData(new int[] {1,2,3,4,5}, -1, null)]
        public void List_Should_Return_index(int[] list, int number ,int? expected){
            Assert.Equal(expected, BinarySearch.FindIndex(list, number));
        }
    }
}