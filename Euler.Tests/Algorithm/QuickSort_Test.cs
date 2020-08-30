using System.Collections.Generic;
using Euler.Algorithm;
using Xunit;

namespace Euler.Tests.Algorithm
{
    public class QuickSort_Test
    {
        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new List<int>(){3, 2, 1, 9, 5, 4}, new List<int>(){1, 2, 3, 4, 5, 9}},
            new object[] {new List<int>(){3, 2, 1}, new List<int>(){  1, 2, 3}},
            new object[] {new List<int>(){1}, new List<int>(){1}}
        };

        [Theory]
        [MemberData(nameof(Data))]
        public void Sort_Array_Should_SortedAsc(List<int> list, List<int> expectedList) {
            var result = QuickSort.Sort(list);

            for (int i = 0; i < list.Count; i++)
            {
                Assert.Equal(expectedList[i], result[i]);
            }
        }
    }
}