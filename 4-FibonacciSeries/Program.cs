Console.Write("4) Write a program to print Nth fibonacci number in series.");
Console.WriteLine("Enter the number for printing the FibonacciSeries");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 1;
Console.WriteLine("FibonacciSeries are:");

Console.Write(a + " ");

PrintFibonacciSeries(n, a, b);

Console.ReadLine();

static void PrintFibonacciSeries(int n, int a, int b)
{
    int c = a + b;
    Console.Write(c + " ");
    if (c < n)
    {
        a = b;
        b = c;
        PrintFibonacciSeries(n - 1, a, b);
    }
}
