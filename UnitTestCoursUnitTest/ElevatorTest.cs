using UnitTestCours;

namespace UnitTestCoursUnitTest;

[TestClass]
public class ElevatorTest
{

    private var elevator = new Elevator(500);

    [TestMethod]
    public void AddUser_return100()
    {
        var elevator = new Elevator(500);

        var employee = new Employee();
        employee.IsExecutive = true;
        employee.Weight = 100;

        elevator.InUser(employee);

        Assert.AreEqual(elevator.CurrentWeight, 100);
    }

    [TestMethod]
    public void removeUser_return0()
    {
        var elevator = new Elevator(500);

        var employee = new Employee();
        employee.IsExecutive = true;
        employee.Weight = 100;

        elevator.InUser(employee);
        elevator.OutUser(employee);

        Assert.AreEqual(elevator.CurrentWeight, 0);
    }

    [TestMethod]
    public void CheckMaxWeightAllowedReached_returnFalse()
    {
        var elevator = new Elevator(500);

        var employee = new Employee();
        employee.IsExecutive = true;
        employee.Weight = 100;

        elevator.InUser(employee);

        var result = elevator.CheckMaxWeightAllowedReached();

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void GoToVipSection_returnTrue()
    {
        var elevator = new Elevator(500);

        var employee = new Employee();
        employee.IsExecutive = true;
        employee.Weight = 100;

        elevator.InUser(employee);

        var result = elevator.GoToVipSection(employee);

        Assert.IsTrue(result);
    }
}