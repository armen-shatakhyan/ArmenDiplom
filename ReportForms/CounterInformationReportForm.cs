using System.Collections.Generic;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ArmenDiplom
{
  public partial class CounterInformationReportForm : Form
  {
    public static bool isOpened = false;
    public CounterInformationReportForm(IEnumerable<CounterInformationR> a, bool isChecked, 
      string beginDate, string endDate, Shkaf shkaf, Counter counter, decimal sumTarif)
    {
      InitializeComponent();
      isOpened = true;
      counterInformationReport1.SetDataSource(a);
      ((TextObject)counterInformationReport1.Section2.ReportObjects["shkafNumberText"]).Text = shkaf.ShkafID.ToString();
      ((TextObject)counterInformationReport1.Section2.ReportObjects["shkafAddressText"]).Text = shkaf.Address;
      ((TextObject)counterInformationReport1.Section2.ReportObjects["counterNumberText"]).Text = counter.CounterID.ToString();
      ((TextObject)counterInformationReport1.Section2.ReportObjects["poverkaDateText"]).Text = counter.InstallDate.ToShortDateString();
      ((TextObject)counterInformationReport1.Section2.ReportObjects["ownerNameText"]).Text = counter.CounterOwner;
      ((TextObject)counterInformationReport1.Section2.ReportObjects["telephoneText"]).Text = counter.TelephoneOwner;
      ((TextObject)counterInformationReport1.Section4.ReportObjects["sumText"]).Text = sumTarif.ToString();
      if (isChecked)
      {
        ((TextObject)counterInformationReport1.Section2.ReportObjects["beginDateLabel"]).Text = "Начальное время: " + beginDate;
        ((TextObject)counterInformationReport1.Section2.ReportObjects["endDateLabel"]).Text = "Конечное время: " + endDate;
      }
      crystalReportViewer1.ReportSource = counterInformationReport1;
    }

    private void CounterInformationReportForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }
  }
}
