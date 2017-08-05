namespace ArmenDiplom
{
  partial class NoInformation
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.pastRadioButton = new System.Windows.Forms.RadioButton();
      this.currentRadioButton = new System.Windows.Forms.RadioButton();
      this.button1 = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.button2 = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.pastRadioButton);
      this.groupBox1.Controls.Add(this.currentRadioButton);
      this.groupBox1.Location = new System.Drawing.Point(12, 35);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(490, 110);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Показать модули с непредставленной информацией";
      // 
      // pastRadioButton
      // 
      this.pastRadioButton.AutoSize = true;
      this.pastRadioButton.Location = new System.Drawing.Point(29, 67);
      this.pastRadioButton.Name = "pastRadioButton";
      this.pastRadioButton.Size = new System.Drawing.Size(184, 24);
      this.pastRadioButton.TabIndex = 1;
      this.pastRadioButton.TabStop = true;
      this.pastRadioButton.Text = "за прошлый месяц";
      this.pastRadioButton.UseVisualStyleBackColor = true;
      // 
      // currentRadioButton
      // 
      this.currentRadioButton.AutoSize = true;
      this.currentRadioButton.Location = new System.Drawing.Point(29, 25);
      this.currentRadioButton.Name = "currentRadioButton";
      this.currentRadioButton.Size = new System.Drawing.Size(178, 24);
      this.currentRadioButton.TabIndex = 0;
      this.currentRadioButton.TabStop = true;
      this.currentRadioButton.Text = "за текущий месяц";
      this.currentRadioButton.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(95, 170);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(114, 52);
      this.button1.TabIndex = 2;
      this.button1.Text = "Поиск";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(25, 239);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.Size = new System.Drawing.Size(450, 267);
      this.dataGridView1.TabIndex = 3;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(261, 170);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(109, 52);
      this.button2.TabIndex = 4;
      this.button2.Text = "Печать";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // NoInformation
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(519, 556);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "NoInformation";
      this.Text = "Модули с Непредставленной Информацией";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NoInformation_FormClosed);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.RadioButton pastRadioButton;
    private System.Windows.Forms.RadioButton currentRadioButton;
    private System.Windows.Forms.Button button2;
  }
}