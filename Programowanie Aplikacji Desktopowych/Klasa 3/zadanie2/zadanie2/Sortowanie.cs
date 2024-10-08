using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    internal static class Sortowanie
    {        
        public static void Bubble_Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private static int PartitionLomuto(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return i + 1;
        }

        public static void QuickSortLomuto(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = PartitionLomuto(arr, low, high);
                QuickSortLomuto(arr, low, pivotIndex - 1);
                QuickSortLomuto(arr, pivotIndex + 1, high);
            }
        }

        private static int PartitionHoare(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int left = low - 1;
            int right = high + 1;
            while (true)
            {
                do
                {
                    left++;
                } while (arr[left] < pivot);
                do
                {
                    right--;
                } while (arr[right] > pivot);
                if (left >= right)
                    return right;
                Swap(arr, left, right);
            }
        }

        public static void QuickSortHoare(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = PartitionHoare(arr, low, high);
                QuickSortHoare(arr, low, pivotIndex);
                QuickSortHoare(arr, pivotIndex + 1, high);
            }
        }
    }
}