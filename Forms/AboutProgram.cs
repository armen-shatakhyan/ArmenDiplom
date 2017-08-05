using System;
using System.Windows.Forms;

namespace ArmenDiplom
{
  public partial class AboutProgram : Form
  {
    public static bool isOpened = false;
    public AboutProgram()
    {
      InitializeComponent();
      isOpened = true;
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void AboutProgram_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }
  }
}
