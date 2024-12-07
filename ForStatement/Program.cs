namespace ForStatement;

class Program
{
    static void Main(string[] args)
    {
        // CountUp();
        // CountDown();
        // IteratorPlusThree();
        // BreakKeyword();
        // IterateArray();
        // ReassignDuringIteration();
        Challenge();
    }

    static void Challenge()
    {
        for (int i = 1; i <= 100; i++)
        {
            string text = "";

            if (i % 3 == 0)
            {
                text += "Fizz";
            }

            if (i % 5 == 0)
            {
                text += "Buzz";
            }

            string spacer = "";
            if (text != "")
            {
                spacer = " - ";
            }

            Console.WriteLine(i + spacer + text);
        }
    }

    static void ReassignDuringIteration()
    {
        string[] names = { "Alex", "Eddie", "David", "Michael" };

        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == "David")
            {
                // "foreach" cant do this
                names[i] = "Sammy";
            }
        }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    static void IterateArray()
    {
        string[] names = { "Alex", "Eddie", "David", "Michael" };

        for (int i = names.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names[i]);            
        }
    }

    static void BreakKeyword()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);

            if (i == 7)
            {
                break;
            }
        }
    }

    static void IteratorPlusThree()
    {
        for (int i = 0; i < 10; i += 3)
        {
            Console.WriteLine(i);
        }
    }

    static void CountDown()
    {
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }

    static void CountUp()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}
