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
  public partial class DeleteCounter : Form
  {
    public static bool isOpened = false;

    public DeleteCounter()
    {
      InitializeComponent();
      isOpened = true;
      if (DataBaseAccess.db.Counters.Count() > 0)
      {
        foreach (Counter counter in DataBaseAccess.db.Counters)
        {
          checkedListBox1.Items.Add(counter);
        }
        checkedListBox1.Sorted = true;
        checkedListBox1.SelectedIndex = 0;
      }
    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (checkedListBox1.SelectedIndex != -1)
      {
        Counter counter = (Counter)checkedListBox1.SelectedItem;
        counterNumberTextBox.Text = counter.CounterID.ToString();
        shkafNumberTextBox.Text = counter.Shkaf.ShkafID.ToString();
        installDateTextBox.Text = DateTime.Parse(counter.InstallDate.ToString()).ToShortDateString();
        poverkaDateTextBox.Text = DateTime.Parse(counter.PoverkaDate.ToString()).ToShortDateString();
        telNumberTextBox.Text = counter.TelephoneOwner;
        ownerNameTextBox.Text = counter.CounterOwner;
        isNonPayntedTextBox.Text = counter.IsNonPaynted ? "Да" : "Нет";
        currentDayEnergyTextBox.Text = counter.CurrentMonthDayEnergy.ToString();
        currentNightEnergyTextBox.Text =counter.CurrentMonthNightEnergy.ToString();
        pastDayEnergyTextBox.Text = counter.PastMonthDayEnergy.ToString();
        pastNightEnergyTextBox.Text = counter.PastMonthNightEnergy.ToString();
      }
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
      if (checkedListBox1.CheckedItems.Count == 0)
      {
        MessageBox.Show("Не выбрано ни одного счетчика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      DialogResult result = MessageBox.Show("Вы действительно хотите удалить указанные счетчики?", "Указание",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.No) return;
      else
      {
        foreach (Counter counter in checkedListBox1.CheckedItems)
        {
          DataBaseAccess.DeleteCounter(counter);
        }
        MessageBox.Show("Отмеченные счетчики удалены!", "Подтверждение",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearForm();
      }
    }

    public void ClearForm()
    {
      counterNumberTextBox.Clear();
      shkafNumberTextBox.Clear();
      installDateTextBox.Clear();
      poverkaDateTextBox.Clear();
      telNumberTextBox.Clear();
      ownerNameTextBox.Clear();
      isNonPayntedTextBox.Clear();
      currentDayEnergyTextBox.Clear();
      currentNightEnergyTextBox.Clear();
      pastDayEnergyTextBox.Clear();
      pastNightEnergyTextBox.Clear();
      checkedListBox1.Items.Clear();
      foreach (Counter counter in DataBaseAccess.db.Counters)
      {
        checkedListBox1.Items.Add(counter);
        checkedListBox1.Sorted = true;
      }
    }

    private void DeleteCounter_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }
  }
}
