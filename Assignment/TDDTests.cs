using Xunit;

public class TDDTests
{

    public string HelloWorld(string str)
    {
        return str;
    }

    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
    /// <summary>
    /// 1 - I
    /// 1-2-3-4 -> IV (5-1) where 5 == V
    /// 5 -> V
    /// 6-7-8 -> VII (5+1) where 6 == V+=I
    /// 9 -> IX (10-1) where 10 == X
    /// 10-11-12-13 -> X+=I
    /// 40-41-42-43 -> L+=I where 50 == L
    /// 44 ->
    /// C == 100
    /// D == 500
    /// M == 1000
    /// </summary>
    /// <param name="numeral">the integer to convert to any given roman numeral</param>
    /// <returns>a given roman numeral</returns>
    public string RomanNumerals(int numeral)
    {
        Dictionary<int, string> romanNumerals = new Dictionary<int, string>()
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };
        return romanNumerals[numeral];
    }

    [Fact]
    public void ShouldReturnHelloWorld()
    {
        string expected = "Hello, World!";
        Assert.Equal(HelloWorld(expected), expected);
    }
    [Fact]
    public void ShouldAddTwoNumbers()
    {
        List<int> expected = new List<int>()
        {
            2, 4, 8, 12, 24, 32, 48, 64
        };
        foreach (int x in expected)
        {
            Assert.Equal(Add(x, x), x * 2);
        }
    }
    [Fact]
    public void ShouldMultiplyTwoNumbers()
    {
        Random random = new Random();
        int r1 = random.Next(1, 10);
        int r2 = random.Next(1, 10);
        Assert.Equal(Multiply(r1, r2), r1 * r2);
    }
    [Fact]
    public void ShouldBeRomanNumerals()
    {
        Dictionary<int, string> romanNumeralsSideB = new Dictionary<int, string>()
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };
        foreach (var numbers in romanNumeralsSideB)
        {
            Assert.Equal(RomanNumerals(numbers.Key), numbers.Value);
        }
    }
}