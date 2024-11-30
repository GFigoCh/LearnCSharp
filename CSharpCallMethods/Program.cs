namespace CSharpCallMethods;

class Program
{
    static void Main(string[] args)
    {
        // Dice();
        // OverloadedMethods();
        // OverloadedMethods_Dice();
        Challenge_MathClass();
    }

    static void Challenge_MathClass()
    {
        int firstValue = 500;
        int secondValue = 600;
        int largerValue = Math.Max(firstValue, secondValue);

        Console.WriteLine("Larger Value: " + largerValue);
    }

    static void OverloadedMethods_Dice()
    {
        Random dice = new Random();

        int rollOne = dice.Next();
        int rollTwo = dice.Next(101);
        int rollThree = dice.Next(50, 101);

        Console.WriteLine($"First Roll: {rollOne}");
        Console.WriteLine($"Second Roll: {rollTwo}");
        Console.WriteLine($"Third Roll: {rollThree}");
    }

    static void OverloadedMethods()
    {
        int number = 7;
        string text = "Seven";

        Console.WriteLine(number);
        Console.WriteLine();
        Console.WriteLine(text);
    }

    static void Dice()
    {
        Random dice = new Random();
        int roll = dice.Next(1,7);
        Console.WriteLine("Roll Result: " + roll);
    }
}
