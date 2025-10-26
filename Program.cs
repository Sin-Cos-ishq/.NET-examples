// See https://aka.ms/new-console-template for more information
using System;

class HelloWorld
{
    static void Main()
    {
        // Console.WriteLine("Hello World");
        // int age = 25;
        // string name = "ishq";
        // double height = 5.9;
        // Console.WriteLine($"Name : {name},Age:{age} and his height is {height}");
        // Console.Write(" Enter your friend name:");
        // string Friend_Name = Console.ReadLine();
        // Console.WriteLine($"{name}'s Bestfriend is {Friend_Name}");
        // Console.Write("Enter your friend's age:");
        // int Friend_Age = int.Parse(Console.ReadLine());
        // Console.WriteLine($"My friend's age is {Friend_Age}");

        Average obj = new Average();
        float[] values = new float[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"enter the {i+1} number ");
            values[i] = float.Parse(Console.ReadLine());
            Console.WriteLine(i);

        }

        float SumValue = obj.CheckAvg(values[0], values[1], values[2]);
        Console.WriteLine($"The avg of give values is: {SumValue}.");
    }
}


class Average
{
    public float CheckAvg(float a,float b,float c)
    {
        float sum = (a + b + c) / 3f;
        return sum;
        
    }
}


using System;

class Program
{
    static void Main()
    {
        int[] values = new int[3];
        PrimeChecker obj = new PrimeChecker();

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter the {i + 1} number: ");
            values[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(); // blank line for readability

        for (int i = 0; i < 3; i++)
        {
            bool isPrime = obj.IsPrime(values[i]);
            if (isPrime)
                Console.WriteLine($"{values[i]} is a prime number.");
            else
                Console.WriteLine($"{values[i]} is not a prime number.");
        }
    }
}

class PrimeChecker
{
    public bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}
