namespace BubbleSort
{
    internal class BubbleSorting
    {
        public BubbleSorting() {
            int[] A = { 18, 20, 16, 15, 8, 5, 2, 1};
            //int[] A = { 1, 2, 3, 4, 5, 6};
            int n = A.Length;

            // Sorting Array using Bubble Sort
            BubbleShort(A, n);

            // Printing Sorted Array
            Console.WriteLine("Final Result after sorting the elements: ");
            printArray(A, n);
        }

        public void printArray(int[] A, int n) {
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("\n");
        }

        public void BubbleShort(int[] A, int n)
        {
            int isSorted = 0;

            for(int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("Working on pass number " + (i + 1));
                isSorted = 1;

                for (int j=0; j<n - 1 -i; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                        isSorted = 0;
                    }
                    printArray(A, n);
                }
                if (isSorted == 1)
                    {
                        return;
                    }
            }
        }
    }
}
