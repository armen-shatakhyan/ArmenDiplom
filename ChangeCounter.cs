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
  public partial class ChangeCounter : Form
  {
    public static bool isOpened = false;
    public ChangeCounter()
    {
      InitializeComponent();
      isOpened = true;
      if (DataBaseAccess.db.Counters.Count() > 0)
      {
        listBox1.Items.AddRange(DataBaseAccess.db.Counters.ToArray());
      }
      if (DataBaseAccess.db.Shkafs.Count() > 0)
      {
        shkafComboBox.Items.AddRange(DataBaseAccess.db.Shkafs.ToArray());
      }
      listBox1.SelectedIndex = 0;
      //listBox1.DataSource = DataBaseAccess.db.Counters;
      //shkafComboBox.DataSource = DataBaseAccess.db.Shkafs;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox1.SelectedIndex != -1)
      {
        Counter counter = (Counter)listBox1.SelectedItem;
        counterNumberTextBox.Text = counter.CounterID.ToString();
        shkafComboBox.Text = counter.Shkaf.ShkafID.ToString();
        ownerNameTextBox.Text = counter.CounterOwner;
        telNumberTextBox.Text = counter.TelephoneOwner;
        installCounterDateTimePicker.Value = (DateTime)counter.InstallDate;
        poverkaCounterDateTimePicker.Value = (DateTime)counter.PoverkaDate;
        isNonPayntedComboBox.Text = counter.IsNonPaynted ? "Да" : "Нет";
        currentDayEnergyTextBox.Text = counter.CurrentMonthDayEnergy.ToString();
        currentNightEnergyTextBox.Text = counter.CurrentMonthNightEnergy.ToString();
        pastDayEnergyTextBox.Text = counter.PastMonthDayEnergy.ToString();
        pastNightEnergyTextBox.Text = counter.PastMonthNightEnergy.ToString();

      }
    }

    private void counterNumberTextBox_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (counterNumberTextBox.Text.Trim().Length != 8)
        {
          throw new Exception();
        }
        else if (counterNumberTextBox.Text.Trim()[0] == '0')
        {
          errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
          errorNewShkaf.SetError((Control)sender, "Первое цифра не должна быть нулевым");
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

    private void ownerNameTextBox_Validating(object sender, CancelEventArgs e)
    {
      if (ownerNameTextBox.Text.Trim().Length < 3)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Укажите правильное имя хозяина");
      }
      else errorNewShkaf.SetError((Control)sender, "");
    }

    private void telNumberTextBox_Validating(object sender, CancelEventArgs e)
    {
      if (telNumberTextBox.Text.Trim().Length < 3)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Укажите правильный номер телефона");
      }
      else errorNewShkaf.SetError((Control)sender, "");
    }

    private void installCounterDateTimePicker_Validating(object sender, CancelEventArgs e)
    {
      if (installCounterDateTimePicker.Value > DateTime.Now)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Дата должна быть меньше сегодняшнего дня");
      }
      else
      {
        errorNewShkaf.SetError((Control)sender, "");
      }
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

    private void currentDayEnergyTextBox_Validating(object sender, CancelEventArgs e)
    {
      if (currentDayEnergyTextBox.Text.Trim().Length < 3)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Укажите правильный расход енергии");
      }
      else errorNewShkaf.SetError((Control)sender, "");
    }

    private void currentNightEnergyTextBox_Validating(object sender, CancelEventArgs e)
    {
      if (currentNightEnergyTextBox.Text.Trim().Length < 3)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Укажите правильный расход енергии");
      }
      else errorNewShkaf.SetError((Control)sender, "");
    }

    private void pastDayEnergyTextBox_Validating(object sender, CancelEventArgs e)
    {
      if (pastDayEnergyTextBox.Text.Trim().Length < 3)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Укажите правильный расход енергии");
      }
      else errorNewShkaf.SetError((Control)sender, "");
    }

    private void pastNightEnergyTextBox_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (pastNightEnergyTextBox.Text.Trim() != " - - ") int.Parse(pastNightEnergyTextBox.Text);
        if (pastNightEnergyTextBox.Text.Trim().Length < 3)
        {
          throw new Exception();
        }
        else errorNewShkaf.SetError((Control)sender, "");
      }

      catch (Exception)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Введите правильное число");
      }
    }

    public bool IsValidForm()
    {
      if (counterNumberTextBox.Text.Trim().Length != 8 ||
          counterNumberTextBox.Text.Trim()[0] == '0' ||
          installCounterDateTimePicker.Value > DateTime.Now ||
          poverkaCounterDateTimePicker.Value > DateTime.Now ||
          ownerNameTextBox.Text.Trim().Length < 3 ||
          telNumberTextBox.Text.Trim().Length < 3 ||
          shkafComboBox.Text == "")
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

    private void saveButton_Click(object sender, EventArgs e)
    {
      if (!IsValidForm())
      {
        MessageBox.Show("Корректировка счетчика невозможно из-за неправильных входных значений", 
          "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      DialogResult result = MessageBox.Show("Вы действительно хотите изменить параметры счетчика номер " + 
        counterNumberTextBox.Text.Trim() + "?", "Указание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (result == DialogResult.No) return;
      else
      {
        Counter counter = new Counter
        {
          CounterID = int.Parse(counterNumberTextBox.Text.Trim()),
          Shkaf = (Shkaf) shkafComboBox.SelectedItem,
          CounterOwner = ownerNameTextBox.Text.Trim(),
          TelephoneOwner = telNumberTextBox.Text.Trim(),
          InstallDate = installCounterDateTimePicker.Value,
          PoverkaDate = poverkaCounterDateTimePicker.Value
        };
        DataBaseAccess.UpdateCounter(counter);

        MessageBox.Show("Изменения счетчика номер: " + counter.CounterID.ToString() + "приняты!",
          "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        listBox1.Items.Clear();
        listBox1.Items.AddRange(DataBaseAccess.db.Counters.ToArray());
      }
    }

    private void ChangeCounter_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }
  }
}
