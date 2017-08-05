using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ArmenDiplom
{
  public partial class NoInformationReportForm : Form
  {
    public static bool isOpened = false;
    public NoInformationReportForm(IEnumerable<NoInformationR> a, bool isCurrent)
    {
      InitializeComponent();
      isOpened = true;
      noInformationReport1.SetDataSource(a);
      ((TextObject)noInformationReport1.Section2.ReportObjects["monthLabel"]).Text = 
        isCurrent ? "за текущий месяц" : "за прошлый месяц";
      crystalReportViewer1.ReportSource = noInformationReport1;
    }

    private void NoInformationReportForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }
  }
}
