using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ArmenDiplom
{
  public partial class NoInformation : Form
  {
    public static bool isOpened = false;
    public NoInformation()
    {
      InitializeComponent();
      isOpened = true;
    }

    private void NoInformation_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var subquery = from f in DataBaseAccess.db.ShkafStatements
                  where f.Month == (currentRadioButton.Checked? DateTime.Now.Month : DateTime.Now.AddMonths(-1).Month)
                  && f.Year == (currentRadioButton.Checked ? DateTime.Now.Year : DateTime.Now.AddMonths(-1).Year)
                  select f.Shkaf;
      List<Shkaf> shkafs = DataBaseAccess.db.ShkafStatements.Select(f => f.Shkaf).Distinct().ToList();

      foreach (var subq in subquery)
      {
        shkafs.Remove(subq);
      }

      var query = (from f in shkafs
                   select new { f.ShkafID, f.Address }).Distinct();


      DataTable dataTable = new DataTable();

      dataTable.Columns.Add("Номер Модуля", typeof(int));
      dataTable.Columns.Add("Адрес", typeof(string));

      foreach (var q in query)
      {
        dataTable.Rows.Add(new object[] { q.ShkafID, q.Address });
      }
      dataGridView1.DataSource = dataTable;
      dataGridView1.Columns["Адрес"].Width = 300;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      var subquery = from f in DataBaseAccess.db.ShkafStatements
                     where f.Month == (currentRadioButton.Checked ? DateTime.Now.Month : DateTime.Now.AddMonths(-1).Month)
                     && f.Year == (currentRadioButton.Checked ? DateTime.Now.Year : DateTime.Now.AddMonths(-1).Year)
                     select f.Shkaf;
      List<Shkaf> shkafs = DataBaseAccess.db.ShkafStatements.Select(f => f.Shkaf).Distinct().ToList();

      foreach (var subq in subquery)
      {
        shkafs.Remove(subq);
      }

      var query = (from f in shkafs
                   select new NoInformationR { ShkafID = f.ShkafID, Address = f.Address }).Distinct();

      var a = query.ToList();

      if (!NoInformationReportForm.isOpened)
      {
        NoInformationReportForm noInformation = new NoInformationReportForm(a, currentRadioButton.Checked);
        noInformation.Show();
      }
    }
  }
  public class NoInformationR
  {
    public int ShkafID { get; set; }
    public string Address { get; set; }
  }
}
