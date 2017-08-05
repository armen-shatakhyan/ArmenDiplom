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
  public partial class CReport : Form
  {
    public CReport(IQueryable shkafs)
    {
      InitializeComponent();
      CrystalReport11.SetDataSource(shkafs);
      //CrystalReport11.SetDataSource(DataBaseAccess.db.Shkafs);
    }

    private void CReport_Load(object sender, EventArgs e)
    {

    }
  }
}
