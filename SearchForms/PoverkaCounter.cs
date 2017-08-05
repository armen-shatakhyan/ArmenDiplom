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
  public partial class PoverkaCounter : Form
  {
    public static bool isOpened = false;
    public PoverkaCounter()
    {
      InitializeComponent();
      isOpened = true;
    }

    private void PoverkaCounter_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (passedCounterRadioButton.Checked)
      {
        var query = from f in DataBaseAccess.db.Counters
                    where f.PoverkaDate.AddYears(5) < DateTime.Now
                    select new
                    {
                      f.CounterID,
                      f.CounterOwner,
                      f.TelephoneOwner,
                      f.InstallDate,
                      f.PoverkaDate,
                      PassedDate = f.PoverkaDate.AddYears(5),
                      f.Shkaf.ShkafID,
                      f.Shkaf.Address
                    };
        DataTable dataTable = new DataTable();
        dataTable.Columns.Add("Номер счетчика", typeof(int));
        dataTable.Columns.Add("Имя хозяина", typeof(string));
        dataTable.Columns.Add("Номер телефона абонента", typeof(string));
        dataTable.Columns.Add("Дата установки", typeof(DateTime));
        dataTable.Columns.Add("Дата последней поверки", typeof(DateTime));
        dataTable.Columns.Add("Дата истечения срока поверки", typeof(DateTime));
        dataTable.Columns.Add("Номер модуля", typeof(int));
        dataTable.Columns.Add("Адрес модуля", typeof(string));

        foreach (var q in query)
        {
          dataTable.Rows.Add(new object[] { q.CounterID, q.CounterOwner.Trim(), q.TelephoneOwner.Trim(), 
            q.InstallDate.Date, q.PoverkaDate.Date, q.PassedDate.Date, q.ShkafID, q.Address.Trim()});
        }

        dataGridView1.DataSource = dataTable;
        dataGridView1.Columns["Имя хозяина"].Width = 150;
        dataGridView1.Columns["Номер телефона абонента"].Width = 150;
        dataGridView1.Columns["Адрес модуля"].Width = 200;

      }
      else
      {
        var query = from f in DataBaseAccess.db.Counters
                    //where f.PoverkaDate.AddYears(5) < DateTime.Now
                    select new
                    {
                      f.CounterID,
                      f.CounterOwner,
                      f.TelephoneOwner,
                      f.InstallDate,
                      f.PoverkaDate,
                      PassedDate = f.PoverkaDate.AddYears(5),
                      f.Shkaf.ShkafID,
                      f.Shkaf.Address
                    };
        DataTable dataTable = new DataTable();
        dataTable.Columns.Add("Номер счетчика", typeof(int));
        dataTable.Columns.Add("Имя хозяина", typeof(string));
        dataTable.Columns.Add("Номер телефона абонента", typeof(string));
        dataTable.Columns.Add("Дата установки", typeof(DateTime));
        dataTable.Columns.Add("Дата последней поверки", typeof(DateTime));
        dataTable.Columns.Add("Дата истечения срока поверки", typeof(DateTime));
        dataTable.Columns.Add("Номер модуля", typeof(int));
        dataTable.Columns.Add("Адрес модуля", typeof(string));

        foreach (var q in query)
        {
          dataTable.Rows.Add(new object[] { q.CounterID, q.CounterOwner.Trim(), q.TelephoneOwner.Trim(), 
            q.InstallDate.Date, q.PoverkaDate.Date, q.PassedDate.Date, q.ShkafID, q.Address.Trim()});
        }

        dataGridView1.DataSource = dataTable;
        dataGridView1.Columns["Имя хозяина"].Width = 150;
        dataGridView1.Columns["Номер телефона абонента"].Width = 150;
        dataGridView1.Columns["Адрес модуля"].Width = 200;

        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
          if (DateTime.Parse(row.Cells[5].Value.ToString()) < DateTime.Now)
            row.Cells[5].Style.ForeColor = Color.Red;
          else if (DateTime.Parse(row.Cells[5].Value.ToString()) < DateTime.Now.AddMonths(2))
            row.Cells[5].Style.ForeColor = Color.Brown;
          else row.Cells[5].Style.ForeColor = Color.Black;
        }
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      List<PoverkaCounterR> a = new List<PoverkaCounterR>();
      if (passedCounterRadioButton.Checked)
      {
        var query = from f in DataBaseAccess.db.Counters
                    where f.PoverkaDate.AddYears(5) < DateTime.Now
                    select new PoverkaCounterR
                    {
                      CounterID = f.CounterID,
                      CounterOwner = f.CounterOwner,
                      TelephoneOwner = f.TelephoneOwner,
                      InstallDate = f.InstallDate.Date,
                      PoverkaDate = f.PoverkaDate.Date,
                      PassedDate = f.PoverkaDate.AddYears(5).Date,
                      ShkafID = f.Shkaf.ShkafID,
                      Address = f.Shkaf.Address
                    };
        a = query.ToList();
      }
      else
      {
        var query = from f in DataBaseAccess.db.Counters
                    //where f.PoverkaDate.AddYears(5) < DateTime.Now
                    select new PoverkaCounterR
                    {
                      CounterID = f.CounterID,
                      CounterOwner = f.CounterOwner,
                      TelephoneOwner = f.TelephoneOwner,
                      InstallDate = f.InstallDate.Date,
                      PoverkaDate = f.PoverkaDate.Date,
                      PassedDate = f.PoverkaDate.AddYears(5).Date,
                      ShkafID = f.Shkaf.ShkafID,
                      Address = f.Shkaf.Address
                    };
        a = query.ToList();
      }
      if (!PoverkaCounterReportForm.isOpened)
      {
        PoverkaCounterReportForm form = new PoverkaCounterReportForm(a, passedCounterRadioButton.Checked);
        form.Show();
      }
    }

    private void countersListRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      if (((RadioButton)sender).Text == "список счетчиков и даты истечения поверки")
        label1.Visible = true;
      else label1.Visible = false;
    }

    private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (!passedCounterRadioButton.Checked)
      {
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
          if (DateTime.Parse(row.Cells[5].Value.ToString()) < DateTime.Now)
            row.Cells[5].Style.ForeColor = Color.Red;
          else if (DateTime.Parse(row.Cells[5].Value.ToString()) < DateTime.Now.AddMonths(2))
            row.Cells[5].Style.ForeColor = Color.Brown;
          else row.Cells[5].Style.ForeColor = Color.Black;
        }
      }
    }

  }

  public class PoverkaCounterR
  {
    public int CounterID { get; set; }
    public string CounterOwner { get; set; }
    public string TelephoneOwner { get; set; }
    public DateTime InstallDate { get; set; }
    public DateTime PoverkaDate { get; set; }
    public DateTime PassedDate { get; set; }
    public int ShkafID { get; set; }
    public string Address { get; set; }
  }
}
