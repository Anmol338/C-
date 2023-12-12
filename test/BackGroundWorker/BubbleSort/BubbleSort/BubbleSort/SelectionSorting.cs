namespace BubbleSort
{
    internal class SelectionSorting
    {
        public SelectionSorting() {
            int[] A = { 10, 8, 6, 7, 1, 5 };
            //int[] A = { 1, 2, 3, 4, 5, 6};
            int n = A.Length;

            // Sorting Array using Bubble Sort
            SelectionShort(A, n);

            // Printing Sorted Array
            Console.WriteLine("Final Result after sorting the elements: ");
            printArray(A, n);
        }

        public void printArray(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("\n");
        }

        public void SelectionShort(int[] A, int n)
        {
            for (int i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Working on pass number " + (i + 1));
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (A[i] > A[j])
                    {
                        int temp = A[j];
                        A[j] = A[i];
                        A[i] = temp;
                    }
                    printArray(A, n);
                }
            }
        }
    }
}
