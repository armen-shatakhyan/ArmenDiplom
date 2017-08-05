using System.Collections.Generic;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ArmenDiplom
{
  public partial class PoverkaCounterReportForm : Form
  {
    public static bool isOpened = false;
    public PoverkaCounterReportForm(IEnumerable<PoverkaCounterR> a, bool isPassedData)
    {
      InitializeComponent();
      isOpened = true;
      poverkaCounterReport1.SetDataSource(a);
      ((TextObject)poverkaCounterReport1.Section2.ReportObjects["labelText"]).Text =
        isPassedData ? "Список  Счетчиков  С  Истекщим  Сроком  Поверки" : 
        "Список  Счетчиков  И  Даты  Истечения  Поверки";
      crystalReportViewer1.ReportSource = poverkaCounterReport1;
    }

    private void PoverkaCounterReportForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }
  }
}
