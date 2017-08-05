using System;
using System.Collections.Generic;
using System.Text;

namespace ArmenDiplom
{
  public class CelebrationDay
  {
    private int celebrationDayID;
    private int celebrationDay;
    private int celebrationMonth;

    public CelebrationDay(int celebrationDayID, int celebrationDay, int celebrationMonth)
    {
      this.celebrationDayID = celebrationDayID;
      this.celebrationDay = celebrationDay;
      this.celebrationMonth = celebrationMonth;
    }

    public int CelebrationDayID
    {
      get { return celebrationDayID; }
    }

    public int CelebrationDay
    {
      get { return celebrationDay; }
      set { celebrationDay = value; }
    }

    public int CelebrationMonth
    {
      get { return celebrationMonth; }
      set { celebrationDay = value; }
    }

  }
}
