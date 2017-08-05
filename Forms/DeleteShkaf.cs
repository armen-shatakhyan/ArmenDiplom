using System;
using System.Windows.Forms;

namespace ArmenDiplom
{
  public partial class DeleteShkaf : Form
  {
    public static bool isOpened = false;

    public DeleteShkaf()
    {
      InitializeComponent();
      isOpened = true;
    }

    private void DeleteShkaf_Load(object sender, EventArgs e)
    {
      foreach (Shkaf shkaf in DataBaseAccess.db.Shkafs)
      checkedListBox1.Items.Add(shkaf);
      if (checkedListBox1.Items.Count > 0)
      {
        checkedListBox1.SelectedIndex = 0;
        checkedListBox1.Sorted = true;
      }
    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (checkedListBox1.SelectedIndex != -1)
      {
        Shkaf shkaf = (Shkaf)checkedListBox1.SelectedItem;
        shkafNumberTextBox.Text = shkaf.ShkafID.ToString();
        installDateTextBox.Text = DateTime.Parse(shkaf.InstallDate.ToString()).ToShortDateString();
        poverkaDateTextBox.Text = DateTime.Parse(shkaf.PoverkaDate.ToString()).ToShortDateString();
        //password1TextBox.Text = shkaf.Password1.ToString();
        //password2TextBox.Text = shkaf.Password2.ToString();
        //password3TextBox.Text = shkaf.Password3.ToString();
        installerTextBox.Text = shkaf.Installer.ToString();
        addressTextBox.Text = shkaf.Address.ToString();
        countersTextBox.Text = shkaf.Counters.Count.ToString();
        maxCountersTextBox.Text = shkaf.CountersQuantity.ToString();
        //unAuthorizedTextBox.Text = shkaf.IsUnauthorizedAccess ? "Да" : "Нет";
        is5YearPoverkaTextBox.Text = shkaf.PoverkaDate.AddYears(5) < DateTime.Now ? "Да" : "Нет";
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (checkedListBox1.CheckedItems.Count == 0)
      {
        MessageBox.Show("Не выбрано ни одного модуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      DialogResult result = MessageBox.Show("Вы действительно хотите удалить указанные модули?", "Указание",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.No) return;
      else
      {
       
        foreach (Shkaf shkaf in checkedListBox1.CheckedItems)
        {
          DataBaseAccess.DeleteShkaf(shkaf);
        }
        if (checkedListBox1.CheckedItems.Count > 1) MessageBox.Show("Отмеченные модули удалены!", "Подтверждение!",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
        else MessageBox.Show("Отмеченный модуль удален!", "Подтверждение!",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearForm();
      }
    }

    public void ClearForm()
    {
      //password1TextBox.Clear();
      //password2TextBox.Clear();
      //password3TextBox.Clear();
      shkafNumberTextBox.Clear();
      addressTextBox.Clear();
      installerTextBox.Clear();
      poverkaDateTextBox.Clear();
      installDateTextBox.Clear();
      countersTextBox.Clear();
      //unAuthorizedTextBox.Clear();
      is5YearPoverkaTextBox.Clear();
      checkedListBox1.Items.Clear();
      foreach (Shkaf shkaf in DataBaseAccess.db.Shkafs)
      {
        checkedListBox1.Items.Add(shkaf);
        checkedListBox1.Sorted = true;
      }
    }

    private void DeleteShkaf_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }
  }
}