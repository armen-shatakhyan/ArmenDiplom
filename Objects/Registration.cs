using System;
using System.Collections.Generic;
using System.Text;

namespace ArmenDiplom
{
  public class Registration
  {
    private int registrationID;
    private int counterID;
    private int payMonth;
    private int payYear;

    public Registration(int registrationID, int counterID, int payMonth, int payYear)
    {
      this.registrationID = registrationID;
      this.counterID = counterID;
      this.payMonth = payMonth;
      this.payYear = payYear;
    }

    public int RegistrationID
    {
      get { return registrationID; }
    }

    public int CounterID
    {
      get { return counterID; }
      set { counterID = value; }
    }

    public int PayMonth
    {
      get { return payMonth; }
      set { payMonth = value; }
    }

    public int PayYear
    {
      get { return payYear; }
      set { payYear = value; }
    }
  }
}
