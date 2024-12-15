namespace StringDataTypeMethods;

class Program
{
    static void Main(string[] args)
    {
        // FindParenthesesPairs();
        // FindCharactersPositions();
        // SubstringLastOccurence();
        // SubstringsInsideAllParentheses();
        // DifferentSymbolSets();
        // RemoveCharacters();
        // ReplaceCharacters();
        Challenge();
    }

    static void Challenge()
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "Quantity: ";
        string output = "Output: ";

        int spanOpening = input.IndexOf("<span>");
        int spanClosing = input.IndexOf("</span>");

        spanOpening += 6;
        int quantityLength = spanClosing - spanOpening;
        quantity += input.Substring(spanOpening, quantityLength);

        output += input;
        output = output.Replace("&trade;", "&reg;");

        /* original solution */
        // output = output.Replace("<div>", "")
        //                 .Replace("</div>", "");

        /* course based solution */
        int divOpening = output.IndexOf("<div>");
        output = output.Remove(divOpening, 5);

        int divClosing = output.IndexOf("</div>");
        output = output.Remove(divClosing, 6);

        Console.WriteLine(quantity);
        Console.WriteLine(output);
    }

    static void ReplaceCharacters()
    {
        string message = "This--is--ex-amp-le--da-ta";

        message = message.Replace("--", " ");
        message = message.Replace("-", "");
        Console.WriteLine(message);
    }

    static void RemoveCharacters()
    {
        string data = "12345John Smith          5000  3  ";
        
        string updatedData = data.Remove(5, 20);
        Console.WriteLine(updatedData);
    }

    static void DifferentSymbolSets()
    {
        string message = "Hello, World!";
        char[] charsToFind = { 'a', 'e', 'i' };

        int index = message.IndexOfAny(charsToFind);
        Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

        /* Second Example */
        string secondMessage = "Help (find) the {opening symbols}";
        Console.WriteLine("\nSearching THIS message: " + secondMessage);

        char[] openSymbols = { '[', '{', '(' };
        int startPosition = 5;

        int openingPosition = secondMessage.IndexOfAny(openSymbols);
        Console.WriteLine("Found WITHOUT using startPosition: " + secondMessage.Substring(openingPosition));

        openingPosition = secondMessage.IndexOfAny(openSymbols, startPosition);
        Console.WriteLine($"Found WITH using startPosition {startPosition}: {secondMessage.Substring(openingPosition)}");

        /* Third Example */
        Console.WriteLine();
        string thirdMessage = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
        char[] openingSymbols = { '[', '{', '(' };
        int closingPos = 0;

        while (true)
        {
            int openingPos = thirdMessage.IndexOfAny(openingSymbols, closingPos);
            if (openingPos == -1)
            {
                break;
            }

            string currentSymbol = thirdMessage.Substring(openingPos, 1);
            char matchingSymbol = ' ';
            switch (currentSymbol)
            {
                case "[":
                    matchingSymbol = ']';
                    break;

                case "{":
                    matchingSymbol = '}';
                    break;

                case "(":
                    matchingSymbol = ')';
                    break;
            }

            openingPos += 1;
            closingPos = thirdMessage.IndexOf(matchingSymbol, openingPos);

            int length = closingPos - openingPos;
            Console.WriteLine(thirdMessage.Substring(openingPos, length));
        }
    }

    static void SubstringsInsideAllParentheses()
    {
        string message = "(What if) there are (more than) one (set of parentheses)?";

        while (true)
        {
            int openingPosition = message.IndexOf('(');
            if (openingPosition == -1)
            {
                break;
            }

            int closingPosition = message.IndexOf(')');
            openingPosition += 1;

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            message = message.Substring(closingPosition + 1);
        }
    }

    static void SubstringLastOccurence()
    {
        string message = "(What if) I am (only interested) in the last (set of parentheses)?";

        int openingPosition = message.LastIndexOf('(');
        int closingPosition = message.LastIndexOf(')');

        openingPosition += 1;
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
    }

    static void FindCharactersPositions()
    {
        string message = "hello there!";

        int first_h = message.IndexOf('h');
        int last_h = message.LastIndexOf('h');

        Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");
    }

    static void FindParenthesesPairs()
    {
        string message = "Find what is (inside the parentheses)";

        int openingPosition = message.IndexOf('(');
        int closingPosition = message.IndexOf(')');

        // Console.WriteLine(openingPosition);
        // Console.WriteLine(closingPosition);

        openingPosition += 1;
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));

        /* Span Tags */
        string tagsMessage = "What is the value <span>between the tags</span>?";

        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int openingTag = tagsMessage.IndexOf(openSpan);
        int closingTag = tagsMessage.IndexOf(closeSpan);

        openingTag += openSpan.Length;
        int tagsLength = closingTag - openingTag;
        Console.WriteLine(tagsMessage.Substring(openingTag, tagsLength));
    }
}
