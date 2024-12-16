using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Xunit;

public class TestDatastructures : AssignmentBase
{
    private string[]? strings;
    private int[]? integers;
    private double[]? doubles;
    private bool[]? booleans;
    private string[][]? strings2d;
    private int[][]? integers2d;
    private double[][]? doubles2d;

    private List<Object>? stringsList;
    private Dictionary<int, string>? keyValuePairs;

    [Assignment(1)]
    public void ShouldBeStringArray()
    {
        Assert.Equal(strings, new string[5]);
    }
    [Assignment(2)]
    public void ShouldBeIntArray()
    {
        Assert.Equal(integers, new int[5]);
    }
    [Assignment(3)]
    public void ShouldBeDoubleArray()
    {
        Assert.Equal(doubles, new double[5]);
    }
    [Assignment(4)]
    public void ShouldBeBooleanArray()
    {
        Assert.Equal(booleans, new bool[2]);
    }
    [Assignment(5)]
    public void ShouldBe2DStringArray()
    {
        Assert.Equal(strings2d, new string[1][]);
    }
    [Assignment(6)]
    public void ShouldBe2DIntArray()
    {
        Assert.Equal(integers2d, new int[1][]);
    }
    [Assignment(7)]
    public void ShouldBe2DArrayOfDoubles()
    {
        Assert.Equal(doubles2d, new double[1][]);
    }
    [Assignment(8)]
    public void ShouldBeListOfStrings()
    {
        Assert.Equal(new List<string>(), stringsList);
    }
    [Assignment(9)]
    public void ShouldBeDictionaryOfIntAndStrings()
    {
        Assert.Equal(new Dictionary<int, string>(), keyValuePairs);
    }
}