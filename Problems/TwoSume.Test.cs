using NUnit.Framework;
using leetcodes.Problems;


[TestFixture]
public class TwoSumTests
{
    private TwoSum solution;

    [SetUp]
    public void Setup()
    {
        solution = new TwoSum();
    }

    [Test]
    public void TestExampleCase()
    {
        Assert.AreEqual(new int[] { 0, 1 }, solution.TwoSumFunc(new int[] { 2, 7, 11, 15 }, 9));
    }

    [Test]
    public void TestNoSolution()
    {
        Assert.IsEmpty(solution.TwoSumFunc(new int[] { 1, 2, 3 }, 7));
    }

    [Test]
    public void TestMultipleSolutions()
    {
        Assert.AreEqual(new int[] { 1, 2 }, solution.TwoSumFunc(new int[] { 3, 2, 4 }, 6));
    }

    [Test]
    public void TestNegativeNumbers()
    {
        Assert.AreEqual(new int[] { 2, 4 }, solution.TwoSumFunc(new int[] { -1, -2, -3, -4, -5 }, -8));
    }

    [Test]
    public void TestLargeNumbers()
    {
        Assert.AreEqual(new int[] { 1, 2 }, solution.TwoSumFunc(new int[] { 1000000, 500000, 500000 }, 1000000));
    }
}