namespace ChooseCorrectDataType;

class Program
{
    static void Main(string[] args)
    {
        // MinMaxValue_Integral();
        // MinMaxValue_FloatingPoint();
        ReferenceTypeVariable();
    }

    static void ReferenceTypeVariable()
    {
        /* array is Reference Typed because it's initialization use a 'new' keyword. */
        // int[] data = new int[3];

        /* string is Reference Typed, it's created a new instance behind the scene. */
        // string shortenedString = "Hello World!";

        int val_A = 2;
        int val_B = val_A;
        val_B = 5;

        Console.WriteLine("--- Value Types ---");
        Console.WriteLine("val_A: " + val_A);
        Console.WriteLine("val_B: " + val_B);

        int[] ref_A = new int[1];
        ref_A[0] = 2;

        int[] ref_B = ref_A;
        ref_B[0] = 5;

        Console.WriteLine("--- Reference Types ---");
        Console.WriteLine("ref_A[0]: " + ref_A[0]);
        Console.WriteLine("ref_B[0]: " + ref_B[0]);
    }

    static void MinMaxValue_FloatingPoint()
    {
        Console.WriteLine("Floating point types:");
        Console.WriteLine($"float: {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
        Console.WriteLine($"double: {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
        Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
    }

    static void MinMaxValue_Integral()
    {
        Console.WriteLine("Signed integral types:");
        Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");

        Console.WriteLine("\nUnsigned integral types:");
        Console.WriteLine($"byte: {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"uint: {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"ulong: {ulong.MinValue} to {ulong.MaxValue}");
    }
}
