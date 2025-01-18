namespace QSort;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var input = new int[] {  8, 7, 2, 1, 0, 9, 6  };
        var output = new int[input.Length];
        Array.Copy(input, output, input.Length);
        Array.Sort(output);
        QSort.Sort(input, 0, input.Length - 1);
        Assert.AreEqual(output, input);
    }
}