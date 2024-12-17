using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Xunit;

public class TestArrayAndListMethods : AssignmentBase
{
    public string[] StringArray(string[] arr)
    {
        throw new NotImplementedException();
    }

    public int[] IntSum(int a, int b)
    {
        throw new NotImplementedException();
    }

    public List<string> LoopList(List<string> element)
    {
        throw new NotImplementedException();
    }

    [Assignment(1)]
    public void ShouldReturnStringArray()
    {
        string[] expected = new string[25];
        Assert.Equal(expected, StringArray(expected));
    }
    [Assignment(2)]
    public void ShouldReturnSumOfIntArray()
    {
        int[] sum = new int[3];
        Assert.Equal(sum, IntSum(1, 2));
    }
    [Assignment(3)]
    public void ShouldReturnANewElementInList()
    {
        List<string> expected = new List<string>();
        for (int i = 0; i < 15; i++)
        {
            Assert.Equal(expected, LoopList(expected));
        }
    }
}