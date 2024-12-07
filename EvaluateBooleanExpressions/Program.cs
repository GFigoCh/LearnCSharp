namespace EvaluateBooleanExpressions;

class Program
{
    static void Main(string[] args)
    {
        // EqualityOperator();
        // InequalityOperator();
        // ComparisonOperators();
        // MethodsReturnBoolean();
        // LogicalNegationOperator();
        // TernaryConditionalOperator();
        // Challenge_TernaryConditionalOperator();
        Challenge_DecisionLogic();
    }

    static void Challenge_DecisionLogic()
    {
        string permission = "Admin|Manager";
        int level = 55;

        string message = "You do not have sufficient privileges.";
        if (permission.Contains("Admin"))
        {
            if (level > 55)
            {
                message = "Welcome, Super Admin user.";
            }
            else
            {
                message = "Welcome, Admin user.";
            }
        }
        else if (permission.Contains("Manager"))
        {
            if (level >= 20)
            {
                message = "Contact an Admin for access.";
            }
        }

        Console.WriteLine(message);
    }

    static void Challenge_TernaryConditionalOperator()
    {
        Random coin = new Random();

        // Heads: 0
        // Tails: 1
        string coinSide = coin.Next(0, 2) == 0 ? "Heads" : "Tails";

        Console.WriteLine("Coin Flip Result: " + coinSide);
    }

    static void TernaryConditionalOperator()
    {
        int saleAmount = 1001;
        int discount = saleAmount > 1000 ? 100 : 50;
        Console.WriteLine("Discount: " + discount);

        // Inline example
        Console.WriteLine("Discount: " + (saleAmount > 1000 ? 100 : 50));
    }

    static void LogicalNegationOperator()
    {
        string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(!pangram.Contains("fox"));
        Console.WriteLine(!pangram.Contains("cow"));
    }

    static void MethodsReturnBoolean()
    {
        string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(pangram.Contains("fox"));
        Console.WriteLine(pangram.Contains("cow"));
    }

    static void ComparisonOperators()
    {
        Console.WriteLine(1 > 2);
        Console.WriteLine(1 < 2);
        Console.WriteLine(1 >= 1);
        Console.WriteLine(1 <= 1);
    }

    static void InequalityOperator()
    {
        Console.WriteLine("a" != "a");
        Console.WriteLine("a" != "A");
        Console.WriteLine(1 != 2);

        string myValue = "a";
        Console.WriteLine(myValue != "a");
    }

    static void EqualityOperator()
    {
        Console.WriteLine("a" == "a");
        Console.WriteLine("a" == "A");
        Console.WriteLine(1 == 2);

        string myValue = "a";
        Console.WriteLine(myValue == "a");

        Console.WriteLine("a" == "a ");

        string value1 = " a";
        string value2 = "A ";
        Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
    }
}
