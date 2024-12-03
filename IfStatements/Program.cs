namespace IfStatements;

class Program
{
    static void Main(string[] args)
    {
        // Guided();
        Challenge();
    }

    static void Challenge()
    {
        Random randomizer = new Random();

        int daysUntilExpiration = randomizer.Next(12);

        Console.WriteLine("Days Remaining: " + daysUntilExpiration);

        if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        else if (daysUntilExpiration <= 5)
        {
            int discountPercentage = 10;

            if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
            }
            else
            {
                Console.WriteLine($"Your subscription exipires in {daysUntilExpiration} days.");
            }

            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
    }

    static void Guided()
    {
        Random dice = new Random();

        int rollOne = dice.Next(1, 7);
        int rollTwo = dice.Next(1, 7);
        int rollThree = dice.Next(1, 7);

        /* Doubles roll test */
        // rollOne = 6;
        // rollTwo = 6;
        // rollThree = 5;

        /* Triples roll test */
        // rollOne = 6;
        // rollTwo = 6;
        // rollThree = 6;

        int total = rollOne + rollTwo + rollThree;

        Console.WriteLine($"Dice Roll: {rollOne} + {rollTwo} + {rollThree} = {total}");

        if ((rollOne == rollTwo) || (rollOne == rollThree) || (rollTwo == rollThree))
        {
            if ((rollOne == rollTwo) && (rollTwo == rollThree))
            {
                total += 6;
                Console.WriteLine("Triples roll found! +6 bonus!");
            }
            else
            {
                total += 2;
                Console.WriteLine("Doubles roll found! +2 bonus!");
            }

            Console.WriteLine("Total + Bonus: " + total);
        }

        if (total >= 16)
        {
            Console.WriteLine("You win a new car!");
        }
        else if (total >= 10)
        {
            Console.WriteLine("You win a new laptop!");
        }
        else if (total == 7)
        {
            Console.WriteLine("You win a trip for two!");
        }
        else
        {
            Console.WriteLine("You win a kitten!");
        }
    }
}
