namespace ExceptionHandling;

class Program
{
    static void Main(string[] args)
    {
        // SimpleImplementation();
        // Challenge_TryCatch();
        // ExceptionObjectProperties();
        // CatchSeparateExceptionTypes();
        Challenge_CatchSpecificExceptions();
    }

    static void Challenge_CatchSpecificExceptions()
    {
        try
        {
            int numOne = int.MaxValue;
            int numTwo = int.MaxValue;
            int result;
            checked
            {
                result = numOne + numTwo;
            }
            Console.WriteLine("Result: " + result);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
        }

        try
        {
            string str = null;
            int length = str.Length;
            Console.WriteLine("String Length: " + length);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Error: The reference is null. " + ex.Message);
        }

        try
        {
            int[] numbers = new int[5];
            numbers[5] = 10;
            Console.WriteLine("Number at index 5: " + numbers[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: Index out of range. " + ex.Message);
        }

        try
        {
            int numThree = 10;
            int numFour = 0;
            int anotherResult = numThree / numFour;
            Console.WriteLine("Another Result: " + anotherResult);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
        }

        Console.WriteLine("Closing the program...");
    }
    
    static void CatchSeparateExceptionTypes()
    {
        string[] inputValues = {"three", "9999999999", "0", "2"};

        foreach (string input in inputValues)
        {
            int numValue = 0;

            try
            {
                numValue = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid readResult, please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you entered is too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    static void ExceptionObjectProperties()
    {
        double floatOne = 3000.0;
        double floatTwo = 0.0;
        int numberOne = 3000;
        int numberTwo = 0;
        byte smallNumber;

        try
        {
            ProcessOne();
        }
        catch
        {
            Console.WriteLine("An Exception has been caught!");
        }

        Console.WriteLine("Closing the program...");

        void ProcessOne()
        {
            try
            {
                WriteMessage();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"An Exception has been caught in ProcessOne! {ex.Message}");
            }
        }
        
        void WriteMessage()
        {
            Console.WriteLine(floatOne / floatTwo);
            Console.WriteLine(numberOne / numberTwo);

            checked
            {
                smallNumber = (byte)numberOne;
            }
        }
    }

    static void Challenge_TryCatch()
    {
        double floatOne = 3000.0;
        double floatTwo = 0.0;
        int numberOne = 3000;
        int numberTwo = 0;

        try
        {
            ProcessOne();
        }
        catch
        {
            Console.WriteLine("An Exception has been caught!");
        }

        Console.WriteLine("Closing the program...");

        void ProcessOne()
        {
            try
            {
                WriteMessage();
            }
            catch
            {
                Console.WriteLine("An Exception has been caught in ProcessOne!");
            }
        }
        
        void WriteMessage()
        {
            Console.WriteLine(floatOne / floatTwo);
            Console.WriteLine(numberOne / numberTwo);
        }
    }

    static void SimpleImplementation()
    {
        double floatOne = 3000.0;
        double floatTwo = 0.0;
        int numberOne = 3000;
        int numberTwo = 0;

        try
        {
            ProcessOne();
        }
        catch
        {
            Console.WriteLine("An Exception has been caught!");
        }

        Console.WriteLine("Closing the program...");

        void ProcessOne()
        {
            WriteMessage();
        }
        
        void WriteMessage()
        {
            Console.WriteLine(floatOne / floatTwo);
            Console.WriteLine(numberOne / numberTwo);
        }
    }
}
