using DateValidatorProject;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UnitTestCoursUnitTest;

[TestClass]
public class DateValidatorTest
{

    private DateValidator _dateValidator;

    [TestMethod]
    [Ignore]
    [DataRow("20-12-2023")]
    [DataRow("20--12-2023")]
    public void NumbersOfDashes_returnTrue(string date)
    {
        var dateValidator = new DateValidator(date);
        var result = dateValidator.CheckNumberOfDashes();

        Assert.IsTrue(result);
    }

    [TestMethod]
    [Ignore]
    [DataRow("20-12-2023")]
    [DataRow("20--12--2023")]
    public void NumbersOfDashes_returnExpetion(string date)
    {
        Assert.ThrowsException<Exception>(() => _dateValidator = new DateValidator(date));
    }

    [TestMethod]
    [Ignore]
    [DataRow("20-12-2023")]
    [DataRow("dd-mm-yyyy")]
    public void AllNumbersAreIntegers(string date)
    {
        var dateValidator = new DateValidator(date);
        var result = dateValidator.CheckAllNumbersAreIntegers();

        Assert.IsTrue(result);
    }

    [TestMethod]
    [Ignore]
    [DataRow("20-12-2023")]
    [DataRow("dd-mm-yyyy")]
    public void ThrowExceptionIfNumbersAreNotIntegers_returnExeption(string date)
    {
        var dateValidator = new DateValidator(date);

        Assert.ThrowsException<InvalidCastException>(() => dateValidator.ThrowExceptionIfNumbersAreNotIntegers());
    }

    [TestMethod]
    [Ignore]
    [DataRow("20-12-2023")]
    [DataRow("40-12-2023")]
    public void CheckDayNumber(string date)
    {
        var dateValidator = new DateValidator(date);
        var result = dateValidator.CheckDayNumber();

        Assert.IsTrue(result);
    }

    [TestMethod]
    [Ignore]
    [DataRow("20-12-2023")]
    [DataRow("20-18-2023")]
    public void CheckMonthNumber(string date)
    {
        var dateValidator = new DateValidator(date);
        var result = dateValidator.CheckMonthNumber();

        Assert.IsTrue(result);
    }

    [TestMethod]
    [Ignore]
    [DataRow("20-12-2023")]
    [DataRow("20-12-10")]
    public void CheckYearNumber(string date)
    {
        var dateValidator = new DateValidator(date);
        var result = dateValidator.CheckYearNumber();

        Assert.IsTrue(result);
    }

    [TestMethod]
    [Ignore]
    [DataRow("20-12-2023")]
    [DataRow("20-12--2023")]
    public void IsValid(string date)
    {
        var dateValidator = new DateValidator(date);
        var result = dateValidator.IsValid();

        Assert.IsTrue(result);
    }
}
