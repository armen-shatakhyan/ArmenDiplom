using System.Collections.Generic;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ArmenDiplom
{
  public partial class PowerReportForm : Form
  {
    public static bool isOpened = false;
    public PowerReportForm(IEnumerable<BadPower> a, string beginDate, string endDate, bool isChecked)
    {
      InitializeComponent();
      isOpened = true;
      powerReport1.SetDataSource(a);
      if (isChecked)
      {
        ((TextObject)powerReport1.Section2.ReportObjects["beginDatelabel"]).Text = "Начальное Время: " + beginDate;
        ((TextObject)powerReport1.Section2.ReportObjects["endDatelabel"]).Text = "Конечное Время: " + endDate;
      }
      crystalReportViewer1.ReportSource = powerReport1;
    }

    private void PowerReportForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }
  }
}
