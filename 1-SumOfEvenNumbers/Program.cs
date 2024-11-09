using System;

Console.WriteLine("1) Given an array of integers, write a C# method to total all the values that are even numbers.");

int[] array = { 1, 2, 3, 4, 5, 6 };
int result = 0;
foreach (int i in array)
{
    if (i % 2 == 0)
    {
        result += i;
    }
}
Console.WriteLine($"Sum of Even Number is {result}");
Console.ReadLine();