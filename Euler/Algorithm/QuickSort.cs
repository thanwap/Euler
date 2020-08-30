using System.Collections.Generic;
using System.Linq;

namespace Euler.Algorithm
{
    public static class QuickSort
    {
        public static List<int> Sort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }
            else if (list.Count == 2)
            {
                if (list[0] > list[1])
                {
                    int temp = list[1];
                    list[1] = list[0];
                    list[0] = temp;
                }
                return list;
            }

            int pivot = list.First();
            list.RemoveAt(0);
            var lessList = new List<int>();
            var moreList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] < pivot){
                    lessList.Add(list[i]);
                }else{
                    moreList.Add(list[i]);
                }
            }

            var sortedList = new List<int>();
            sortedList.AddRange(Sort(lessList));
            sortedList.Add(pivot);
            sortedList.AddRange(Sort(moreList));
            return sortedList;
        }
    }
}