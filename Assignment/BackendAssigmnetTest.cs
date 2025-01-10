using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Xunit;

public class BackendAssignmentTest : AssignmentBase
{
    public float FloatFloor(float val)
    {
        throw new NotImplementedException();
    }

    public string NoE(string input)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<int> NoDuplicateInt(IEnumerable<int> input)
    {
        throw new NotImplementedException();
    }

    [Assignment(1)]
    public void TestFloatFloor()
    {
        float expected = 1.0F;
        List<float> input = [];
        for (int i = 0; i < 99; i++)
        {
            input.Add(1.0F + (0.01F * i));
        }

        input.ForEach((f) => {
            Assert.Equal(expected, FloatFloor(f));
        });
    }

    [Assignment(2)]
    public void TestNoEInString()
    {
        string input = "hEeEello world";
        string expected = "hllo world";

        Assert.Equal(expected, NoE(input));
    }

    [Assignment(3)]
    public void TestNoDuplicateInt()
    {
        int[] input = [1,1,1,1,1,1,2,2,3,3,4,4,5,6,17,7,7,8,8,89,9,1,1,13,15,132,2,2,22];
        Assert.Distinct(NoDuplicateInt(input));
    }
}