using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;

namespace ArmenDiplom
{
  public class Shkaf
  {
    private SqlInt32 shkafID;
    private SqlString address;
    private SqlDateTime? installDate;
    private SqlDateTime? poverkaDate;
    private SqlString installer;
    private SqlInt32? counters;
    private SqlBoolean? is5YearPoverka;
    private SqlBoolean? isUnauthorizedAccess;
    private SqlInt32? password1;
    private SqlInt32? password2;
    private SqlInt32? password3;

    public Shkaf(SqlInt32 shkafID, SqlString address, SqlDateTime? installDate, SqlDateTime? poverkaDate,
      SqlString installer, SqlInt32? counters, SqlBoolean? is5YearPoverka, SqlBoolean? isUnauthorizedAccess,
      SqlInt32? password1, SqlInt32? password2, SqlInt32? password3)
    {
      this.shkafID = shkafID;
      this.address = address;
      this.installDate = installDate;
      this.poverkaDate = poverkaDate;
      this.installer = installer;
      this.counters = counters;
      this.is5YearPoverka = is5YearPoverka;
      this.isUnauthorizedAccess = isUnauthorizedAccess;
      this.password1 = password1;
      this.password2 = password2;
      this.password3 = password3;
    }

    public SqlInt32 ShkafID
    {
      get { return shkafID; }
      set { shkafID = value; }
    }

    public SqlString Address
    {
      get { return address; }
      set { address = value; }
    }

    public SqlDateTime? InstallDate
    {
      get { return installDate; }
      set { installDate = value; }
    }

    public SqlDateTime? PoverkaDate
    {
      get { return poverkaDate; }
      set { poverkaDate = value; }
    }

    public SqlString Installer
    {
      get { return installer; }
      set { installer = value; }
    }

    public SqlInt32? Counters
    {
      get { return counters; }
      set { counters = value; }
    }

    public SqlBoolean? Is5YearPoverka
    {
      get { return is5YearPoverka; }
      set { is5YearPoverka = value; }
    }

    public SqlBoolean? IsUnauthorizedAccess
    {
      get { return isUnauthorizedAccess; }
      set { isUnauthorizedAccess = value; }
    }

    public SqlInt32? Password1
    {
      get { return password1; }
      set { password1 = value; }
    }

    public SqlInt32? Password2
    {
      get { return password2; }
      set { password2 = value; }
    }

    public SqlInt32? Password3
    {
      get { return password3; }
      set { password3 = value; }
    }
    public override string ToString()
    {
      return ShkafID.ToString();
    }
  }
}
