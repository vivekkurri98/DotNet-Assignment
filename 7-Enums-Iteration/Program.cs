Console.WriteLine("7) Write a program to iterate through Enum values in C#?");
GetValues();
Console.ReadLine();
static void GetValues()
{
    foreach (Colors colors in Enum.GetValues(typeof(Colors)))
    {
        Console.WriteLine(colors);
    }
}

enum Colors
{
    red,
    blue,
    green,
    yellow
}


