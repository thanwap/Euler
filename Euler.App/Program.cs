
using System;
using System.Collections.Generic;
using System.Linq;
using Euler.Algorithm;

namespace Euler.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = QuickSort.Sort(new List<int>(){3, 2, 1, 9, 5, 4});
            result.ForEach(x => Console.WriteLine(x + " "));
        }

        public static int Sum(List<int> list)
        {
            if (list.Count == 0)
            {
                return 0;
            }
            return list[0] + Sum(list.Skip(1).ToList());
        }

        public static int Count(List<int> list)
        {
            if (list.Count == 0)
            {
                return 0;
            }

            return 1 + Count(list.Skip(1).ToList());
        }

        public static int Max(List<int> list)
        {
            if(list.Count == 0){
                return 0;
            }
            else if(list.Count == 1){
                return list[0];
            }
            else if (list.Count == 2)
            {
                return list[0] > list[1] ? list[0] : list[1];
            }
            var subMax = Max(list.Skip(1).ToList());
            return list[0] > subMax ? list[0] : subMax;
        }
    }
}
