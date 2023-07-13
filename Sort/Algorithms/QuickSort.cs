using Sort.Structure;

namespace Sort.Algorithms
{
    public static class QuickSort
    {
        private static int Partition(this MyLinkedList arr, int low, int high)
        {
            int index = low;
            int valuePivot = arr[high];

            for (int i = low; i < high; i++)
            {
                int value = arr[i];
                if (value < valuePivot)
                {
                    arr.SwapValueOfIndex(index, i);
                    index++;
                }
            }
            arr.SwapValueOfIndex(index, high);
            return index;
        }

        private static void QuickSortInner(this MyLinkedList arr, int low, int high)
        {
            if (low >= high) return;

            int pivot = arr.Partition(low, high);
            arr.QuickSortInner(low, pivot - 1);
            arr.QuickSortInner(pivot + 1, high);
        }

        public static void Sort(this MyLinkedList arr)
        {
            arr.QuickSortInner(0, arr.Count - 1);
        }

        private static int MiddlePointPivot(this MyLinkedList arr, int low, int high)
        {
            int valPivot = arr[high];
            int primitive = low;

            for (int i = low; i < high; i++)
            {
                int val = arr[i];
                if (val < valPivot)
                {
                    arr.SwapValueOfIndex(low, i);
                }
                else if (val >= valPivot && i != high)
                {
                    low++;
                }
            }

            // swap pivot
            if (low != primitive)
                arr.SwapValueOfIndex(low, high);
            return low;
        }

        private static void SwapValueOfIndex(this MyLinkedList arr, int i, int j)
        {
            int swap = arr[i];
            arr[i] = arr[j];
            arr[j] = swap;
        }
    }
}