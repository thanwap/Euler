using System;
using Euler.Algorithm;
using Xunit;

namespace Euler.Tests.Algorithm
{
    public class SelectionSort_Test
    {
        [Fact]
        public void Swap_Array_Should_Return_Swap_Array(){
            var arr = new int[] {1,2,3};
            Assert.Equal(1, arr[0]);
            Assert.Equal(2, arr[1]);
            SelectionSort.Swap(arr, 0, 1);
            Assert.Equal(2, arr[0]);
            Assert.Equal(1, arr[1]);
            Assert.Equal(3, arr[2]);
        }

        [Theory]
        [InlineData(new int[]{3, 2, 1, 9, 5, 4}, new int[]{  1, 2, 3, 4, 5, 9})]
        [InlineData(new int[]{3, 2, 1}, new int[]{  1, 2, 3})]
        [InlineData(new int[]{2, 1}, new int[]{ 1, 2})]
        [InlineData(new int[]{1, 2}, new int[]{ 1, 2})]
        [InlineData(new int[]{1}, new int[]{1})]
        public void Sort_Array_Should_SortedAsc(int[] arr, int[] expectedArr) {
            SelectionSort.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Assert.Equal(expectedArr[i], arr[i]);
            }
        }
    }
}