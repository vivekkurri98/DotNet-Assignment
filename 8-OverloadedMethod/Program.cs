using _8_OverloadedMethod;

Console.WriteLine("8) Write an over loaded function in c# to calculate an area of a square or a rectangle.");
Area area = new Area();

// Calculate area of a square
double squareSide = 5.0; 
double squareArea = area.CalculateArea(squareSide); 
Console.WriteLine($"Area of the square: {squareArea}"); 

// Calculate area of a rectangle
double rectangleLength = 10.0; 
double rectangleWidth = 4.0; 
double rectangleArea = area.CalculateArea(rectangleLength, rectangleWidth);
Console.WriteLine($"Area of the rectangle: {rectangleArea}");

Console.ReadLine();