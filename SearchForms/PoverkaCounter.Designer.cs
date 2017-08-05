namespace ArmenDiplom
{
  partial class PoverkaCounter
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.countersListRadioButton = new System.Windows.Forms.RadioButton();
      this.passedCounterRadioButton = new System.Windows.Forms.RadioButton();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.countersListRadioButton);
      this.groupBox1.Controls.Add(this.passedCounterRadioButton);
      this.groupBox1.Location = new System.Drawing.Point(99, 42);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(490, 110);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Показать";
      // 
      // countersListRadioButton
      // 
      this.countersListRadioButton.AutoSize = true;
      this.countersListRadioButton.Location = new System.Drawing.Point(29, 67);
      this.countersListRadioButton.Name = "countersListRadioButton";
      this.countersListRadioButton.Size = new System.Drawing.Size(409, 24);
      this.countersListRadioButton.TabIndex = 1;
      this.countersListRadioButton.Text = "список счетчиков и даты истечения поверки";
      this.countersListRadioButton.UseVisualStyleBackColor = true;
      this.countersListRadioButton.CheckedChanged += new System.EventHandler(this.countersListRadioButton_CheckedChanged);
      // 
      // passedCounterRadioButton
      // 
      this.passedCounterRadioButton.AutoSize = true;
      this.passedCounterRadioButton.Checked = true;
      this.passedCounterRadioButton.Location = new System.Drawing.Point(29, 25);
      this.passedCounterRadioButton.Name = "passedCounterRadioButton";
      this.passedCounterRadioButton.Size = new System.Drawing.Size(419, 24);
      this.passedCounterRadioButton.TabIndex = 0;
      this.passedCounterRadioButton.TabStop = true;
      this.passedCounterRadioButton.Text = "список счетчиков с истекщим сроком поверки";
      this.passedCounterRadioButton.UseVisualStyleBackColor = true;
      this.passedCounterRadioButton.CheckedChanged += new System.EventHandler(this.countersListRadioButton_CheckedChanged);
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
      this.dataGridView1.Location = new System.Drawing.Point(12, 178);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.Size = new System.Drawing.Size(969, 370);
      this.dataGridView1.TabIndex = 3;
      this.dataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
      this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(670, 56);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(93, 47);
      this.button1.TabIndex = 4;
      this.button1.Text = "Поиск";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(670, 109);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(93, 43);
      this.button2.TabIndex = 5;
      this.button2.Text = "Печать";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(36, 553);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(798, 32);
      this.label1.TabIndex = 6;
      this.label1.Text = "Примечание: в поле \"Дата\" истечения срока поверки красным обозначены те даты кото" +
          "рые уже истекли, \r\nкоричневым обозначены те даты у которых срок истекает менее ч" +
          "ем через два месяца";
      this.label1.Visible = false;
      // 
      // PoverkaCounter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(993, 594);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "PoverkaCounter";
      this.Text = "Список Счетчиков";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PoverkaCounter_FormClosed);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton countersListRadioButton;
    private System.Windows.Forms.RadioButton passedCounterRadioButton;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label1;
  }
}