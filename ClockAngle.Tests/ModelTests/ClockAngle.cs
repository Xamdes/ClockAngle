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
  }
}
