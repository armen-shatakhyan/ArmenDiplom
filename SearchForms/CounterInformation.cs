using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArmenDiplom
{
  public partial class CounterInformation : Form
  {
    public static bool isOpened = false;
    private Dictionary<int, string> months;
    private IQueryable<CounterInformationR> query;
    public CounterInformation()
    {
      InitializeComponent();
      isOpened = true;
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
    }

    private void CounterInformation_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }

    private void counterListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      ownerNameTextBox.Text = (counterListBox.SelectedItem as Counter).CounterOwner;
      counterDateTextBox.Text = (counterListBox.SelectedItem as Counter).InstallDate.ToShortDateString();
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

    private void button1_Click(object sender, EventArgs e)
    {
      if (dateCheckbox.Checked && (beginDateTimePicker.Value.Date > DateTime.Now || endDateTimePicker.Value.Date > DateTime.Now ||
        beginDateTimePicker.Value.Date > endDateTimePicker.Value.Date))
        MessageBox.Show("Поиск невозможен из за неправильных значений",
          "Ошибки ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      else if (counterListBox.SelectedIndex == -1)
        MessageBox.Show("Не выбран счетчик", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      else 
      {
        DataTable dataTable = new DataTable();
        decimal tarif1Sum = decimal.Zero;
        decimal tarif2Sum = decimal.Zero;
        decimal tarif3Sum = decimal.Zero;
        decimal tarif4Sum = decimal.Zero;
        dataTable.Columns.Add("Год", typeof(int));
        dataTable.Columns.Add("Месяц", typeof(string));
        dataTable.Columns.Add("Расход электроэнергии 1 Тариф (кВт/час)", typeof(decimal));
        dataTable.Columns.Add("Расход электроэнергии 2 Тариф (кВт/час)", typeof(decimal));
        dataTable.Columns.Add("Расход электроэнергии 3 Тариф (кВт/час)", typeof(decimal));
        dataTable.Columns.Add("Расход электроэнергии 4 Тариф (кВт/час)", typeof(decimal));
        if (!dateCheckbox.Checked)
        {
           query = from f in DataBaseAccess.db.CounterStatements
                      where f.Counter == counterListBox.SelectedItem as Counter
                      select new CounterInformationR
                       {
                         Year = f.Year,
                         Month = months[f.Month],
                         Tarif1 = f.Tarif1,
                         Tarif2 = f.Tarif2,
                         Tarif3 = f.Tarif3,
                         Tarif4 = f.Tarif4
                       };
          foreach (var q in query)
          {
            dataTable.Rows.Add(new object[] { q.Year, q.Month, q.Tarif1, q.Tarif2, q.Tarif3, q.Tarif4 });
            tarif1Sum += q.Tarif1;
            tarif2Sum += q.Tarif2;
            tarif3Sum += q.Tarif3;
            tarif4Sum += q.Tarif4;
          }
        }
        else if (beginDateTimePicker.Value.Year != endDateTimePicker.Value.Year)
        {
          var query1 = from f in DataBaseAccess.db.CounterStatements
                       where f.Counter == counterListBox.SelectedItem as Counter &&
                       f.Year > beginDateTimePicker.Value.Year &&
                       f.Year < endDateTimePicker.Value.Year
                       select new CounterInformationR
                       {
                         Year = f.Year,
                         Month = months[f.Month],
                         Tarif1 = f.Tarif1,
                         Tarif2 = f.Tarif2,
                         Tarif3 = f.Tarif3,
                         Tarif4 = f.Tarif4
                       };

          var query2 = from f in DataBaseAccess.db.CounterStatements
                       where f.Counter == counterListBox.SelectedItem as Counter &&
                       f.Year == beginDateTimePicker.Value.Year  &&
                       f.Month >= beginDateTimePicker.Value.Month
                       select new CounterInformationR
                       {
                         Year = f.Year,
                         Month = months[f.Month],
                         Tarif1 = f.Tarif1,
                         Tarif2 = f.Tarif2,
                         Tarif3 = f.Tarif3,
                         Tarif4 = f.Tarif4
                       };
          var query3 = from f in DataBaseAccess.db.CounterStatements
                       where f.Counter == counterListBox.SelectedItem as Counter &&
                       f.Year == endDateTimePicker.Value.Year &&
                       f.Month <= endDateTimePicker.Value.Month
                       select new CounterInformationR
                       {
                         Year = f.Year,
                         Month = months[f.Month],
                         Tarif1 = f.Tarif1,
                         Tarif2 = f.Tarif2,
                         Tarif3 = f.Tarif3,
                         Tarif4 = f.Tarif4
                       };
           query = query1.Union(query2).Union(query3);

          foreach (var q in query)
          {
            dataTable.Rows.Add(new object[] { q.Year, q.Month, q.Tarif1, q.Tarif2, q.Tarif3, q.Tarif4 });
            tarif1Sum += q.Tarif1;
            tarif2Sum += q.Tarif2;
            tarif3Sum += q.Tarif3;
            tarif4Sum += q.Tarif4;
          }
        }
        else 
        {
           query = from f in DataBaseAccess.db.CounterStatements
                      where f.Counter == counterListBox.SelectedItem as Counter &&
                      f.Year == beginDateTimePicker.Value.Year && f.Month >= beginDateTimePicker.Value.Month
                      && f.Month <= endDateTimePicker.Value.Year
                      select new CounterInformationR
                      {
                        Year = f.Year,
                        Month = months[f.Month],
                        Tarif1 = f.Tarif1,
                        Tarif2 = f.Tarif2,
                        Tarif3 = f.Tarif3,
                        Tarif4 = f.Tarif4
                      };
          
          foreach (var q in query)
          {
            dataTable.Rows.Add(new object[] { q.Year, q.Month, q.Tarif1, q.Tarif2, q.Tarif3, q.Tarif4 });
            tarif1Sum += q.Tarif1;
            tarif2Sum += q.Tarif2;
            tarif3Sum += q.Tarif3;
            tarif4Sum += q.Tarif4;
          }
        }
        
        dataGridView1.DataSource = dataTable;
        dataGridView1.Columns["Расход электроэнергии 1 Тариф (кВт/час)"].Width = 150;
        dataGridView1.Columns["Расход электроэнергии 2 Тариф (кВт/час)"].Width = 150;
        dataGridView1.Columns["Расход электроэнергии 3 Тариф (кВт/час)"].Width = 150;
        dataGridView1.Columns["Расход электроэнергии 4 Тариф (кВт/час)"].Width = 150;

        tarif1TextBox.Text = tarif1Sum.ToString();
        tarif2TextBox.Text = tarif2Sum.ToString();
        tarif3TextBox.Text = tarif3Sum.ToString();
        tarif4TextBox.Text = tarif4Sum.ToString();

        sumTarifTextBox.Text = (tarif1Sum + tarif2Sum + tarif3Sum + tarif4Sum).ToString();
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

    private void dateCheckbox_CheckedChanged(object sender, EventArgs e)
    {
      if (dateCheckbox.Checked) DatePanel.Enabled = true;
      else DatePanel.Enabled = false;
    }

    private void CounterInformation_Load(object sender, EventArgs e)
    {
      var query = (from f in DataBaseAccess.db.ShkafStatements
                   select f.Shkaf).Distinct();
      shkafListBox.DataSource = query;
      if (shkafListBox.Items.Count > 0) shkafListBox.SelectedIndex = 0;
    }

    private void shkafListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      //counterListBox.Items.Clear();
      var query1 = from f in DataBaseAccess.db.Counters
                  where f.Shkaf == (Shkaf)shkafListBox.SelectedItem
                  select f;
      counterListBox.DataSource = query1;
      addressTextBox.Text = (shkafListBox.SelectedItem as Shkaf).Address;
      installerTextBox.Text = (shkafListBox.SelectedItem as Shkaf).Installer;
      installDateTextBox.Text = (shkafListBox.SelectedItem as Shkaf).InstallDate.ToShortDateString();

    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (dateCheckbox.Checked && (beginDateTimePicker.Value > DateTime.Now || endDateTimePicker.Value > DateTime.Now ||
        beginDateTimePicker.Value > endDateTimePicker.Value))
        MessageBox.Show("Поиск невозможен из за неправильных значений",
          "Ошибки ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      else if (counterListBox.SelectedIndex == -1)
        MessageBox.Show("Не выбран счетчик", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      else
      {
 

        decimal tarif1Sum = decimal.Zero;
        decimal tarif2Sum = decimal.Zero;
        decimal tarif3Sum = decimal.Zero;
        decimal tarif4Sum = decimal.Zero;

        foreach (var q in query)
        {
          tarif1Sum += q.Tarif1;
          tarif2Sum += q.Tarif2;
          tarif3Sum += q.Tarif3;
          tarif4Sum += q.Tarif4;
        }
        decimal sumTarif = tarif1Sum + tarif2Sum + tarif3Sum + tarif4Sum;
        var a = query.ToList();
        if (!CounterInformationReportForm.isOpened)
        {
          CounterInformationReportForm form = new CounterInformationReportForm(a, dateCheckbox.Checked, 
            beginDateTimePicker.Value.ToShortDateString(), endDateTimePicker.Value.ToShortDateString(),
            shkafListBox.SelectedItem as Shkaf, counterListBox.SelectedItem as Counter, sumTarif);
          form.Show();
        }
      }
    }
  }

  public class CounterInformationR
  {
    public int Year { get; set; }
    public string Month { get; set; }
    public decimal Tarif1 { get; set; }
    public decimal Tarif2 { get; set; }
    public decimal Tarif3 { get; set; }
    public decimal Tarif4 { get; set; }
  }
}
