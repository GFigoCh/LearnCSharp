namespace Methods;

class Program
{
    static void Main(string[] args)
    {
        // FirstMethod();
        // ReusableMethods();
        // BuildCodeWithMethods();
        Challenge();
    }

    static void Challenge()
    {
        string[] text = {
            "You have much to",
            "Today is a day to",
            "Whatever work you do",
            "This is an ideal time to"
        };

        string[] good = {
            "look forward to.",
            "try new things!",
            "is likely to succeed.",
            "accomplish your dreams!"
        };

        string[] bad = {
            "fear.",
            "avoid major decisions.",
            "may have unexpected outcomes.",
            "re-evaluate your life."
        };

        string[] neutral = {
            "appreciate.",
            "enjoy time with friends.",
            "should align with your values.",
            "get in tune with nature."
        };

        Random randomizer = new Random();
        int luck = randomizer.Next(100); // random luck
        TellFortune();

        luck = 80; // good luck
        TellFortune();

        luck = 50; // neutral luck
        TellFortune();

        luck = 10; // bad luck
        TellFortune();

        void TellFortune()
        {
            Console.WriteLine("A fortune teller whispers the following words:");
        
            string[] fortune = bad;
            if (luck > 75)
            {
                fortune = good;
            }
            else if (luck > 25)
            {
                fortune = neutral;
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{text[i]} {fortune[i]}");
            }

            Console.WriteLine();
        }
    }

    static void BuildCodeWithMethods()
    {
        string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
        bool validLength = false;
        bool validZeroes = false;
        bool validRange = false;

        string[] address;
        foreach (string ip in ipv4Input)
        {
            address = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);

            ValidateLength();
            ValidateZeroes();
            ValidateRange();

            if (validLength && validZeroes && validRange)
            {
                Console.WriteLine($"{ip} is a valid IPv4 address.");
            }
            else
            {
                Console.WriteLine($"{ip} is an invalid IPv4 address.");
            }
        }

        void ValidateLength()
        {
            validLength = address.Length == 4;
        }

        void ValidateZeroes()
        {
            foreach (string number in address)
            {
                if (number.Length > 1 && number.StartsWith('0'))
                {
                    validZeroes = false;
                    return;
                }
            }

            validZeroes = true;
        }

        void ValidateRange()
        {
            foreach (string number in address)
            {
                int val = int.Parse(number);
                if (val < 0 || val > 255)
                {
                    validRange = false;
                    return;
                }
            }

            validRange = true;
        }
    }

    static void ReusableMethods()
    {
        int[] times = { 800, 1200, 1600, 2000 };
        int diff = 0;

        Console.WriteLine("Enter current GMT");
        int currentGMT = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Current Medicine Schedule:");
        DisplayTimes();

        Console.WriteLine("\nEnter new GMT");
        int newGMT = Convert.ToInt32(Console.ReadLine());

        if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
        {
            Console.WriteLine("Invalid GMT!");
        }
        else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
        {
            diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
            AdjustTimes();
        }
        else
        {
            diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
            AdjustTimes();
        }

        Console.WriteLine("New Medicine Schedule:");
        DisplayTimes();

        void DisplayTimes()
        {
            foreach (int val in times)
            {
                string time = val.ToString();
                int len = time.Length;

                if (len >= 3)
                {
                    time = time.Insert(len - 2, ":");
                }
                else if (len == 2)
                {
                    time = time.Insert(0, "0:");
                }
                else
                {
                    time = time.Insert(0, "0:0");
                }

                Console.Write($"{time} ");
            }
        }

        void AdjustTimes()
        {
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = (times[i] + diff) % 2400;
            }
        }
    }

    static void FirstMethod()
    {
        Console.WriteLine("Generating random numbers:");
        DisplayRandomNumbers();

        void DisplayRandomNumbers()
        {
            Random randomizer = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(randomizer.Next(1, 100));
            }
        }
    }
}
