using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace ArmenDiplom
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      bool createdNew;
      Mutex mutex = new Mutex(false, "Amok", out createdNew);
      if (!createdNew)
      {
        MessageBox.Show("Zapuskat");
        Application.Exit();
        return;
      }
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }
}
