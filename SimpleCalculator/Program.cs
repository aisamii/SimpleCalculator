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
    }
}