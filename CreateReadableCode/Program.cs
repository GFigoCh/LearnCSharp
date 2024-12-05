namespace CreateReadableCode;

class Program
{
    static void Main(string[] args)
    {
        // CodeComments();
        // ExplanationComments();
        // WeirdWhitespace();
        // WhitespaceExample();
        Challenge();
    }

    static void Challenge()
    {
        /*
            Reverse a message then printing the result
            and 'o' character counts in those message.
        */
        string message = "The quick brown fox jumps over the lazy dog.";

        char[] messageCharArray = message.ToCharArray();
        Array.Reverse(messageCharArray);

        int oCounts = 0;
        foreach (char messageChar in messageCharArray)
        {
            if (messageChar == 'o')
            {
                oCounts++;
            }
        }

        string newMessage = new String(messageCharArray);
        Console.WriteLine(newMessage);

        Console.WriteLine($"'o' appears {oCounts} times.");
    }

    static void WhitespaceExample()
    {
        Random dice = new Random();
        
        int rollOne = dice.Next(1, 7);
        int rollTwo = dice.Next(1, 7);
        int rollThree = dice.Next(1, 7);

        int total = rollOne + rollTwo + rollThree;
        Console.WriteLine($"Dice Roll: {rollOne} + {rollTwo} + {rollThree} = {total}");

        if ((rollOne == rollTwo) || (rollOne == rollThree) || (rollTwo == rollThree))
        {
            if ((rollOne == rollTwo) && (rollTwo == rollThree))
            {
                total += 6;
                Console.WriteLine("You rolled triples! +6 bonus!");
            }
            else
            {
                total += 2;
                Console.WriteLine("You rolled doubles! +2 bonus!");
            }
        }
    }

    static void WeirdWhitespace()
    {
        // Example 1
        Console
        .
        WriteLine
        (
        "Hello Example 1!"
        )
        ;

        // Example 2
        string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");
    }

    static void ExplanationComments()
    {
        /*
            The following code creates 5 random OrderIDs
            to test the fraud detection process.

            OrderIDs consist of a letter from A to E,
            and a 3 digit number.

            Example: A123
        */
        Random randomizer = new Random();
        string[] orderIDs = new string[5];

        for (int i = 0; i < orderIDs.Length; i++)
        {
            int prefixValue = randomizer.Next(65, 70);
            string prefix = Convert.ToChar(prefixValue).ToString();

            string suffix = randomizer.Next(1, 1000).ToString("000");

            orderIDs[i] = prefix + suffix;
        }

        foreach (string id in orderIDs)
        {
            Console.WriteLine(id);
        }
    }

    static void CodeComments()
    {
        string firstName = "Bob";
        int widgetsPurchased = 7;

        /* Testing a change to the message. */
        // int widgetsSold = 7;
        // Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");

        Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
    }
}
