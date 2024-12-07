namespace SwitchStatements;

class Program
{
    static void Main(string[] args)
    {
        // Guided();
        Challenge();
    }

    static void Challenge()
    {
        string sku = "01-MN-L";

        string[] product = sku.Split('-');

        string type = "Other";
        string color = "White";
        string size = "One Size Fits All";

        switch (product[0])
        {
            case "01":
                type = "Sweat Shirt";
                break;

            case "02":
                type = "T-Shirt";
                break;

            case "03":
                type = "Sweat Pants";
                break;
        }

        switch (product[1])
        {
            case "BL":
                color = "Black";
                break;

            case "MN":
                color = "Maroon";
                break;
        }

        switch (product[2])
        {
            case "S":
                size = "Small";
                break;

            case "M":
                size = "Medium";
                break;

            case "L":
                size = "Large";
                break;
        }

        Console.WriteLine($"Product: {size} {color} {type}");
    }

    static void Guided()
    {
        int employeeLevel = 100;
        string employeeName = "John Wick";

        string title = "";

        switch (employeeLevel)
        {
            // case 100:
            //     title = "Junior Associate";
            //     break;

            case 100:
            case 200:
                title = "Senior Associate";
                break;

            case 300:
                title = "Manager";
                break;

            case 400:
                title = "Senior Manager";
                break;

            default:
                title = "Associate";
                break;
        }
        
        Console.WriteLine($"{employeeName}, {title}");
    }
}
