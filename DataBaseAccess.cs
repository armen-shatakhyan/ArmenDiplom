using System;
using System.Windows.Forms;
using System.Linq;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Collections;
using System.Text;
using System.IO;

namespace ArmenDiplom
{
  public class DataBaseAccess
  {
    private static string conString = ConfigurationManager.ConnectionStrings["ArmenDiplom"].ConnectionString;
    public static ArmenDiplomDataContext db = new ArmenDiplomDataContext(conString);

    public static void UpdateShkaf(Shkaf newShkaf, int oldShkafID)
    {
      var query = from shkaf in DataBaseAccess.db.Shkafs
                         where shkaf.ShkafID == oldShkafID
                         select shkaf;
      try
      {
        foreach (Shkaf shkaf in query)
        {
          //shkaf.ShkafID = newShkaf.ShkafID;
          shkaf.Address = newShkaf.Address;
          shkaf.InstallDate = newShkaf.InstallDate;
          shkaf.PoverkaDate = newShkaf.PoverkaDate;
          shkaf.Installer = newShkaf.Installer;
          shkaf.CountersQuantity = newShkaf.CountersQuantity;
          //shkaf.Is5YearPoverka = newShkaf.Is5YearPoverka;
          //shkaf.IsUnauthorizedAccess = newShkaf.IsUnauthorizedAccess;
          shkaf.Password1 = newShkaf.Password1;
          shkaf.Password2 = newShkaf.Password2;
          shkaf.Password3 = newShkaf.Password3;
        }
        db.SubmitChanges();
        MessageBox.Show("Корректировка модуля прошла успешно.", "Подтверждение!", 
          MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      catch (Exception e)
      {
        MessageBox.Show("Ошибка при корректировке модуля. Корректировка не сохранена.", 
          "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public static void NewShkaf(Shkaf newShkaf)
    {
      try
      {
        db.Shkafs.InsertOnSubmit(newShkaf);
        db.SubmitChanges();
        MessageBox.Show("Модуль создан.", "Подтверждение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception e)
      {
        MessageBox.Show("Ошибка при создании модуля. Модуль не создан.", 
          "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public static void DeleteShkaf(Shkaf delShkaf)
    {
      try
      {
        var query = from shkaf in db.Shkafs
                    where shkaf.ShkafID == delShkaf.ShkafID
                    select shkaf; 

        foreach (Shkaf shkaf in query)
        {
          db.Shkafs.DeleteOnSubmit(shkaf);
        }

        db.SubmitChanges();
      }

      catch (Exception e)
      {
        MessageBox.Show("Ошибка при удалении модуля " + delShkaf.ShkafID + ".", "Ошибка!", 
          MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public static void NewCounter(Counter newCounter)
    {
      try
      {
        db.Counters.InsertOnSubmit(newCounter);
        db.SubmitChanges();
        MessageBox.Show("Счетчик создан.", "Подтверждение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception e)
      {
        MessageBox.Show("Ошибка при создании счетчика. Счетчик не создан.", 
          "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public static void DeleteCounter(Counter delCounter)
    {
      try
      {
        var query = from counter in db.Counters
                    where counter.CounterID == delCounter.CounterID
                    select counter;

        foreach (Counter counter in query)
        {
          db.Counters.DeleteOnSubmit(counter);
        }
        db.SubmitChanges();

        if (query.Count() > 1) MessageBox.Show("Отмеченные счетчики удалены.", 
          "Подтверждение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        else MessageBox.Show("Отмеченный счетчик удален.", 
          "Подтверждение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      catch (Exception e)
      {
        MessageBox.Show("Ошибка при удалении счетчика "  + delCounter.CounterID + ". ", "Ошибка!", 
          MessageBoxButtons.OK, MessageBoxIcon.Error );
      }
    }

    public static void UpdateCounter(Counter newCounter)
    {
      var query = from counter in DataBaseAccess.db.Counters
                  where counter.CounterID == newCounter.CounterID
                  select counter;
      
      try
      {
        foreach (var counter in query)
        {
          //counter.Shkaf = newCounter.Shkaf;
          db.Counters.DeleteOnSubmit(counter);
        }
        db.Counters.InsertOnSubmit(newCounter);
        db.SubmitChanges();
      }

      catch (Exception e)
      {
        MessageBox.Show("Ошибка при корректировке счетчика. Корректировка не сохранена.", 
          "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error );
      }
    }

    public static void CheckFile(string fullName, string shkafName, ref string errMessage, ref string infoMessage)
    {
      //int dotIndex = fileName.IndexOf('.');
      //string shkafName = fileName.Substring(0, dotIndex);

      if (!IsCorrectShkaf(shkafName, ref errMessage)) return;
      if (!IsCorrectDate(fullName, shkafName, ref errMessage)) return;

      using (FileStream fs = new FileStream(fullName, FileMode.Open, FileAccess.Read))
      {
        BinaryReader r = new BinaryReader(fs);
        DateTime dt = File.GetCreationTime(fullName);
        try
        {
          int countersCount = fs.ReadByte();
          if (!IsCorrectCountersQuantity(shkafName, countersCount, ref errMessage)) return;
          int powerCurrent = fs.ReadByte();
          int powerPast = fs.ReadByte();
          int accessCurrent = fs.ReadByte();
          int accessPast = fs.ReadByte();

          if (powerCurrent == 0) infoMessage += "- батарейка в модуле номер " + shkafName + " разряжена!\n";
          if (accessCurrent > 1) infoMessage += "- Доступ к модулю номер " + shkafName +
            " был осуществлен более чем 1 раз за текущий месяц!\n";

          InputAccessPower(shkafName, powerCurrent, powerPast, accessCurrent, accessPast);

          for (int i = 0; i < countersCount; i++)
          {
            int counterID = r.ReadInt32();
            var query = from f in db.Counters
                        where f.CounterID == counterID && f.ShkafID == int.Parse(shkafName)
                        select f;
            if (!query.Any())
            {
              errMessage += "- Счетчик с номером " + counterID + " принадлежащий модулю с номером " + 
                            shkafName + " в базе отсутствует!\n";
              continue;
            }

            float tarif1Current = r.ReadSingle();
            float tarif2Current = r.ReadSingle();
            float tarif3Current = r.ReadSingle();
            float tarif4Current = r.ReadSingle();
            float tarif1Past = r.ReadSingle();
            float tarif2Past = r.ReadSingle();
            float tarif3Past = r.ReadSingle();
            float tarif4Past = r.ReadSingle();

            InputTarifs(counterID, tarif1Current, tarif2Current, tarif3Current, tarif4Current, 
                        tarif1Past, tarif2Past, tarif3Past, tarif4Past);
          }
        }
        catch (Exception e)
        {
          errMessage += "- Файл " + shkafName + ".bi поврежден или не в корректном формате, чтение прервано!\n";
        }

        finally
        {
          r.Close();
        }
      }
    }

    public static bool IsCorrectShkaf(string shkafName, ref string errMessage)
    {
      int a = (from f in db.Shkafs
              where f.ShkafID == int.Parse(shkafName)
              select f).Count();
      if (a == 0)
      {
        errMessage += "- Модуль с номером " + shkafName + " в базе не существует!\n";
        return false;
      }
      else return true;
    }

    public static bool IsCorrectCountersQuantity(string shkafName, int count, ref string errMessage)
    {
      int a = (from f in db.Shkafs
                  where f.ShkafID == int.Parse(shkafName)
                  select f.Counters.Count).First();

      if (a != count)
      {
        errMessage += "- Количество счетчиков в модуле " + shkafName + " (" + count.ToString() +
        ")не совпадает с количеством счетчиков записанных в базе (" + a.ToString() + ")!\n";
        return false;
      }
      else return true;
    }

    public static bool IsCorrectDate(string fullName, string shkafName, ref string errMessage)
    {
      DateTime createTime = File.GetCreationTime(fullName);
      DateTime modTime = File.GetLastWriteTime(fullName);
      if ((modTime - createTime).Minutes > 3)
      {
        errMessage += "- После создания файлa " + shkafName + ".bi был модифицирован. Время создания: " +
          createTime.ToString() + " Время изменения: " + modTime.ToString() + " !\n";
        return false;
      }
      else if (createTime.Year != DateTime.Now.Year)
      {
        errMessage += "- Год создания файла " + shkafName + ".bi (" + createTime.Year.ToString() +
          ") не совпадает с текущим годом (" + DateTime.Now.Year.ToString() + ")!\n";
        return false;
      }
      else if (createTime.Month != DateTime.Now.Month)
      {
        errMessage += "- Месяц создания файла " + shkafName + ".bi (" + createTime.Month.ToString() +
          ") не совпадает с текущим месяцем (" + DateTime.Now.Month.ToString() + ")!\n";
        return false;
      }
      else return true;
    }

    public static void InputAccessPower(string shkafName, int powerCurrent, int powerPast, 
                                        int accessCurrent, int accessPast)
    {
      var query = from f in db.ShkafStatements
                  where f.ShkafID == int.Parse(shkafName) && 
                  ((f.Year == DateTime.Now.Year && f.Month == DateTime.Now.Month) ||
                  (f.Year == DateTime.Now.AddMonths(-1).Year && f.Month == DateTime.Now.AddMonths(-1).Month))  
                  select f;

      if (query.Any()) db.ShkafStatements.DeleteAllOnSubmit(query);

      ShkafStatement statPast = new ShkafStatement
      {
        ShkafID = int.Parse(shkafName),
        Year = DateTime.Now.AddMonths(-1).Year,
        Month = DateTime.Now.AddMonths(-1).Month,
        Power = (powerPast == 1 ? true : false),
        AccessQuantity = accessPast
      };
      db.ShkafStatements.InsertOnSubmit(statPast);

      ShkafStatement statCurrent = new ShkafStatement
      {
        ShkafID = int.Parse(shkafName),
        Year = DateTime.Now.Year,
        Month = DateTime.Now.Month,
        Power = (powerCurrent == 1 ? true : false),
        AccessQuantity = accessCurrent
      };
      db.ShkafStatements.InsertOnSubmit(statCurrent);

      db.SubmitChanges();
    }

    public static void InputTarifs(int counterID, float tarif1Current, float tarif2Current, float tarif3Current,
      float tarif4Current, float tarif1Past, float tarif2Past, float tarif3Past, float tarif4Past)
    {
      var query = from f in db.CounterStatements
                  where f.CounterID == counterID &&
                  ((f.Year == DateTime.Now.Year && f.Month == DateTime.Now.Month) ||
                  (f.Year == DateTime.Now.AddMonths(-1).Year && f.Month == DateTime.Now.AddMonths(-1).Month))
                  select f;

      if (query.Any()) db.CounterStatements.DeleteAllOnSubmit(query);

      CounterStatement statPast = new CounterStatement
      {
        CounterID = counterID,
        Year = DateTime.Now.AddMonths(-1).Year,
        Month = DateTime.Now.AddMonths(-1).Month,
        Tarif1 = (decimal)tarif1Past,
        Tarif2 = (decimal)tarif2Past,
        Tarif3 = (decimal)tarif3Past,
        Tarif4 = (decimal)tarif4Past
      };
      db.CounterStatements.InsertOnSubmit(statPast);

      CounterStatement statCurrent = new CounterStatement
      {
        CounterID = counterID,
        Year = DateTime.Now.Year,
        Month = DateTime.Now.Month,
        Tarif1 = (decimal)tarif1Current,
        Tarif2 = (decimal)tarif2Current,
        Tarif3 = (decimal)tarif3Current,
        Tarif4 = (decimal)tarif4Current
      };
      db.CounterStatements.InsertOnSubmit(statCurrent);

      db.SubmitChanges();
    }
  }
}
