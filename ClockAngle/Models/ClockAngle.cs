using System;
namespace ClockAngle
{
  public class Clock
  {
    private int _hours;
    private int _minutes;
    //Check if Unit Test setup correctly
    public bool Default()
    {
      return true;
    }

    public Clock()
    {
      _hours = 0;
      _minutes = 0;
    }

    public Clock(int hours,int minutes)
    {
      _hours = hours;
      _minutes = minutes;
    }

    public int GetHours()
    {
      return _hours;
    }

    public int GetMinutes()
    {
      return _minutes;
    }

    public void SetTime(int hours,int minutes)
    {
      _hours = hours;
      _minutes = minutes;
    }

    public double GetDegrees()
    {
      const double degreeHours = 30.0;
      const double degreeMinutes = 0.5;

      if(_hours >= 12)
      {
        _hours -= 12;
      }
      return ((_hours*degreeHours)+(_minutes*degreeMinutes));
    }
  }
}
