using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;

namespace ArmenDiplom
{
  public class Counter
  {
    private SqlInt32 counterID;
    private Shkaf shkaf;
    private SqlString counterOwner;
    private SqlString telephoneOwner;
    private SqlBoolean? isNonPaynted;
    private SqlDateTime? installDate;
    private SqlInt32? currentMonthDayEnergy;
    private SqlInt32? currentMonthNightEnergy;
    private SqlInt32? pastMonthDayEnergy;
    private SqlInt32? pastMonthNightEnergy;

    public Counter(SqlInt32 counterID, Shkaf shkaf, SqlString counterOwner, SqlString telephoneOwner, 
      SqlBoolean? isNonPaynted, SqlDateTime? installDate, SqlInt32? currentMonthDayEnergy, 
      SqlInt32? currentMonthNightEnergy, SqlInt32? pastMonthDayEnergy, SqlInt32? pastMonthNightEnergy)
    {
      this.counterID = counterID;
      this.shkaf = shkaf;
      this.counterOwner = counterOwner;
      this.telephoneOwner = telephoneOwner;
      this.isNonPaynted = isNonPaynted;
      this.installDate = installDate;
      this.currentMonthDayEnergy = currentMonthDayEnergy;
      this.currentMonthNightEnergy = currentMonthNightEnergy;
      this.pastMonthDayEnergy = pastMonthDayEnergy;
      this.pastMonthNightEnergy = pastMonthNightEnergy;
    }

    public SqlInt32 CounterID
    {
      get { return counterID; }
    }

    public Shkaf Shkaf
    {
      get { return shkaf; }
      set { shkaf = value; }
    }

    public SqlString CounterOwner
    {
      get { return counterOwner; }
      set { counterOwner = value; }
    }

    public SqlString TelephoneOwner
    {
      get { return telephoneOwner; }
      set { telephoneOwner = value; }
    }

    public SqlBoolean? IsNonPaynted
    {
      get { return isNonPaynted; }
      set { isNonPaynted = value; }
    }

    public SqlDateTime? InstallDate
    {
      get { return installDate; }
      set { installDate = value; }
    }

    public SqlInt32? CurrentMonthDayEnergy
    {
      get { return currentMonthDayEnergy; }
      set { currentMonthDayEnergy = value; }
    }

    public SqlInt32? CurrentMonthNightEnergy
    {
      get { return currentMonthNightEnergy; }
      set { currentMonthNightEnergy = value; }
    }

    public SqlInt32? PastMonthDayEnergy
    {
      get { return pastMonthDayEnergy; }
      set { pastMonthDayEnergy = value; }
    }

    public SqlInt32? PastMonthNightEnergy
    {
      get { return pastMonthNightEnergy; }
      set { pastMonthNightEnergy = value; }
    }
  }
}
