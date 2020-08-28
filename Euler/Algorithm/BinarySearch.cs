using System.Runtime.Serialization;
namespace Euler.Algorithm
{
    public static class BinarySearch
    {
        public static int? FindIndex(int[] list, int number){
            if(list == null || list.Length == 0)
                return null;

            int low = 0, high = list.Length - 1;

            while(low <= high){
                int mid = (low + high) / 2;
                int guess = list[mid];

                if(guess == number)
                    return mid;
                if(guess > number){
                    high = mid - 1;
                }else{
                    low = mid + 1;
                }
            }

            return null;
        }
    }
}