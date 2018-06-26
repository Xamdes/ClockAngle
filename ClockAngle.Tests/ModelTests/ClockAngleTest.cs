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
  }
}
