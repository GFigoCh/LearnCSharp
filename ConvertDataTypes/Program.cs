namespace ConvertDataTypes;

class Program
{
    static void Main(string[] args)
    {
        // ThrowAnException();
        // LossOfInformation();
        // NumberToString();
        // StringToInt();
        // DecimalToInt();
        // TryParseMethod();
        // Challenge_ConcenateOrAdd();
        Challenge_MathOperation();
    }

    static void Challenge_MathOperation()
    {
        int valOne = 11;
        decimal valTwo = 6.2m;
        float valThree = 4.3f;

        int resultOne = Convert.ToInt32(valOne / valTwo);
        Console.WriteLine("Divide valOne by valTwo, display the result as an int: " + resultOne);

        decimal resultTwo = valTwo / (decimal)valThree;
        Console.WriteLine("Divide valTwo by valThree, display the result as a decimal: " + resultTwo);

        float resultThree = valThree / valOne;
        Console.WriteLine("Divide valThree by valOne, display the result as a float: " + resultThree);
    }

    static void Challenge_ConcenateOrAdd()
    {
        string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        string message = "";
        float total = 0;

        foreach (string item in values)
        {
            if (float.TryParse(item, out float parseResult))
            {
                total += parseResult;
            }
            else
            {
                message += item;
            }
        }

        Console.WriteLine("Message: " + message);
        Console.WriteLine("Total: " + total);
    }

    static void TryParseMethod()
    {
        // string val = "102";
        string val = "bad";
        int result = 0;

        if (int.TryParse(val, out result))
        {
            Console.WriteLine("Measurement: " + result);            
        }
        else
        {
            Console.WriteLine("Unable to report the measurement.");
        }

        if (result > 0)
        {
            Console.WriteLine("Measurement (w/ offset): " + (50 + result));
        }
    }

    static void DecimalToInt()
    {
        int valOne = (int)1.5m;
        Console.WriteLine(valOne);

        int valTwo = Convert.ToInt32(1.5m);
        Console.WriteLine(valTwo);
    }

    static void StringToInt()
    {
        /* Using 'Parse()' */
        string first = "5";
        string second = "7";

        int sum = int.Parse(first) + int.Parse(second);
        Console.WriteLine(sum);

        /* Using 'Convert' class */
        string valueOne = "5";
        string valueTwo = "7";

        int result = Convert.ToInt32(valueOne) * Convert.ToInt32(valueTwo);
        Console.WriteLine(result);
    }

    static void NumberToString()
    {
        int first = 5;
        int second = 7;

        string message = first.ToString() + second.ToString();
        Console.WriteLine(message);
    }

    static void LossOfInformation()
    {
        // int myInt = 3;
        // Console.WriteLine("int: " + myInt);

        // decimal myDecimal = myInt;
        // Console.WriteLine("decimal: " + myDecimal);

        // decimal myDecimal = 3.14m;
        // Console.WriteLine("decimal: " + myDecimal);

        // int myInt = (int)myDecimal;
        // Console.WriteLine("int: " + myInt);

        decimal myDecimal = 1.23456789m;
        Console.WriteLine("decimal: " + myDecimal);

        float myFloat = (float)myDecimal;
        Console.WriteLine("float: " + myFloat);
    }

    static void ThrowAnException()
    {
        int first = 2;
        string second = "4";
        
        // int result = first + second;
        string result = first + second;
        Console.WriteLine(result);
    }
}
