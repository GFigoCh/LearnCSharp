namespace VariableScope;

class Program
{
    static void Main(string[] args)
    {
        // CodeBlocks();
        // RemoveCodeBlocks();
        Challenge();
    }

    static void Challenge()
    {
        // Total: 16 lines (without Comments)
        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        int total = 0;
        bool found = false;

        foreach (int number in numbers)
        {
            total += number;

            // Removing curly braces for challenge requirement (max 17 lines)
            if (number == 42)
                found = true;
        }

        // Removing curly braces for challenge requirement (max 17 lines)
        if (found)
            Console.WriteLine("Set contains 42");

        Console.WriteLine("Total: " + total);
    }

    static void RemoveCodeBlocks()
    {
        bool flag = true;

        if (flag)
            Console.WriteLine(flag);

        // Single-line example, not recommended
        if (flag) Console.WriteLine(flag);

        string name = "steve";

        // Another single-line example
        if (name == "bob") Console.WriteLine("Found Bob");
        else if (name == "steve") Console.WriteLine("Found Steve");
        else Console.WriteLine("Found Chuck");

        // Better one, but I personally still prefer using the curly braces
        if (name == "bob")
            Console.WriteLine("Found Bob");
        else if (name == "steve")
            Console.WriteLine("Found Steve");
        else
            Console.WriteLine("Found Chuck");
    }

    static void CodeBlocks()
    {
        bool flag = true;
        int value = 0;

        if (flag)
        {
            Console.WriteLine("Inside the code block: " + value);
        }

        value = 10;
        Console.WriteLine("Outside the code block: " + value);
    }
}
