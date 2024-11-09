static double Power(double baseNumber, int exponent, double accumulator = 1) 
{ 
    if (exponent == 0) 
        return accumulator; 
    
    return Power(baseNumber, exponent - 1, accumulator * baseNumber); 
}

double baseNumber = 2; 
int exponent = 5;
double result = Power(baseNumber, exponent);
Console.WriteLine($"{baseNumber} to the power of {exponent} is {result}");