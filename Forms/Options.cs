using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace ArmenDiplom
{
  public partial class Options : Form
  {
    public static bool isOpened = false; 

    public Options()
    {
      InitializeComponent();
      isOpened = true;
    }

    private void cenaDayTextBox_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        int.Parse(cenaDayTextBox.Text.Trim());
        optionsErrorProvider.SetError((Control)sender, "");
      }
      catch
      {
        optionsErrorProvider.SetError((Control)sender, "Введено неправильное число");
      }
    }

    private void Options_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }

    private void Options_Load(object sender, EventArgs e)
    {
      try
      {
        Configuration config = ConfigurationManager.OpenExeConfiguration("ArmenDiplom.exe");
        beginDayUpDown.Value = decimal.Parse(config.AppSettings.Settings["DayTarifBeginHour"].Value);
        endDayUpDown.Value = decimal.Parse(config.AppSettings.Settings["DayTarifEndHour"].Value);
        int.Parse(config.AppSettings.Settings["DayTarifCena"].Value);
        int.Parse(config.AppSettings.Settings["NightTarifCena"].Value);
        cenaDayTextBox.Text = config.AppSettings.Settings["DayTarifCena"].Value;
        cenaNightTextBox.Text = config.AppSettings.Settings["NightTarifCena"].Value;
      }
      catch (SystemException)
      {
        MessageBox.Show("Введены неправильные значения в конфигурационном файле ArmenDiplom.exe.config." +
          "\n попробуйте исправить их, либо файл не существует. Программа будет закрыта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Application.Exit();
      }
    }

    private void endDayUpDown_Validating(object sender, CancelEventArgs e)
    {
      if (endDayUpDown.Value <= beginDayUpDown.Value)
      {
        optionsErrorProvider.SetError((Control)sender, "Конечный час должен быть больше начального часа");
      }
      else optionsErrorProvider.SetError((Control)sender, "");
    }

    private void cenaNightTextBox_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        int.Parse(cenaNightTextBox.Text.Trim());
        optionsErrorProvider.SetError((Control)sender, "");
      }
      catch
      {
        optionsErrorProvider.SetError((Control)sender, "Введено неправильное число");
      }
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      if (endDayUpDown.Value <= beginDayUpDown.Value)
      {
        MessageBox.Show("Введены неправильные значения. Сохранение невозможно!",
          "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      try
      {
        int.Parse(cenaDayTextBox.Text.Trim());
        int.Parse(cenaNightTextBox.Text.Trim());
      }
      catch (Exception)
      {
        MessageBox.Show("Введены неправильные значения. Сохранение невозможно!",
          "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      DialogResult result = MessageBox.Show("Вы действительно хотите сохранить значения?", 
        "Указание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (result == DialogResult.No) return;
      else
      {
        Configuration config = ConfigurationManager.OpenExeConfiguration("ArmenDiplom.exe");
        config.AppSettings.Settings["DayTarifBeginHour"].Value = beginDayUpDown.Value.ToString();
        config.AppSettings.Settings["DayTarifEndHour"].Value = endDayUpDown.Value.ToString();
        config.AppSettings.Settings["DayTarifCena"].Value = cenaDayTextBox.Text.Trim();
        config.AppSettings.Settings["NightTarifCena"].Value = cenaNightTextBox.Text.Trim();

        // Save the configuration file.
        config.Save(ConfigurationSaveMode.Full);

        // Force a reload of the changed section.
        ConfigurationManager.RefreshSection("appSettings");

        MessageBox.Show("Изменения сохранены!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      
    }

    private void beginDayUpDown_Validating(object sender, CancelEventArgs e)
    {
      if (beginDayUpDown.Value >= endDayUpDown.Value)
      {
        optionsErrorProvider.SetError((Control)sender, "Начальный час должен быть больще начального часа");
      }
      else optionsErrorProvider.SetError((Control)sender, "");
    }
  }
}
