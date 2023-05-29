using System;
public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int[] evenNumbers = GetEvenNumbers(numbers);

        Console.WriteLine("Even numbers:");
        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }

    public static int[] GetEvenNumbers(int[] numbers)
    {
        return numbers.Where(x => x % 2 == 0).ToArray();
    }
}
