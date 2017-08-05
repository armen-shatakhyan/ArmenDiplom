using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ArmenDiplom
{
  public partial class InputBadAccess : Form
  {
    public static bool isOpened = false;
    private Dictionary<int, string> months;
    private string pastValue = "";
    public InputBadAccess()
    {
      InitializeComponent();
      months = new Dictionary<int, string>();
      months.Add(1, "Январь");
      months.Add(2, "Февраль");
      months.Add(3, "Март");
      months.Add(4, "Апрель");
      months.Add(5, "Май");
      months.Add(6, "Июнь");
      months.Add(7, "Июль");
      months.Add(8, "Август");
      months.Add(9, "Сентябрь");
      months.Add(10, "Октябрь");
      months.Add(11, "Ноябрь");
      months.Add(12, "Декабрь");
      isOpened = true;
      shkafListBox.DataSource = DataBaseAccess.db.Shkafs.Where(f => f.ShkafStatements.Count != f.ShkafStatements.Sum(s => s.AccessQuantity)).OrderBy(f => f.ShkafID);
      if (shkafListBox.Items.Count > 0) shkafListBox.SelectedIndex = -1;
    }

    private void InputBadAccess_Load(object sender, EventArgs e)
    {
      
    }

    private void InputBadAccess_FormClosed(object sender, FormClosedEventArgs e)
    {
      isOpened = false;
    }

    private void shkafListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (shkafListBox.SelectedIndex != -1)
      {
        label2.Text = "Список месяцев и годов модуля N " + (shkafListBox.SelectedItem as Shkaf).ShkafID.ToString() +
          "\nгде доступ к модулю осуществлялся болле 1 раза";

        var query = from f in DataBaseAccess.db.ShkafStatements
                    where f.Shkaf == (Shkaf)shkafListBox.SelectedItem && f.AccessQuantity > 1
                    orderby f.Year, f.Month
                    select new { f.Year, Month = months[f.Month], f.AccessQuantity, BadAccessQuantity = f.BadAccessQuantity.ToString() };

        DataTable dataTable = new DataTable();
        dataTable.Columns.Add("Год", typeof(int));
        dataTable.Columns["Год"].ReadOnly = true;
        dataTable.Columns.Add("Месяц", typeof(string));
        dataTable.Columns["Месяц"].ReadOnly = true;
        dataTable.Columns.Add("Количество доступов", typeof(int));
        dataTable.Columns["Количество доступов"].ReadOnly = true;
        dataTable.Columns.Add("Количество несанкционированных доступов", typeof(string));
        dataTable.Columns["Количество несанкционированных доступов"].ReadOnly = false;

        foreach (var q in query)
        {
          dataTable.Rows.Add(new object[] { q.Year, q.Month, q.AccessQuantity, q.BadAccessQuantity });
        }

        dataGridView1.DataSource = dataTable;
        dataGridView1.Columns["Количество несанкционированных доступов"].Width = 200;

        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
          if (int.Parse(row.Cells[3].Value.ToString()) > 0)
            row.Cells[3].Style.ForeColor = Color.Red;
          else row.Cells[3].Style.ForeColor = Color.Black;
        }
      }
      else
      {
        dataGridView1.DataSource = null;
        label2.Text = "Выберите модуль";
      }
    }

    private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
    {
      if (e.ColumnIndex == 3)
      {
        pastValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
      }
    }

    private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 3)
      {

        int a = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString());
        
        try
        {
          int i = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
          if (i >= a || i < 0)
          {
            MessageBox.Show("Значение должно быть целочисленным положительным числом меньше количества доступов (" + a.ToString() + ")",
              "Ошибка Ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = pastValue;
            if (int.Parse(pastValue) > 0) 
              dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
            else
              dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
          }
          else
          {
            if (i > 0)
              dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
            else
              dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;

            int year = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 3].Value.ToString());
            string monthString = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value.ToString();
            
            int month = (from m in months
                        where m.Value == monthString
                        select m.Key).First();

            var newShkafStatement = (from f in DataBaseAccess.db.ShkafStatements
                        where f.Shkaf == (Shkaf)shkafListBox.SelectedItem && f.Month == month && f.Year == year
                        select f).First();
            newShkafStatement.BadAccessQuantity = i;
            DataBaseAccess.db.SubmitChanges();

          }
        }
        catch (Exception)
        {
          MessageBox.Show("Значение должно быть целочисленным положительным числом меньше количества доступов (" + a.ToString() + ")",
                "Ошибка Ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
          dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = pastValue;
        }
      }
    }

    private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      foreach (DataGridViewRow row in dataGridView1.Rows)
      {
        if (int.Parse(row.Cells[3].Value.ToString()) > 0)
          row.Cells[3].Style.ForeColor = Color.Red;
        else row.Cells[3].Style.ForeColor = Color.Black;
      }
    }
  }
}
