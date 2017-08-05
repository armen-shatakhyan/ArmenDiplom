using System.Collections.Generic;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ArmenDiplom
{
  public partial class BadAccessReportForm : Form
  {
    public static bool isOpened = false;
    public BadAccessReportForm(IEnumerable<BadAccessR> a, string beginDate, string endDate, bool isChecked)
    {
      InitializeComponent();
      isOpened = true;
      badAccessReport1.SetDataSource(a);
      if (isChecked)
      {
        ((TextObject)badAccessReport1.Section2.ReportObjects["beginDateLabel"]).Text = "Начальное время: " + beginDate;
        ((TextObject)badAccessReport1.Section2.ReportObjects["endDateLabel"]).Text = "Конечное время: " + endDate;
      }
      crystalReportViewer1.ReportSource = badAccessReport1; 
    }

    private void BadAccessReportForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }
  }
}
