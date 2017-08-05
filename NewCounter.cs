using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Linq;

namespace ArmenDiplom
{
  public partial class NewCounter : Form
  {
    public static bool isOpened = false;

    public NewCounter()
    {
      InitializeComponent();
      isOpened = true;
    }

    private void counterNumberTextBox_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (counterNumberTextBox.Text.Trim().Length != 8)
        {
          throw new Exception();
        }
        Convert.ToInt32(counterNumberTextBox.Text.Trim());
        errorNewShkaf.SetError((Control)sender, "");
      }
      catch (Exception)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Значение должно быть 8-и значное число");
      }
    }

    private void NewCounter_Load(object sender, EventArgs e)
    {
      //if (DataBaseAccess.db.Shkafs > 0)
      //{
        shkafNumberComboBox.Items.Clear();
        foreach (Shkaf shkaf in DataBaseAccess.db.Shkafs)
        {
          shkafNumberComboBox.Items.Add(shkaf);
        }
      //}
    }

    private void installDateTimePicker_Validating(object sender, CancelEventArgs e)
    {
      if (installDateTimePicker.Value > DateTime.Now)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Дата должна быть меньше сегодняшнего дня");
      }
      else
      {
        errorNewShkaf.SetError((Control)sender, "");
      }
    }

    private void telNumberTextBox_Validating(object sender, CancelEventArgs e)
    {
      if (telNumberTextBox.Text.Trim().Length < 3)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Укажите правильное имя аддресса");
      }
      else errorNewShkaf.SetError((Control)sender, "");
    }

    private void poverkaCounterDateTimePicker_Validating(object sender, CancelEventArgs e)
    {
      if (poverkaCounterDateTimePicker.Value > DateTime.Now)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Дата должна быть меньше сегодняшнего дня");
      }
      else
      {
        errorNewShkaf.SetError((Control)sender, "");
      }
    }

    private void shkafNumberComboBox_Validating(object sender, CancelEventArgs e)
    {
      if (shkafNumberComboBox.Text == "")
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Вы должны выбирать номер шкафа");
      }
      else
      {
        errorNewShkaf.SetError((Control)sender, "");
      }
    }

    public void ClearForm()
    {
      counterNumberTextBox.Clear();
      shkafNumberComboBox.Text = "";
      ownerNameTextBox.Clear();
      telNumberTextBox.Clear();
      poverkaCounterDateTimePicker.Value = DateTime.Now;
      installDateTimePicker.Value = DateTime.Now;
    }

    public bool IsValidForm()
    {
      if (counterNumberTextBox.Text.Trim().Length != 8 ||
          counterNumberTextBox.Text.Trim()[0] == '0' ||
          installDateTimePicker.Value > DateTime.Now ||
          poverkaCounterDateTimePicker.Value > DateTime.Now ||
          ownerNameTextBox.Text.Trim().Length < 3 ||
          telNumberTextBox.Text.Trim().Length < 3 ||
          shkafNumberComboBox.Text == "")
        return false;
      try
      {
        int.Parse(counterNumberTextBox.Text.Trim());
      }
      catch
      {
        return false;
      }
      return true;
    }

    private void createButton_Click(object sender, EventArgs e)
    {
      if (!IsValidForm())
      {
        MessageBox.Show("Создание нового счетчика невозможно из-за неправильных входных значений",
          "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      DialogResult result = MessageBox.Show("Вы действительно хотите создать новый счетчик?", "Указание",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.No) return;
      else
      {
        var query = (from c in DataBaseAccess.db.Counters
                     where c.CounterID == int.Parse(counterNumberTextBox.Text.Trim())
                     select c).ToList();
        if (query.Count > 0)
        {
          MessageBox.Show("Счетчик с номером " + counterNumberTextBox.Text.Trim() +
          " уже существует.\n Задайте шкафу другой номер", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Stop);
          return;
        }

        Counter counter = new Counter
        {
          CounterID = int.Parse(counterNumberTextBox.Text.Trim()),
          InstallDate = installDateTimePicker.Value,
          PoverkaDate = poverkaCounterDateTimePicker.Value,
          CounterOwner = ownerNameTextBox.Text.Trim(),
          TelephoneOwner = telNumberTextBox.Text.Trim(),
          Shkaf = (Shkaf)shkafNumberComboBox.SelectedItem
        };

        DataBaseAccess.NewCounter(counter);
        ClearForm();
      }
    }

    private void ownerNameTextBox_Validating(object sender, CancelEventArgs e)
    {
      if (telNumberTextBox.Text.Trim().Length < 3)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Укажите правильное имя абонента");
      }
      else errorNewShkaf.SetError((Control)sender, "");
    }

    private void NewCounter_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }


  }
}