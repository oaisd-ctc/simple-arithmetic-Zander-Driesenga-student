using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Provide first number for addition");
        int additionOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Provide second number for addition");
        int additionTwo = int.Parse(Console.ReadLine());
        Console.WriteLine($"{additionOne} + {additionTwo} = {additionOne + additionTwo}");
        Console.WriteLine("Provide first number for subtraction");
        int subtractionOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Provide second number for subtraction");
        int subtractionTwo = int.Parse(Console.ReadLine());
        Console.WriteLine($"{subtractionOne} - {subtractionTwo} = {subtractionOne - subtractionTwo}");
        Console.WriteLine("Provide first number for multiplication");
        int multiplicationOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Provide second number for multiplication");
        int multiplicationTwo = int.Parse(Console.ReadLine());
        Console.WriteLine($"{multiplicationOne} * {multiplicationTwo} = {multiplicationOne * multiplicationTwo}");
        Console.WriteLine("Provide first number for integer division");
        int integerOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Provide second number for integer division");
        int integerTwo = int.Parse(Console.ReadLine());
        Console.WriteLine($"{integerOne} / {integerTwo} = {integerOne / integerTwo}");
    }
}
