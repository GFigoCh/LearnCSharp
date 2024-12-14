namespace FormatAlphanumericData;

class Program
{
    static void Main(string[] args)
    {
        // CompositeFormatting();
        // StringInterpolation();
        // FormattingCurrency();
        // FormattingNumbers();
        // FormattingPercentages();
        // CombineFormatting();
        // CustomerInvoice();
        // PaddingAlignment();
        // PaddingUsage_Payment();
        Challenge_Letter();
    }

    static void Challenge_Letter()
    {
        string customerName = "Ms. Barros";

        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = .1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        Console.WriteLine($"Dear {customerName},");
        Console.WriteLine($"As a customer of our {currentProduct} offering we are exicited to tell you about a new financial product that would dramatically increase your return.");
        Console.WriteLine($"\nCurrently, you own {currentShares:N} shares at a return of {currentReturn:P2}.");
        Console.WriteLine($"\nOur new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.");
        Console.WriteLine("\nHere's a quick comparison:\n");

        string comparisonMessage = "";

        comparisonMessage += currentProduct.PadRight(25);
        comparisonMessage += string.Format("{0:P2}", currentReturn).PadRight(10);
        comparisonMessage += string.Format("{0:C}", currentProfit);

        comparisonMessage += "\n";
        comparisonMessage += newProduct.PadRight(25);
        comparisonMessage += string.Format("{0:P2}", newReturn).PadRight(10);
        comparisonMessage += string.Format("{0:C}", newProfit);

        Console.WriteLine(comparisonMessage);
    }
    
    static void PaddingUsage_Payment()
    {
        string paymentId = "769C";
        string payeeName = "Mr. Stephen Ortega";
        string paymentAmount = "$5,000.00";

        string formattedLine = paymentId.PadRight(6);
        formattedLine += payeeName.PadRight(24);
        formattedLine += paymentAmount.PadLeft(10);
        
        Console.WriteLine("1234567890123456789012345678901234567890");
        Console.WriteLine(formattedLine);
    }

    static void PaddingAlignment()
    {
        string input = "Pad this";

        // Console.WriteLine(input.PadLeft(12));
        // Console.WriteLine(input.PadRight(12) + "hello");

        Console.WriteLine(input.PadLeft(12, '-'));
        Console.WriteLine(input.PadRight(12, '-') + "hello");
    }

    static void CustomerInvoice()
    {
        int invoiceNumber = 1201;
        decimal productShares = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;

        Console.WriteLine($"Invoice Number {invoiceNumber}");
        Console.WriteLine($"\tShares\t\t: {productShares:N3} Product");
        Console.WriteLine($"\tSub Total\t: {subtotal:C}");
        Console.WriteLine($"\tTax\t\t: {taxPercentage:P2}");
        Console.WriteLine($"\tTotal Billed\t: {total:C}");
    }

    static void CombineFormatting()
    {
        decimal price = 67.55m;
        decimal salePrice = 59.99m;

        string template = "You saved {0:C2} off the regular {1:C2} price. ";
        string yourDiscount = string.Format(template, (price - salePrice), price);

        yourDiscount += $"A discount of {(price - salePrice) / price:P2}!";

        Console.WriteLine(yourDiscount);
    }

    static void FormattingPercentages()
    {
        decimal tax = .36785m;
        Console.WriteLine($"Tax Rate: {tax:P2}");
    }

    static void FormattingNumbers()
    {
        decimal measurement = 123456.78912m;
        Console.WriteLine($"Measurement: {measurement:N4} units");
    }

    static void FormattingCurrency()
    {
        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");
    }

    static void StringInterpolation()
    {
        string first = "Hello";
        string second = "World";

        Console.WriteLine($"{first} {second}!");
        Console.WriteLine($"{second} {first}!");
        Console.WriteLine($"{first} {first} {first}!");
    }

    static void CompositeFormatting()
    {
        string first = "Hello";
        string second = "World";

        string result = string.Format("{0} {1}!", first, second);
        Console.WriteLine(result);

        Console.WriteLine("{1} {0}!", first, second);
        Console.WriteLine("{0} {0} {0}!", first, second);
    }
}
