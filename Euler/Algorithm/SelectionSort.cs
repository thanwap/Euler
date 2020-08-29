namespace Euler.Algorithm
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] arr){
            if(arr == null || arr.Length == 0)
                throw new System.ArgumentNullException("Input cannot be null or empty.");

            

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int smallest = arr[i];


                for (int y = i + 1; y < arr.Length; y++)
                {
                    if(arr[y] < smallest){
                        Swap(arr, i, y);
                    }
                }
            }

            return arr;
        }

        public static void Swap(int[] arr, int a, int b){
            int temp  = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}