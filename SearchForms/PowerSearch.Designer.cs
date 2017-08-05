namespace ArmenDiplom
{
  partial class PowerSearch
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.DatePanel = new System.Windows.Forms.Panel();
      this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.dateCheckbox = new System.Windows.Forms.CheckBox();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.button1 = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.button2 = new System.Windows.Forms.Button();
      this.DatePanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // DatePanel
      // 
      this.DatePanel.Controls.Add(this.endDateTimePicker);
      this.DatePanel.Controls.Add(this.label2);
      this.DatePanel.Controls.Add(this.label1);
      this.DatePanel.Controls.Add(this.beginDateTimePicker);
      this.DatePanel.Enabled = false;
      this.DatePanel.Location = new System.Drawing.Point(41, 53);
      this.DatePanel.Name = "DatePanel";
      this.DatePanel.Size = new System.Drawing.Size(538, 114);
      this.DatePanel.TabIndex = 0;
      // 
      // endDateTimePicker
      // 
      this.errorProvider1.SetIconPadding(this.endDateTimePicker, 10);
      this.endDateTimePicker.Location = new System.Drawing.Point(188, 66);
      this.endDateTimePicker.Name = "endDateTimePicker";
      this.endDateTimePicker.Size = new System.Drawing.Size(300, 26);
      this.endDateTimePicker.TabIndex = 3;
      this.endDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.endDateTimePicker_Validating);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(17, 69);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(142, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Конечная дата:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(155, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Начальная дата:";
      // 
      // beginDateTimePicker
      // 
      this.errorProvider1.SetIconPadding(this.beginDateTimePicker, 10);
      this.beginDateTimePicker.Location = new System.Drawing.Point(188, 19);
      this.beginDateTimePicker.Name = "beginDateTimePicker";
      this.beginDateTimePicker.Size = new System.Drawing.Size(300, 26);
      this.beginDateTimePicker.TabIndex = 0;
      this.beginDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.beginDateTimePicker_Validating);
      // 
      // dateCheckbox
      // 
      this.dateCheckbox.AutoSize = true;
      this.dateCheckbox.Location = new System.Drawing.Point(41, 23);
      this.dateCheckbox.Name = "dateCheckbox";
      this.dateCheckbox.Size = new System.Drawing.Size(208, 24);
      this.dateCheckbox.TabIndex = 1;
      this.dateCheckbox.Text = "Фильтрация по Дате";
      this.dateCheckbox.UseVisualStyleBackColor = true;
      this.dateCheckbox.CheckedChanged += new System.EventHandler(this.dateCheckbox_CheckedChanged);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(290, 192);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(102, 37);
      this.button1.TabIndex = 2;
      this.button1.Text = "Поиск";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(23, 245);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.Size = new System.Drawing.Size(721, 280);
      this.dataGridView1.TabIndex = 3;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(432, 192);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(98, 36);
      this.button2.TabIndex = 4;
      this.button2.Text = "Печать";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // PowerSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(778, 549);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.dateCheckbox);
      this.Controls.Add(this.DatePanel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "PowerSearch";
      this.Text = "Поиск Модулей с Разряженными Батарейками";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PowerSearch_FormClosed);
      this.DatePanel.ResumeLayout(false);
      this.DatePanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel DatePanel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker beginDateTimePicker;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.CheckBox dateCheckbox;
    private System.Windows.Forms.DateTimePicker endDateTimePicker;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button button2;
  }
}