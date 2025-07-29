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

        switch (userCommand.ToLower())
        {
            case "a":
                PrintExpression(firstNumber, secondNumber, '+', firstNumber + secondNumber);
                break;
            
            case "s":
                PrintExpression(firstNumber, secondNumber, '-', firstNumber - secondNumber);
                break;
            
            case "m":
                PrintExpression(firstNumber, secondNumber, '*', firstNumber * secondNumber);
                break;
            
            default:
                Console.WriteLine("Wrong command");
                break;
        }
    }

    static void PrintExpression(int firstNumber, int secondNumber, char operation, int result)
    {
        Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");
    }
}