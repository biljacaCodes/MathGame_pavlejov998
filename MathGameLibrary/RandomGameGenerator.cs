namespace MathGameLibrary;

internal class RandomGameGenerator
{
    internal static int Addition(int numberOne, int numberTwo)
    {
        Console.Clear();

        Console.WriteLine($"Example: {numberOne} + {numberTwo}");
        Console.Write("Your answer: ");
        var result = Console.ReadLine();

        // validation
        result = Helpers.ValidateResult(result);

        int score = Helpers.CheckAnwer(numberOne, numberTwo, int.Parse(result), "+");

        return score;
    }


    internal static int Subtraction(int numberOne, int numberTwo)
    {
        Console.Clear();

        Console.WriteLine($"Example: {numberOne} - {numberTwo}");
        Console.Write("Your answer: ");
        var result = Console.ReadLine();

        // validation
        result = Helpers.ValidateResult(result);

        int score = Helpers.CheckAnwer(numberOne, numberTwo, int.Parse(result), "-");

        return score;
    }

    internal static int Multiplication(int numberOne, int numberTwo)
    {
        Console.Clear();

        Console.WriteLine($"Example: {numberOne} * {numberTwo}");
        Console.Write("Your answer: ");
        var result = Console.ReadLine();

        // validation
        result = Helpers.ValidateResult(result);

        int score = Helpers.CheckAnwer(numberOne, numberTwo, int.Parse(result), "*");

        return score;
    }

    internal static int Division(int numberOne, int numberTwo)
    {
        Console.Clear();

        Console.WriteLine($"Example: {numberOne} / {numberTwo}");
        Console.Write("Your answer: ");
        var result = Console.ReadLine();

        // validation
        result = Helpers.ValidateDivisonResult(result);

        int score = Helpers.CheckDivisonAnswer(numberOne, numberTwo, double.Parse(result));

        return score;
    }
}
