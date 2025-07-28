namespace SimpleCalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        
        Console.Write("Input the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Input the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("What do you want to do?");
        Console.WriteLine("[A]dd");
        Console.WriteLine("[S]ubstract");
        Console.WriteLine("[M]ultiply");

        string userCommand = Console.ReadLine();

        if (userCommand.ToLower() == "a")
        {
            PrintExpression(firstNumber, secondNumber, "+", firstNumber + secondNumber);
        }
        else if (userCommand.ToLower() == "s")
        {
            PrintExpression(firstNumber, secondNumber, "-", firstNumber - secondNumber);
        }
        else if (userCommand.ToLower() == "m")
        {
            PrintExpression(firstNumber, secondNumber, "*", firstNumber * secondNumber);
        }
    }

    static void PrintExpression(int firstNumber, int secondNumber, string operation, int result)
    {
        Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");
    }
}