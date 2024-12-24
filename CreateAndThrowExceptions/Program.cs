namespace CreateAndThrowExceptions;

class Program
{
    static void Main(string[] args)
    {
        // Exercise();
        Challenge();
    }

    static void Challenge()
    {
        string[][] userEnteredValues =
        {
            new string[] {"1", "2", "3"},
            new string[] {"1", "two", "3"},
            new string[] {"0", "1", "2"}
        };

        try
        {
            WorkflowOne(userEnteredValues);
            Console.WriteLine("'WorkflowOne' completed sucessfully.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("An error occured during 'WorkflowOne'.");
            Console.WriteLine(ex.Message);
        }

        void WorkflowOne(string[][] userEnteredValues)
        {
            foreach (string[] userEntries in userEnteredValues)
            {
                try
                {
                    ProcessOne(userEntries);
                    Console.WriteLine("'ProcessOne' completed sucessfully.\n");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("'ProcessOne' encountered an issue, process aborted.");
                    Console.WriteLine(ex.Message + "\n");
                }
            }
        }

        void ProcessOne(string[] userEntries)
        {
            foreach (string userValue in userEntries)
            {
                bool integerFormat = int.TryParse(userValue, out int valueEntered);

                if (!integerFormat)
                {
                    throw new FormatException("Invalid data! User input values must be valid integers.");
                }

                if (valueEntered == 0)
                {
                    throw new DivideByZeroException("Invalid data! User input values must be non-zero values.");
                }

                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
        }
    }

    static void Exercise()
    {
        Console.Write("Enter the lower bound: ");
        int lowerBound = int.Parse(Console.ReadLine());

        Console.Write("Enter the upper bound: ");
        int upperBound = int.Parse(Console.ReadLine());

        bool exit = false;
        do
        {
            try
            {
                decimal averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

                Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}");
                Console.ReadLine();

                exit = true;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("An error has occured.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("The upper bound must be greater than " + lowerBound);

                Console.Write("Enter the upper bound (number/exit): ");
                string? userResponse = Console.ReadLine();

                if (userResponse.ToLower().Contains("exit"))
                {
                    exit = true;
                }
                else
                {
                    upperBound = int.Parse(userResponse);
                }
            }
        } while (!exit);
        
        decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
        {
            if (lowerBound >= upperBound)
            {
                throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
            }

            int sum = 0;
            int count = 0;

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    count++;
                }
            }

            return (decimal)sum / count;
        }
    }
}
