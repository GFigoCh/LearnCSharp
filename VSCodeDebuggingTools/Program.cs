namespace VSCodeDebuggingTools;

class Program
{
    static void Main(string[] args)
    {
        // DebugIntroduction();
        // ConditionalBreakpoints();
        // MonitorVariableState();
        // MonitorWatchExpressions();
        Challenge();
    }

    static void Challenge()
    {
        int x = 5;

        x = ChangeValue(x);
        Console.WriteLine(x);

        int ChangeValue(int val)
        {
            val = 10;
            return val;
        }
    }

    static void MonitorWatchExpressions()
    {
        bool exit = false;
        int numOne = 5;
        int numTwo = 5;
        Random rand = new Random();

        do
        {
            numOne = rand.Next(1, 11);
            numTwo = numOne + rand.Next(1, 51);
        } while (!exit);
    }

    static void MonitorVariableState()
    {
        int startIndex = 0;
        bool goodEntry = false;

        int[] numbers = {1, 2, 3, 4, 5};

        Console.Clear();
        Console.Write("\nThe 'numbers' array contains: ");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }

        while (!goodEntry)
        {
            Console.Write("\n\nTo sum values 'n' through 5, enter a value for 'n': ");
            string? input = Console.ReadLine();
            goodEntry = int.TryParse(input, out startIndex);

            if (startIndex > 5)
            {
                Console.WriteLine("\nEnter an Integer value between 1 and 5!");
                goodEntry = false;
            }
        }

        Console.WriteLine($"\nThe sum of numbers {startIndex} through {numbers.Length} is {SumValues(numbers, startIndex - 1)}");
        Console.ReadLine();

        int SumValues(int[] numbers, int n)
        {
            int sum = 0;
            for (int i = n; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }

    static void ConditionalBreakpoints()
    {
        int productCount = 2000;
        string[,] products = new string[productCount, 2];

        LoadProducts(products, productCount);

        for (int i = 0; i < productCount; i++)
        {
            string result = ProcessOne(products, i);

            if (result != "obsolete")
            {
                result = ProcessTwo(products, i);
            }
        }

        bool pauseCode = true;
        while (pauseCode)
        {
            //
        }

        void LoadProducts(string[,] products, int productCount)
        {
            Random rand = new Random();

            for (int i = 0; i < productCount; i++)
            {
                int numOne = rand.Next(1, 10000) + 10000;
                int numTwo = rand.Next(1, 101);

                string prodID = numOne.ToString();

                if (numTwo < 91)
                {
                    products[i, 1] = "existing";
                }
                else if (numTwo == 91)
                {
                    products[i, 1] = "new";
                    prodID += "-n";
                }
                else
                {
                    products[i, 1] = "obsolete";
                    prodID += "-o";
                }

                products[i, 0] = prodID;
            }
        }

        string ProcessOne(string[,] products, int item)
        {
            Console.WriteLine($"Process 1 message - working on {products[item, 1]} product.");

            return products[item, 1];
        }

        string ProcessTwo(string[,] products, int item)
        {
            Console.WriteLine($"Process 2 message - working on product ID #{products[item, 0]}");

            if (products[item, 1] == "new")
            {
                ProcessThree(products, item);
            }

            return "continue";
        }

        void ProcessThree(string[,] products, int item)
        {
            Console.WriteLine($"Process 3 message - processing product information for 'new' product.");
        }
    }

    static void DebugIntroduction()
    {
        string[] names = {"Sophia", "Andrew", "AllGreetings"};

        string messageText = "";

        foreach (string name in names)
        {
            if (name == "Sophia")
                messageText = SophiaMessage();
            else if (name == "Andrew")
                messageText = AndrewMessage();
            else if (name == "AllGreetings")
                messageText = SophiaMessage() + "\n" + AndrewMessage();

            Console.WriteLine(messageText + "\n");
        }

        bool pauseCode = true;
        while (pauseCode)
        {
            //
        }

        string SophiaMessage()
        {
            return "Hello, my name is Sophia.";
        }

        string AndrewMessage()
        {
            return "Hi, my name is Andrew, Good to meet you.";
        }
    }
}
