using System;
using System.Collections.Generic;
using System.Text;

namespace ArmenDiplom
{
  public class Tarif
  {
    private int tarifID;
    private int dayTarifBeginHour;
    private int dayTarifEndHour;
    private int nightTarifBeginHour;
    private int nightTarifEndHour;
    private int dayTarifCena;
    private int nightTarifCena;

    public Tarif(int tarifID, int dayTarifBeginHour, int dayTarifEndHour,
      int nightTarifBeginHour, int nightTarifEndHour, int dayTarifCena, int nightTarifCena)
    {
      this.tarifID = tarifID;
      this.dayTarifBeginHour = dayTarifBeginHour;
      this.dayTarifEndHour = dayTarifEndHour;
      this.nightTarifBeginHour = nightTarifBeginHour;
      this.nightTarifEndHour = nightTarifEndHour;
      this.dayTarifCena = dayTarifCena;
      this.nightTarifCena = nightTarifCena;
    }

    public int TarifID
    {
      get { return tarifID; }
      set { tarifID = value; }
    }

    public int DayTarifBeginHour
    {
      get { return dayTarifBeginHour; }
      set { dayTarifBeginHour = value; }
    }

    public int DayTarifEndHour
    {
      get { return dayTarifEndHour; }
      set { dayTarifEndHour = value; }
    }

    public int NightTarifBeginHour
    {
      get { return nightTarifEndHour; }
      set { nightTarifEndHour = value; }
    }

    public int NightTarifEndHour
    {
      get { return nightTarifEndHour; }
      set { nightTarifEndHour = value; }
    }

    public int DayTarifCena
    {
      get { return dayTarifCena; }
      set { dayTarifCena = value; }
    }

    public int NightTarifCena
    {
      get { return nightTarifCena; }
      set { nightTarifCena = value; }
    }

  }
}
