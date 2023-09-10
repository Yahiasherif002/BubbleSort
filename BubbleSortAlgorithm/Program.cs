internal class Program
{
    // Perform the bubble sort
    static int[] bubblesort(int[] arr, int size)
    {
        bool swaped = false;
        int count = 0;
        // Loop to access array elements
        for (int i = 0; i < size - 1; i++)
        {
            // Loop to compare array elements 
            for (int j = 0; j < size - i - 1; j++)
            {
                // Compare each two adjacent elements
                // Change < to > to sort in ascending order
                if (arr[j] < arr[j + 1])
                {
                    swap(ref arr[j], ref arr[j + 1]);
                    swaped = true;
                }
                count++;
            }
            if (swaped == false)
                break;
        }
        Console.WriteLine($"Number of Rounds : {count}");
        return arr;
    }

    static void swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void printarray(int[] arr)
    {
        Console.Write('[');
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($" {arr[i]} ");
        }
        Console.Write(']');
    }
    private static void Main(string[] args)
    {
        int[] data = { -8, 5, 23, 0, 11, -2 };
        int size = data.Length;
        int[] sortedData = bubblesort(data, size);
        printarray(sortedData);
    }
}
