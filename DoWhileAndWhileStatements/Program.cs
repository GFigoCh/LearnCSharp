namespace DoWhileAndWhileStatements;

class Program
{
    static void Main(string[] args)
    {
        // DoWhileLoop();
        // WhileLoop();
        // DoWhileLoop_Continue();
        // Challenge_RoleplayGame();
        // Challenge_ValidateIntegerInput();
        // Challenge_ValidateStringInput();
        Challenge_Array();
    }

    static void Challenge_Array()
    {
        string[] myStrings = {
            "I like pizza. I like roasted chicken. I like salad",
            "I like all of the menu choices"
        };

        foreach (string sentence in myStrings)
        {
            string myString = sentence;
            int periodLocation = myString.IndexOf('.');

            while (periodLocation != -1)
            {
                Console.WriteLine(myString.Remove(periodLocation));

                myString = myString.Substring(periodLocation + 1).TrimStart();

                periodLocation = myString.IndexOf('.');
            }

            Console.WriteLine(myString);
        }
    }

    static void Challenge_ValidateStringInput()
    {
        bool inputStatus = false;
        string? inputContainer;

        Console.WriteLine("Are you 'Administrator', 'Manager', or 'User'?");
        do
        {
            inputContainer = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputContainer))
            {
                Console.WriteLine("Input could not be empty!");
                continue;
            }

            inputContainer = inputContainer.Trim().ToLower();

            switch (inputContainer)
            {
                case "administrator":
                case "manager":
                case "user":
                    inputStatus = true;
                    break;
                
                default:
                    Console.WriteLine($"Input '{inputContainer}' is not a valid role!");
                    break;
            }
        } while (!inputStatus);

        Console.WriteLine($"Input '{inputContainer}' has been accepted!");
    }

    static void Challenge_ValidateIntegerInput()
    {
        bool inputStatus = false;
        int integerInput = 0;

        Console.WriteLine("Input a number between 5 and 10:");
        do
        {
            string? inputContainer = Console.ReadLine();
            bool integerValid = int.TryParse(inputContainer, out integerInput);
            
            if (!integerValid)
            {
                Console.WriteLine("Last input is not a number!");
                continue;
            }

            if (integerInput <= 5 || integerInput >= 10)
            {
                Console.WriteLine($"Input '{integerInput}' is not between 5 and 10!");
                continue;
            }

            inputStatus = true;
        } while (!inputStatus);

        Console.WriteLine($"Input '{integerInput}' has been accepted!");
    }

    static void Challenge_RoleplayGame()
    {
        int heroHealth = 10;
        int monsterHealth = 10;

        // when "true", it's Hero turn
        // when "false,  it's Monster turn
        // Hero attack first, so the initial value is "true"
        bool turnSwitcher = true;
        Random randomizer = new Random();

        while (heroHealth > 0 && monsterHealth > 0)
        {
            int damageDealt = randomizer.Next(1, 11);

            if (turnSwitcher)
            {
                monsterHealth -= damageDealt;
                Console.WriteLine($"Monster was damaged and lost {damageDealt} health and now has {monsterHealth} health.");
            }
            else
            {
                heroHealth -= damageDealt;
                Console.WriteLine($"Hero was damaged and lost {damageDealt} health and now has {heroHealth} health.");
            }

            turnSwitcher = !turnSwitcher;
        }

        if (turnSwitcher)
        {
            Console.WriteLine("Monster wins!");
        }
        else
        {
            Console.WriteLine("Hero wins!");
        }
    }

    static void DoWhileLoop_Continue()
    {
        Random randomizer = new Random();
        int current = randomizer.Next(1, 11);

        do
        {
            current = randomizer.Next(1, 11);

            if (current >= 8)
            {
                continue;
            }

            Console.WriteLine(current);
        } while (current != 7);
    }

    static void WhileLoop()
    {
        Random randomizer = new Random();
        int current = randomizer.Next(1, 11);

        while (current >= 3)
        {
            Console.WriteLine(current);
            current = randomizer.Next(1, 11);
        }

        Console.WriteLine("Last Number: " + current);
    }

    static void DoWhileLoop()
    {
        Random randomizer = new Random();
        int current = 0;

        do
        {
            current = randomizer.Next(1, 11);
            Console.WriteLine(current);
        } while (current != 7);
    }
}
