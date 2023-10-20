Console.WriteLine("Welcome to your calculator!");

Console.Write("First number:");
double userInputOne = double.Parse(Console.ReadLine());

Console.Write("Second number:");
double userInputTwo = double.Parse(Console.ReadLine());

Console.Write("Choose an operation (+, -, / or *):");
char userOperator = char.Parse(Console.ReadLine());

try
{
    if (userOperator == '+')
    {
        Console.WriteLine(userInputOne + userInputTwo);
    }
    else if (userOperator == '-')
    {
        Console.WriteLine(userInputOne - userInputTwo);
    }
    else if (userOperator == '/')
    {
        Console.WriteLine(userInputOne / userInputTwo);
    }
    else if (userOperator == '*')
    {
        Console.WriteLine(userInputOne * userInputTwo);
    }
    else
    {
        throw new Exception("Wrong input");
    }
} 
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
