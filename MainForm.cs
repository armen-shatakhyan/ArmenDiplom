using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ArmenDiplom
{
  public partial class MainForm : Form
  {
    
    public MainForm()
    {
      InitializeComponent();
      //DataBaseAccess.SomeMethod();
    }

    private void zagruzkaMenuItem_Click(object sender, EventArgs e)
    {
      openFileDialog1.ShowDialog();
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

    private void MainForm_Load(object sender, EventArgs e)
    {
      
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

    private void obshieMenuItem_Click(object sender, EventArgs e)
    {
      if (!Options.isOpened)
      {
        Options options = new Options();
        options.MdiParent = this;
        options.Show();
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
  }
}