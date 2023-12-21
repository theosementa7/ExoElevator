using UnitTestCours;

namespace UnitTestCoursUnitTest;

[TestClass]
public class CalculatorTest
{
    [TestMethod]
    [DataRow(1, 2, 3)]
    [DataRow(4, 3, 7)]
    [DataRow(6, 7, 13)]
    public void Add_WithTwoNumbers_ReturnAddition(int num1, int num2, int exeptedResult)
    {
        var calculator = new Calculator();

        var result = calculator.Add(num1, num2);

        Assert.AreEqual(result, exeptedResult);
    }

    [TestMethod]
    public void Substract_WithTwoNumbers_ReturnSubstraction()
    {
        var calculator = new Calculator();

        var result = calculator.Substract(2, 1);

        Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void Multiply_WithTwoNumbers_ReturnMuplitication()
    {
        var calculator = new Calculator();

        var result = calculator.Multiply(4, 4);

        Assert.AreEqual(result, 16);
    }

    [TestMethod]
    public void Divide_WithTwoNumbers_ReturnDivision()
    {
        var calculator = new Calculator();

        var result = calculator.Divide(4, 4);

        Assert.AreEqual(result, 1);
    }

    //[TestMethod]
    //public void Divide_WithTwoNumbers_ReturnError()
    //{
    //    var calculator = new Calculator();

    //    var result = calculator.Divide(4, 0);

    //    Assert.AreEqual(result, "numberTwo cannot be equal to zero");
    //}

}