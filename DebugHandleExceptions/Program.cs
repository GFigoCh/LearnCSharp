namespace DebugHandleExceptions;

class Program
{
    static void Main(string[] args)
    {
        string? readResult = null;
        bool useTestData = false;
        int[] cashTill = {0, 0, 0, 0};
        int registerCheckTillTotal = 0;
        int[,] registerDailyStartingCash = {{1, 50}, {5, 20}, {10, 10}, {20, 5}};
        int[] testData = {6, 10, 17, 20, 31, 36, 40, 41};
        int testCounter = 0;

        LoadTillEachMorning(registerDailyStartingCash, cashTill);

        registerCheckTillTotal = registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1]
            + registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1]
            + registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1]
            + registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

        Console.Clear();
        LogTillStatus(cashTill);

        Console.WriteLine(TillAmountSummary(cashTill));
        Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n");

        var valueGenerator = new Random((int)DateTime.Now.Ticks);
        int transactions = 40;

        if (useTestData)
        {
            transactions = testData.Length;
        }

        while (transactions > 0)
        {
            transactions--;
            int itemCost = valueGenerator.Next(2, 50);

            if (useTestData)
            {
                itemCost = testData[testCounter];
                testCounter++;
            }

            int paymentOnes = itemCost % 2;
            int paymentFives = (itemCost % 10) > 7 ? 1 : 0;
            int paymentTens = (itemCost % 20) > 13 ? 1 : 0;
            int paymentTwenties = itemCost < 20 ? 1 : 2;

            Console.WriteLine($"Customer is making a ${itemCost} purchase");
            Console.WriteLine($"\t Using {paymentTwenties} twenty dollar bills");
            Console.WriteLine($"\t Using {paymentTens} ten dollar bills");
            Console.WriteLine($"\t Using {paymentFives} five dollar bills");
            Console.WriteLine($"\t Using {paymentOnes} one dollar bills");

            try
            {
                MakeChage(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);

                Console.WriteLine("Transaction successfuly completed.");
                registerCheckTillTotal += itemCost;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Couldn't complete transaction: " + ex.Message);
            }

            Console.WriteLine(TillAmountSummary(cashTill));
            Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\n");
        }

        Console.WriteLine("Press the Enter key to exit...");
        do
        {
            readResult = Console.ReadLine();
        } while (readResult == null);
    }

    static void LoadTillEachMorning(int[,] registerDailyStartingCash, int[] cashTill)
    {
        cashTill[0] = registerDailyStartingCash[0, 1];
        cashTill[1] = registerDailyStartingCash[1, 1];
        cashTill[2] = registerDailyStartingCash[2, 1];
        cashTill[3] = registerDailyStartingCash[3, 1];
    }

    static void MakeChage(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
    {
        cashTill[3] += twenties;
        cashTill[2] += tens;
        cashTill[1] += fives;
        cashTill[0] += ones;

        int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones;
        int changeNeeded = amountPaid - cost;

        if (changeNeeded < 0)
        {
            throw new InvalidOperationException("InvalidOperationException: Not enough money provided to complete the transaction.");
        }

        Console.WriteLine("Cashier Returns:");
        while ((changeNeeded > 19) && (cashTill[3] > 0))
        {
            cashTill[3]--;
            changeNeeded -= 20;
            Console.WriteLine("\t A twenty");
        }

        while ((changeNeeded > 9) && (cashTill[2] > 0))
        {
            cashTill[2]--;
            changeNeeded -= 10;
            Console.WriteLine("\t A ten");
        }

        while ((changeNeeded > 4) && (cashTill[1] > 0))
        {
            cashTill[1]--;
            changeNeeded -= 5;
            Console.WriteLine("\t A five");
        }

        while ((changeNeeded > 0) && (cashTill[0] > 0))
        {
            cashTill[0]--;
            changeNeeded--;
            Console.WriteLine("\t A one");
        }

        if (changeNeeded > 0)
        {
            throw new InvalidOperationException("InvalidOperationException: The till is unable to make the correct change.");
        }
    }

    static void LogTillStatus(int[] cashTill)
    {
        Console.WriteLine("The till currently has:");
        Console.WriteLine($"{cashTill[3] * 20} in twenties");
        Console.WriteLine($"{cashTill[2] * 10} in tens");
        Console.WriteLine($"{cashTill[1] * 5} in fives");
        Console.WriteLine($"{cashTill[0]} in ones\n");
    }

    static string TillAmountSummary(int[] cashTill)
    {
        return $"The till has {cashTill[3] * 20 + cashTill[2] * 10 + cashTill[1] * 5 + cashTill[0]} dollars";
    }
}
