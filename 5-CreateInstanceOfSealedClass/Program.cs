using _5_CreateInstanceOfSealedClass;

Console.WriteLine("5) Given an instance circle of the following class:");
Circle cirle = new Circle(5);
var result = cirle.Calculate(x => 2 * Math.PI * x);
Console.WriteLine($"Circumference of the circle: {result}");
Console.ReadLine();