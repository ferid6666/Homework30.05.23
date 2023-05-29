using System;
using Task1._30._05._23;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of engineers:");
        int numberOfEngineers = Convert.ToInt32(Console.ReadLine());

        Engineer[] engineers = new Engineer[numberOfEngineers];

        for (int i = 0; i < numberOfEngineers; i++)
        {
            engineers[i] = new Engineer();

            Console.WriteLine($"Enter the name of Engineer {i + 1}:");
            engineers[i].FullName = Console.ReadLine();

            Console.WriteLine($"Enter the salary of Engineer {i + 1}:");
            engineers[i].Salary = Convert.ToDecimal(Console.ReadLine());
        }

        decimal totalSalary = 0;

        foreach (Engineer engineer in engineers)
        {
            totalSalary += engineer.Salary;
        }

        decimal averageSalary = totalSalary / numberOfEngineers;
        Console.WriteLine($"Average Salary of Engineers: {averageSalary}");
    }
}