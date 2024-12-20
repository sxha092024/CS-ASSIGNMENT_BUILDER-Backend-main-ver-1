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
    /// <summary>
    /// Implement a simple Dictionary method
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Dictionary<int, string> LoopDict(Dictionary<int, string> element)
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
    [Assignment(4)]
    public void ShouldReturnANewDictionary()
    {
        Dictionary<int, string> expected = new Dictionary<int, string>() {
            {1,""}, {2,"Hello World!"}, {3, "foo"}, {4, "bar"}, {5, "foo"}, {6, "baz"}
        };
        for (int i = 0; i < 10; i++)
        {
            Assert.Equal(expected, LoopDict(expected));
        }
    }
}