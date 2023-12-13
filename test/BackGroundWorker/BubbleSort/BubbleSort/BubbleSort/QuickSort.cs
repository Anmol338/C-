namespace BubbleSort
{
    internal class QuickSort
    {
        public QuickSort() {
            int[] array = { 51, 95, 66, 72, 42, 38, 62 };

            Console.WriteLine("Original array:");
            PrintArray(array);

            QuickSortAlgorithm(array, 0, array.Length - 1);

            Console.WriteLine("\nSorted array:");
            PrintArray(array);
        }

        static void QuickSortAlgorithm(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);

                QuickSortAlgorithm(array, low, partitionIndex - 1);
                QuickSortAlgorithm(array, partitionIndex + 1, high);
            }
        }

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);

            return i + 1;
        }

        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
