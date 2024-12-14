namespace OperationsOnArray;

class Program
{
    static void Main(string[] args)
    {
        // SortArray();
        // ClearResizeArray();
        // SplitJoinArray();
        // Challenge_ReverseWords();
        Challenge_Orders();
    }

    static void Challenge_Orders()
    {
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

        string[] orderArray = orderStream.Split(',');
        Array.Sort(orderArray);

        foreach (string order in orderArray)
        {
            string result = order;

            if (order.Length != 4)
            {
                result += "\t- Error";
            }

            Console.WriteLine(result);
        }
    }

    static void Challenge_ReverseWords()
    {
        string pangram = "The quick brown fox jumps over the lazy dog";

        string[] pangramArray = pangram.Split(' ');
        for (int i = 0; i < pangramArray.Length; i++)
        {
            char[] itemArray = pangramArray[i].ToCharArray();
            Array.Reverse(itemArray);

            pangramArray[i] = new string(itemArray);
        }

        string pangramReversed = string.Join(' ', pangramArray);
        Console.WriteLine(pangramReversed);
    }

    static void SplitJoinArray()
    {
        string val = "abc123";

        char[] valArray = val.ToCharArray();
        Array.Reverse(valArray);

        // string result = new string(valArray);
        string result = string.Join(',', valArray);
        Console.WriteLine(result);

        string[] items = result.Split(',');
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }

    static void ClearResizeArray()
    {
        string[] pallets = { "B14", "A11", "B12", "A13" };

        // Console.WriteLine("Before: " + pallets[0]);
        // Console.WriteLine("Before: " + pallets[0].ToLower());
        
        Array.Clear(pallets, 0, 2);

        // Console.WriteLine("After: " + pallets[0]);
        // if (pallets[0] != null)
        // {
        //     Console.WriteLine("After: " + pallets[0].ToLower());
        // }
        
        Console.WriteLine("Cleared 2 ... count: " + pallets.Length);
        foreach (string pallet in pallets)
        {
            Console.WriteLine("-- " + pallet);
        }

        Array.Resize(ref pallets, 6);
        Console.WriteLine("\nResized 6 ... count: " + pallets.Length);

        pallets[4] = "C01";
        pallets[5] = "C02";

        foreach (string pallet in pallets)
        {
            Console.WriteLine("-- " + pallet);
        }

        Array.Resize(ref pallets, 3);
        Console.WriteLine("\nResized 3 ... count: " + pallets.Length);

        foreach (string pallet in pallets)
        {
            Console.WriteLine("-- " + pallet);
        }
    }

    static void SortArray()
    {
        string[] pallets = { "B14", "A11", "B12", "A13" };

        Array.Sort(pallets);
        Console.WriteLine("Sorted...");

        foreach (string pallet in pallets)
        {
            Console.WriteLine("-- " + pallet);
        }

        Array.Reverse(pallets);
        Console.WriteLine("\nReversed...");

        foreach (string pallet in pallets)
        {
            Console.WriteLine("-- " + pallet);
        }
    }
}
