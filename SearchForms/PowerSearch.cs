using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ArmenDiplom
{
  public partial class PowerSearch : Form
  {
    public static bool isOpened = false;
    private Dictionary<int, string> months;
    private IQueryable<BadPower> query;
    public PowerSearch()
    {
      InitializeComponent();
      months = new Dictionary<int, string>();
      months.Add(1, "Январь");
      months.Add(2, "Февраль");
      months.Add(3, "Март");
      months.Add(4, "Апрель");
      months.Add(5, "Май");
      months.Add(6, "Июнь");
      months.Add(7, "Июль");
      months.Add(8, "Август");
      months.Add(9, "Сентябрь");
      months.Add(10, "Октябрь");
      months.Add(11, "Ноябрь");
      months.Add(12, "Декабрь");
      isOpened = true;
    }

    private void dateCheckbox_CheckedChanged(object sender, EventArgs e)
    {
      if (dateCheckbox.Checked) DatePanel.Enabled = true;
      else DatePanel.Enabled = false;
    }

    private void beginDateTimePicker_Validating(object sender, CancelEventArgs e)
    {
      if (beginDateTimePicker.Value > DateTime.Now)
      {
        errorProvider1.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorProvider1.SetError((Control)sender, "Дата должна быть меньше сегодняшнего дня");
      }
      else
      {
        errorProvider1.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorProvider1.SetError((Control)sender, "");
      }
      if (beginDateTimePicker.Value > endDateTimePicker.Value)
      {
        errorProvider1.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorProvider1.SetError((Control)sender, "Начальная дата должна быть меньше или равно конечной даты");
      }
      else
      {
        errorProvider1.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorProvider1.SetError((Control)sender, "");
      }
    }

    private void endDateTimePicker_Validating(object sender, CancelEventArgs e)
    {
      if (endDateTimePicker.Value > DateTime.Now)
      {
        errorProvider1.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorProvider1.SetError((Control)sender, "Дата должна быть меньше сегодняшнего дня");
      }
      else
      {
        errorProvider1.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorProvider1.SetError((Control)sender, "");
      }
      if (endDateTimePicker.Value < beginDateTimePicker.Value)
      {
        errorProvider1.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorProvider1.SetError((Control)sender, "Конечная дата должна быть больше или равно начальной даты");
      }
      else
      {
        errorProvider1.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorProvider1.SetError((Control)sender, "");
      }
    }

    private void PowerSearch_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (dateCheckbox.Checked && (beginDateTimePicker.Value.Date > DateTime.Now || endDateTimePicker.Value.Date > DateTime.Now ||
        beginDateTimePicker.Value.Date > endDateTimePicker.Value.Date))
        MessageBox.Show("Поиск невозможен из за неправильных значений",
          "Ошибки ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      else
      {
        DataTable dataTable = new DataTable();
        dataTable.Columns.Add("Номер Модуля", typeof(int));
        dataTable.Columns.Add("Адрес", typeof(string));
        dataTable.Columns.Add("Год", typeof(int));
        dataTable.Columns.Add("Месяц", typeof(string));
        dataTable.Columns.Add("Батарейка", typeof(string));
        if (!dateCheckbox.Checked)
        {
           query = from f in DataBaseAccess.db.ShkafStatements
                      where f.Power == false
                      select new BadPower
                      {
                        ShkafID = f.ShkafID,
                        Address = f.Shkaf.Address,
                        Year = f.Year,
                        Month = months[f.Month],
                        Power = f.Power ? "заряженна" : "разряженна"
                      };
          foreach (var b in query)
          {
            dataTable.Rows.Add(new object[] { b.ShkafID, b.Address, b.Year, b.Month, b.Power });
          }
        }
        else if (beginDateTimePicker.Value.Year != endDateTimePicker.Value.Year)
        {
          var query1 = from f in DataBaseAccess.db.ShkafStatements
                       where f.Power == false &&
                       f.Year > (dateCheckbox.Checked ? beginDateTimePicker.Value.Year : 1900) &&
                       f.Year < (dateCheckbox.Checked ? endDateTimePicker.Value.Year : 2100)
                       select new BadPower
                       {
                         ShkafID = f.ShkafID,
                         Address = f.Shkaf.Address,
                         Year = f.Year,
                         Month = months[f.Month],
                         Power = f.Power ? "заряженна" : "разряженна"
                       };

          var query2 = from f in DataBaseAccess.db.ShkafStatements
                       where f.Power == false &&
                       f.Year == (dateCheckbox.Checked ? beginDateTimePicker.Value.Year : 1900) &&
                       f.Month >= (dateCheckbox.Checked ? beginDateTimePicker.Value.Month : 1)
                       select new BadPower
                       {
                         ShkafID = f.ShkafID,
                         Address = f.Shkaf.Address,
                         Year = f.Year,
                         Month = months[f.Month],
                         Power = f.Power ? "заряженна" : "разряженна"
                       };
          var query3 = from f in DataBaseAccess.db.ShkafStatements
                       where f.Power == false &&
                       f.Year == (dateCheckbox.Checked ? endDateTimePicker.Value.Year : 2100) &&
                       f.Month <= (dateCheckbox.Checked ? endDateTimePicker.Value.Month : 12)
                       select new BadPower
                       {
                         ShkafID = f.ShkafID,
                         Address = f.Shkaf.Address,
                         Year = f.Year,
                         Month = months[f.Month],
                         Power = f.Power ? "заряженна" : "разряженна"
                       };
           query = query1.Union(query2).Union(query3);
          //SetupColumns();
          foreach (var b in query)
          {
            dataTable.Rows.Add(new object[] { b.ShkafID, b.Address, b.Year, b.Month, b.Power });
          }
        }
        else
        {
           query = from f in DataBaseAccess.db.ShkafStatements
                      where f.Power == false && f.Year == beginDateTimePicker.Value.Year
                      && f.Month >= beginDateTimePicker.Value.Month && f.Month <= endDateTimePicker.Value.Month
                      select new BadPower
                      {
                        ShkafID = f.ShkafID,
                        Address = f.Shkaf.Address,
                        Year = f.Year,
                        Month = months[f.Month],
                        Power = f.Power ? "заряженна" : "разряженна"
                      };
          foreach (var b in query)
          {
            dataTable.Rows.Add(new object[] { b.ShkafID, b.Address, b.Year, b.Month, b.Power });
          }
        }
        dataGridView1.DataSource = dataTable;
        
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (dateCheckbox.Checked && (beginDateTimePicker.Value > DateTime.Now || endDateTimePicker.Value > DateTime.Now ||
        beginDateTimePicker.Value > endDateTimePicker.Value))
        MessageBox.Show("Поиск невозможен из за неправильных значений",
          "Ошибки ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      else
      {
        var a = query.ToList();
        if (!PowerReportForm.isOpened)
        {
          PowerReportForm powerReportForm =
            new PowerReportForm(a, beginDateTimePicker.Value.ToShortDateString(),
              endDateTimePicker.Value.ToShortDateString(), dateCheckbox.Checked);
          powerReportForm.Show();
        }
      }
    }
  }
  public class BadPower
  {
    public int ShkafID { get; set; }
    public string Address { get; set; }
    public int Year { get; set; }
    public string Month { get; set; }
    public string Power { get; set; }
  }
}
