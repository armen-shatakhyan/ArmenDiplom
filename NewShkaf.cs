using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Linq;

namespace ArmenDiplom
{
  public partial class NewShkaf : Form
  {
    public static bool isOpened = false;
      
    public NewShkaf()
    {
      InitializeComponent();
      isOpened = true;
    }

    private void shkafNumberTextBox_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (shkafNumberTextBox.Text.Trim().Length != 6)
        {
            throw new Exception();
        }
        else if (shkafNumberTextBox.Text.Trim()[0] == '0')
        {
          errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
          errorNewShkaf.SetError((Control)sender, "Первое число не должно быть нулевым");
        }
        else
        {
          Convert.ToInt32(shkafNumberTextBox.Text.Trim());
          errorNewShkaf.SetError((Control)sender, "");
        }
      }
      catch (Exception)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Значение должно быть 6-и значное число");
      }
    }

    private void installShkafDateTimePicker_Validating(object sender, CancelEventArgs e)
    {   
      if (installShkafDateTimePicker.Value > DateTime.Now)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Дата должна быть меньше сегодняшнего дня");
      }
      else
      {
        errorNewShkaf.SetError((Control)sender, "");
      } 
    }

    private void createNewShkafButton_Click(object sender, EventArgs e)
    {
      if (!IsValidForm())
      {
        MessageBox.Show("Создание нового шкафа невозможно из-за неправильных входных значений", 
          "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      DialogResult result = MessageBox.Show("Вы действительно хотите создать шкаф?", "Подтверждение", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (result == DialogResult.No) return;
      else
      {
        var query = (from shkaf in DataBaseAccess.db.Shkafs
                     where shkaf.ShkafID == int.Parse(shkafNumberTextBox.Text.Trim())
                     select shkaf).ToList();
        if (query.Count > 0)
        {
          MessageBox.Show("Шкаф с номером " + shkafNumberTextBox.Text.Trim() +
          " уже существует.\n Задайте шкафу другой номер", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Stop);
          return;
        }
        
        Shkaf newShkaf = new Shkaf
        {
          ShkafID = int.Parse(shkafNumberTextBox.Text.Trim()),
          Address = addressTextBox.Text.Trim(),
          InstallDate = installShkafDateTimePicker.Value,
          PoverkaDate = poverkaDateTimePicker.Value,
          Installer = installerTextBox.Text.Trim(),
          CountersQuantity = int.Parse(countersUpDown.Value.ToString()),
          Is5YearPoverka = false,
          IsUnauthorizedAccess = false,
          Password1 = int.Parse(password1TextBox.Text.Trim()),
          Password2 = int.Parse(password2TextBox.Text.Trim()),
          Password3 = int.Parse(password3TextBox.Text.Trim())
        };

        DataBaseAccess.NewShkaf(newShkaf);
        ClearForm();
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

    private void installerTextBox_Validating(object sender, CancelEventArgs e)
    {
      if (installerTextBox.Text.Trim().Length < 3)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Укажите правильное имя установителя");
      }
      else errorNewShkaf.SetError((Control)sender, "");
    }

    private void addressTextBox_Validating(object sender, CancelEventArgs e)
    {
      if (addressTextBox.Text.Trim().Length < 3)
      {
        errorNewShkaf.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
        errorNewShkaf.SetError((Control)sender, "Укажите правильное имя аддресса");
      }
      else errorNewShkaf.SetError((Control)sender, "");

    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (adminPasswordTextBox.Text.Trim() == "95414")
      {
        password1TextBox.Enabled = true;
        password2TextBox.Enabled = true;
        password3TextBox.Enabled = true;
      }
        else
      {
        password1TextBox.Enabled = false;
        password2TextBox.Enabled = false;
        password3TextBox.Enabled = false;
      }
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

    public bool IsValidForm()
    {
      if (shkafNumberTextBox.Text.Trim().Length != 6 || 
          shkafNumberTextBox.Text.Trim()[0] == '0' ||
          installShkafDateTimePicker.Value > DateTime.Now ||
          poverkaDateTimePicker.Value > DateTime.Now ||
          installerTextBox.Text.Trim().Length < 3 ||
          addressTextBox.Text.Trim().Length < 3 ||
          password1TextBox.Text.Trim().Length != 6 ||
          password2TextBox.Text.Trim().Length != 6 ||
          password3TextBox.Text.Trim().Length != 6)
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

    public void ClearForm()
    {
      password1TextBox.Clear();
      password1TextBox.Enabled = false;
      password2TextBox.Clear();
      password2TextBox.Enabled = false;
      password3TextBox.Clear();
      password3TextBox.Enabled = false;
      shkafNumberTextBox.Clear();
      addressTextBox.Clear();
      installerTextBox.Clear();
      poverkaDateTimePicker.Value = DateTime.Now;
      installShkafDateTimePicker.Value = DateTime.Now;
      countersUpDown.Value = 1;
      adminPasswordTextBox.Clear();
    }

    private void NewShkaf_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }
  }
}