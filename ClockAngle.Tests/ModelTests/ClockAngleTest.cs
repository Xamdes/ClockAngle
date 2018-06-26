using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngle;

namespace ClockAngle.Tests
{
  [TestClass]
  public class ClockAngleTest
  {
    [TestMethod]
    public void Return_True()
    {
      //Eventual Tests
      Clock clock = new Clock();
      Assert.AreEqual(true, clock.Default());
    }
    [TestMethod]
    public void Return_Degrees_True()
    {
      //Eventual Tests
      Clock clock = new Clock(0,2);
      Assert.AreEqual(1, clock.GetDegrees());
    }
    [TestMethod]
    public void Return_Hours_True()
    {
      //Eventual Tests
      Clock clock = new Clock(0,2);
      Assert.AreEqual(0, clock.GetHours());
    }
    [TestMethod]
    public void Return_Minutes_True()
    {
      //Eventual Tests
      Clock clock = new Clock(0,2);
      Assert.AreEqual(2, clock.GetMinutes());
    }
    [TestMethod]
    public void Return_Hour_10_Min_2_True()
    {
      //Eventual Tests
      Clock clock = new Clock(10,2);
      Assert.AreEqual(301, clock.GetDegrees());
    }
    [TestMethod]
    public void Return_Military_Hour_10_Min_2_True()
    {
      //Eventual Tests
      Clock clock = new Clock(22,2);
      Assert.AreEqual(301, clock.GetDegrees());
    }
    [TestMethod]
    public void Return_Degree_Minutes_True()
    {
      //Eventual Tests
      Clock clock = new Clock(10,15);
      Assert.AreEqual(90, clock.GetDegreeMinutes());
    }
    [TestMethod]
    public void Return_Degree_Diffrence_15_True()
    {
      //Eventual Tests
      Clock clock = new Clock(12,15);
      Assert.AreEqual(90, clock.GetDegreeDifference());
    }
    [TestMethod]
    public void Return_Degree_Diffrence_30_True()
    {
      //Eventual Tests
      Clock clock = new Clock(12,30);
      Assert.AreEqual(180, clock.GetDegreeDifference());
    }
    [TestMethod]
    public void Return_Degree_Diffrence_45_True()
    {
      //Eventual Tests
      Clock clock = new Clock(12,45);
      Assert.AreEqual(90, clock.GetDegreeDifference());
    }
    [TestMethod]
    public void Return_Degree_Diffrence_4_55_True()
    {
      //Eventual Tests
      Clock clock = new Clock(4,55);
      Assert.AreEqual(150, clock.GetDegreeDifference());
    }
    [TestMethod]
    public void Return_Degree_Diffrence_5_23_True()
    {
      //Eventual Tests
      Clock clock = new Clock(5,23);
      Assert.AreEqual(12, clock.GetDegreeDifference());
    }
    [TestMethod]
    public void Return_Degree_Diffrence_12_59_True()
    {
      //Eventual Tests
      Clock clock = new Clock(12,59);
      Assert.AreEqual(6, clock.GetDegreeDifference());
    }
    [TestMethod]
    public void Return_Degree_Diffrence_12_01_True()
    {
      //Eventual Tests
      Clock clock = new Clock(12,1);
      Assert.AreEqual(6, clock.GetDegreeDifference());
    }
  }
}
