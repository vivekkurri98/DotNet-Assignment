Console.WriteLine("3) Write a program to swap two numbers without using a temp variable in C#.");
int x = 10;
int y = 20;

Console.WriteLine($"Before Swapping : {x} {y}");

x = x + y;
y = x - y;
x = x - y;

Console.WriteLine($"After Swapping : {x} {y}");
Console.ReadLine();