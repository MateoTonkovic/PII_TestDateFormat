namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectFormat()
    {
        string date = "01/01/2021";
        string expected = "2021-01-01";

        string actual = DateFormatter.ChangeFormat(date);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void IncorrectFormat()
    {
        string date = "01/01/20212432";
        string expected = "";


        string actual = DateFormatter.ChangeFormat(date);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void BlankDate()
    {
        string date = "";
        string expected = "";

        string actual = DateFormatter.ChangeFormat(date);

        Assert.AreEqual(expected, actual);
    }
}