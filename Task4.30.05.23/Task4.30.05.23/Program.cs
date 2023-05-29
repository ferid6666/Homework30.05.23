using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 2, 4, 18, 6, 11, 596 };
        int[] array2 = { 3, 5, 6, 11, 298 };

        Console.WriteLine("Elements which are only in first array:");

        foreach (int element in array1)
        {
            bool found = false;

            foreach (int num in array2)
            {
                if (element == num)
                {
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine(element);
            }
        }
    }
}
