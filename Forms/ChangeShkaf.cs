using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ArmenDiplom
{
  public partial class ChangeShkaf : Form
  {
    public static bool isOpened = false;

    public ChangeShkaf()
    {
      InitializeComponent();
      isOpened = true;

      foreach (Shkaf shkaf in DataBaseAccess.db.Shkafs)
      {
        listBox1.Items.Add(shkaf);
      }

      if (listBox1.Items.Count > 0)
      {
        listBox1.SelectedIndex = 0;
        listBox1.Sorted = true;
      }

    }

    private void shkafNumberTextBox_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (shkafNumberTextBox.Text.Trim().Length != 6)
        {
          throw new Exception();
        }
        Convert.ToInt32(shkafNumberTextBox.Text.Trim());
        errorNewShkaf.SetError((Control)sender, "");
      }
      catch (Exception)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Значение должно быть 6-и значное число");
      }
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

    private void poverkaDateTimePicker_Validating(object sender, CancelEventArgs e)
    {
      if (poverkaDateTimePicker.Value > DateTime.Now)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Дата должна быть меньше сегодняшнего дня");
      }
      else
      {
        errorNewShkaf.SetError((Control)sender, "");
      }
    }

    private void addressTextBox_Validating(object sender, CancelEventArgs e)
    {
      if (addressTextBox.Text.Trim().Length < 3)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Укажите правильное имя адресса");
      }
      else errorNewShkaf.SetError((Control)sender, "");
    }

    private void installerTextBox_Validating(object sender, CancelEventArgs e)
    {
      if (installerTextBox.Text.Trim().Length < 3)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Укажите правильное имя установителя");
      }
      else errorNewShkaf.SetError((Control)sender, "");
    }

    private void password1TextBox_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (password1TextBox.Text.Trim().Length != 6)
        {
          throw new Exception();
        }
        Convert.ToInt32(password1TextBox.Text.Trim());
        errorNewShkaf.SetError((Control)sender, "");
      }
      catch (Exception)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Значение должно быть 6-и значное число");
      }
    }

    private void password2TextBox_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (password2TextBox.Text.Trim().Length != 6)
        {
          throw new Exception();
        }
        Convert.ToInt32(password2TextBox.Text.Trim());
        errorNewShkaf.SetError((Control)sender, "");
      }
      catch (Exception)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Значение должно быть 6-и значное число");
      }
    }

    private void password3TextBox_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (password3TextBox.Text.Trim().Length != 6)
        {
          throw new Exception();
        }
        Convert.ToInt32(password3TextBox.Text.Trim());
        errorNewShkaf.SetError((Control)sender, "");
      }
      catch (Exception)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Значение должно быть 6-и значное число");
      }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox1.SelectedIndex != -1)
      {
        Shkaf shkaf = (Shkaf)listBox1.SelectedItem;
        shkafNumberTextBox.Text = shkaf.ShkafID.ToString();
        installDateTimePicker.Value = (DateTime)shkaf.InstallDate;
        poverkaDateTimePicker.Value = (DateTime)shkaf.PoverkaDate;
        addressTextBox.Text = shkaf.Address.ToString();
        installerTextBox.Text = shkaf.Installer.ToString();
        maxCountersUpDown.Value = Convert.ToDecimal(shkaf.CountersQuantity);
        countersTextBox.Text = shkaf.Counters.Count.ToString();
        //unAuthorizedComboBox.Text = shkaf.IsUnauthorizedAccess ? "Да" : "Нет";
        is5YearPoverkaTextBox.Text = (shkaf.PoverkaDate.AddYears(5) < DateTime.Now) ? "Да" : "Нет";
        //password1TextBox.Text = shkaf.Password1.ToString();
        //password2TextBox.Text = shkaf.Password2.ToString();
        //password3TextBox.Text = shkaf.Password3.ToString();
      }
    }

    private void vvodButton_Click(object sender, EventArgs e)
    {
      if (adminPasswordTextBox.Text.Trim() == "95414")
      {
        password1TextBox.Enabled = true;
        password2TextBox.Enabled = true;
        password3TextBox.Enabled = true;
      }
      else
      {
        MessageBox.Show("Введен неправильный административный пароль\nПопробуйте еще раз",
          "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return;
      }
    }

    public bool IsValidForm()
    {
      if (shkafNumberTextBox.Text.Trim().Length != 6 ||
          shkafNumberTextBox.Text.Trim()[0] == '0' ||
          installDateTimePicker.Value > DateTime.Now ||
          poverkaDateTimePicker.Value > DateTime.Now ||
          installerTextBox.Text.Trim().Length < 3 ||
          addressTextBox.Text.Trim().Length < 3 ||
          password1TextBox.Text.Trim().Length != 6 ||
          password2TextBox.Text.Trim().Length != 6 ||
          password3TextBox.Text.Trim().Length != 6 ||
          int.Parse(maxCountersUpDown.Value.ToString()) < int.Parse(countersTextBox.Text.Trim()))
        return false;
      try
      {
        int.Parse(shkafNumberTextBox.Text.Trim());
        int.Parse(password1TextBox.Text.Trim());
        int.Parse(password2TextBox.Text.Trim());
        int.Parse(password3TextBox.Text.Trim());
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
        MessageBox.Show("Корректировка модуля невозможно из-за неправильных входных значений", 
          "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      DialogResult result = MessageBox.Show("Вы действительно хотите изменить параметры модуля номер " + 
        (listBox1.SelectedItem as Shkaf).ShkafID.ToString() + "?", "Указание", 
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (result == DialogResult.No) return;
      else
      {

        Shkaf newShkaf = new Shkaf
        {
          ShkafID = int.Parse(shkafNumberTextBox.Text.Trim()),
          Address = addressTextBox.Text.Trim(),
          InstallDate = installDateTimePicker.Value,
          PoverkaDate = poverkaDateTimePicker.Value,
          Installer = installerTextBox.Text.Trim(),
          CountersQuantity = (int)maxCountersUpDown.Value,
          //Is5YearPoverka = (is5YearPoverkaComboBox.Text == "Да") ? true : false,
          //IsUnauthorizedAccess = (unAuthorizedComboBox.Text == "Да") ? true : false,
          Password1 = password1TextBox.Text.Trim(),
          Password2 = password2TextBox.Text.Trim(),
          Password3 = password3TextBox.Text.Trim()
        };

          DataBaseAccess.UpdateShkaf(newShkaf, ((Shkaf) listBox1.SelectedItem).ShkafID);

          //MessageBox.Show("Изменения шкафа номер: " + newShkaf.ShkafID.ToString() + " приняты!",
          //  "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
          listBox1.Items.Clear();
          foreach (Shkaf shkaf in DataBaseAccess.db.Shkafs)
          {
            listBox1.Items.Add(shkaf);
            listBox1.Sorted = true;
          }
        }
      }

    private void ChangeShkaf_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }

    private void maxCountersUpDown_Validating(object sender, CancelEventArgs e)
    {
      if (int.Parse(maxCountersUpDown.Value.ToString()) < int.Parse(countersTextBox.Text.Trim()))
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Максимальное количество счетчиков не может быть меньше\n имеющихся количества счетчиков в данном модуле");
      }
      else errorNewShkaf.SetError((Control)sender, "");
    }

    }
  }