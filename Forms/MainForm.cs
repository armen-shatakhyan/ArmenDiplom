using System;
using System.Windows.Forms;
using System.IO;

namespace ArmenDiplom
{
  public partial class MainForm : Form
  {
    public static string folder = Environment.CurrentDirectory;
    public MainForm()
    {
      InitializeComponent();
      notifyIcon1.Icon = Properties.Resources.RCArrow_16x161;
    }

    private void newShkafMenuItem_Click(object sender, EventArgs e)
    {
      if (!NewShkaf.isOpened)
      {
        NewShkaf newShkaf = new NewShkaf();
        newShkaf.MdiParent = this;
        newShkaf.Show();
      }
    }

    private void deleteShkafMenuItem_Click(object sender, EventArgs e)
    {
      if (!DeleteShkaf.isOpened)
      {
        DeleteShkaf deleteShkaf = new DeleteShkaf();
        deleteShkaf.MdiParent = this;
        deleteShkaf.Show();
      }
    }

    private void updateShkafMenuItem_Click(object sender, EventArgs e)
    {
      if (!ChangeShkaf.isOpened)
      {
        ChangeShkaf changeShkaf = new ChangeShkaf();
        changeShkaf.MdiParent = this;
        changeShkaf.Show();
      }
    }

    private void newCounterMenuItem_Click(object sender, EventArgs e)
    {
      if (!NewCounter.isOpened)
      {
        NewCounter newCounter = new NewCounter();
        newCounter.MdiParent = this;
        newCounter.Show();
      }
    }

    private void deleteCounterMenuItem_Click(object sender, EventArgs e)
    {
      if (!DeleteCounter.isOpened)
      {
        DeleteCounter deleteCounter = new DeleteCounter();
        deleteCounter.MdiParent = this;
        deleteCounter.Show();
      }
    }

    private void changeCounterMenuItem_Click(object sender, EventArgs e)
    {
      if (!ChangeCounter.isOpened)
      {
        ChangeCounter changeCounter = new ChangeCounter();
        changeCounter.MdiParent = this;
        changeCounter.Show();
      }
    }

    private void aboutMenuItem_Click(object sender, EventArgs e)
    {
      if (!AboutProgram.isOpened)
      {
        AboutProgram aboutProgram = new AboutProgram();
        aboutProgram.MdiParent = this;
        aboutProgram.Show();
      }
    }

    private void documentationMenuItem_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("Documentation.doc");
    }

    private void fileInsertMenuItem_Click(object sender, EventArgs e)
    {
      openFileDialog1.Multiselect = true;
      openFileDialog1.Filter = "Binary files (*.bi)|*.bi";
      openFileDialog1.Title = "Select Binary File(s)";
      DialogResult result = openFileDialog1.ShowDialog();

      if (result == DialogResult.OK)
      {
        string errMessage = "";
        string infoMessage = "";

        foreach (string fullName in openFileDialog1.FileNames)
        {
          try
          {
            string shkafName = Path.GetFileNameWithoutExtension(fullName);
            DataBaseAccess.CheckFile(fullName, shkafName, ref errMessage, ref infoMessage);
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message);
          }
        }

        string logPath = Path.Combine(folder, "log.txt");
        FileStream fs = new FileStream(logPath, FileMode.Append, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);

        sw.WriteLine("**************** Дата и время записи: " + DateTime.Now.ToString() + " ***************");
        sw.WriteLine();

        if (errMessage.Trim().Length > 0)
        {
          sw.WriteLine("                               Ошибки !!!                                ");
          sw.WriteLine();
          sw.WriteLine(errMessage);
          sw.WriteLine();
        }
        else
        {
          sw.WriteLine();
          sw.WriteLine("\t\tВсе данные успешно загружены в базу");
          sw.WriteLine();
        }

        if (infoMessage.Trim().Length > 0)
        {
          sw.WriteLine("                               Предупреждения !!!                                ");
          sw.WriteLine();
          sw.WriteLine(infoMessage);
          sw.WriteLine();
        }
        sw.WriteLine("*******************  Конец записи  **********************");
        sw.WriteLine();
        sw.WriteLine();
        sw.WriteLine();
        sw.Close();
        fs.Close();

        if (errMessage.Trim().Length > 0) MessageBox.Show(errMessage + " записи ошибок занесены в log.txt файл",
          "Обнаруженные ошибки!", MessageBoxButtons.OK, MessageBoxIcon.Error);


        if (infoMessage.Trim().Length > 0) MessageBox.Show(infoMessage + " записи предупреждений занесены в log.txt файл",
          "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        if (errMessage.Trim().Length == 0) MessageBox.Show("Все данные успешно загружены в базу",
          "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void accessInsertMenuItem_Click(object sender, EventArgs e)
    {
      if (!InputBadAccess.isOpened)
      {
        InputBadAccess inputBadAccess = new InputBadAccess();
        inputBadAccess.MdiParent = this;
        inputBadAccess.Show();
      }
    }

    private void powerSearchMenuItem_Click(object sender, EventArgs e)
    {
      if (!PowerSearch.isOpened)
      {
        PowerSearch powerSearch = new PowerSearch();
        powerSearch.MdiParent = this;
        powerSearch.Show();
      }
    }

    private void accessSearchMenuItem_Click(object sender, EventArgs e)
    {
      if (!BadAccess.isOpened)
      {
        BadAccess badAccess = new BadAccess();
        badAccess.MdiParent = this;
        badAccess.Show();
      }
    }

    private void informationSearchMenuItem_Click(object sender, EventArgs e)
    {
      if (!NoInformation.isOpened)
      {
        NoInformation noInformation = new NoInformation();
        noInformation.MdiParent = this;
        noInformation.Show();
      }
    }

    private void countersSearchMenuItem_Click(object sender, EventArgs e)
    {
      if (!PoverkaCounter.isOpened)
      {
        PoverkaCounter poverkaCounter = new PoverkaCounter();
        poverkaCounter.MdiParent = this;
        poverkaCounter.Show();
      }
    }

    private void counterInformationMenuItem_Click(object sender, EventArgs e)
    {
      if (!CounterInformation.isOpened)
      {
        CounterInformation counterInformation = new CounterInformation();
        counterInformation.MdiParent = this;
        counterInformation.Show();
      }
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      // Show the form when the user double clicks on the notify icon.

      // Set the WindowState to normal if the form is minimized.
      if (this.WindowState == FormWindowState.Minimized)
      {
        this.Show();
        this.Activate();
      }
      
        this.WindowState = FormWindowState.Normal;

      // Activate the form.

      
    }

    private void MainForm_SizeChanged(object sender, EventArgs e)
    {
      if (this.WindowState == FormWindowState.Minimized)
      {
        this.Hide();
      }
    }
  }

  public partial class Shkaf
  {
    public override string ToString()
    {
      return ShkafID.ToString();
    }
  }

  public partial class Counter
  {
    public override string ToString()
    {
      return CounterID.ToString();
    }
  }
}