namespace ArmenDiplom
{
  partial class DeleteCounter
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
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
      this.label6 = new System.Windows.Forms.Label();
      this.deleteButton = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.telNumberTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.ownerNameTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.counterNumberTextBox = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.shkafNumberTextBox = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.isNonPayntedTextBox = new System.Windows.Forms.TextBox();
      this.installDateTextBox = new System.Windows.Forms.TextBox();
      this.poverkaDateTextBox = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.currentDayEnergyTextBox = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.currentNightEnergyTextBox = new System.Windows.Forms.TextBox();
      this.pastDayEnergyTextBox = new System.Windows.Forms.TextBox();
      this.pastNightEnergyTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.Maroon;
      this.label2.Location = new System.Drawing.Point(362, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(217, 20);
      this.label2.TabIndex = 39;
      this.label2.Text = "Информация о счетчике";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.Maroon;
      this.label1.Location = new System.Drawing.Point(8, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(226, 40);
      this.label1.TabIndex = 35;
      this.label1.Text = "Пометьте номера\r\nсчетчиков для удаления:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // checkedListBox1
      // 
      this.checkedListBox1.FormattingEnabled = true;
      this.checkedListBox1.Location = new System.Drawing.Point(12, 55);
      this.checkedListBox1.Name = "checkedListBox1";
      this.checkedListBox1.Size = new System.Drawing.Size(206, 445);
      this.checkedListBox1.TabIndex = 33;
      this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(252, 242);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(228, 20);
      this.label6.TabIndex = 51;
      this.label6.Text = "Дата последней поверки:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // deleteButton
      // 
      this.deleteButton.Image = global::ArmenDiplom.Properties.Resources.delete_16x16;
      this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.deleteButton.Location = new System.Drawing.Point(274, 549);
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(233, 65);
      this.deleteButton.TabIndex = 50;
      this.deleteButton.Text = "Удалить Помеченные Счетчики";
      this.deleteButton.UseVisualStyleBackColor = true;
      this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(335, 202);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(148, 20);
      this.label5.TabIndex = 48;
      this.label5.Text = "Дата установки:";
      // 
      // telNumberTextBox
      // 
      this.telNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.telNumberTextBox.Location = new System.Drawing.Point(498, 154);
      this.telNumberTextBox.Name = "telNumberTextBox";
      this.telNumberTextBox.ReadOnly = true;
      this.telNumberTextBox.Size = new System.Drawing.Size(129, 26);
      this.telNumberTextBox.TabIndex = 47;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(307, 160);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(176, 20);
      this.label4.TabIndex = 46;
      this.label4.Text = "Телефон абонента:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // ownerNameTextBox
      // 
      this.ownerNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.ownerNameTextBox.Location = new System.Drawing.Point(498, 114);
      this.ownerNameTextBox.MaxLength = 40;
      this.ownerNameTextBox.Name = "ownerNameTextBox";
      this.ownerNameTextBox.ReadOnly = true;
      this.ownerNameTextBox.Size = new System.Drawing.Size(184, 26);
      this.ownerNameTextBox.TabIndex = 45;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(397, 120);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(86, 20);
      this.label3.TabIndex = 44;
      this.label3.Text = "Абонент:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(353, 79);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(133, 20);
      this.label7.TabIndex = 42;
      this.label7.Text = "Номер шкафа:";
      // 
      // counterNumberTextBox
      // 
      this.counterNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.counterNumberTextBox.Location = new System.Drawing.Point(498, 40);
      this.counterNumberTextBox.MaxLength = 8;
      this.counterNumberTextBox.Name = "counterNumberTextBox";
      this.counterNumberTextBox.ReadOnly = true;
      this.counterNumberTextBox.Size = new System.Drawing.Size(129, 26);
      this.counterNumberTextBox.TabIndex = 41;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(331, 43);
      this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(152, 20);
      this.label8.TabIndex = 40;
      this.label8.Text = "Номер счетчика:";
      // 
      // shkafNumberTextBox
      // 
      this.shkafNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.shkafNumberTextBox.Location = new System.Drawing.Point(498, 76);
      this.shkafNumberTextBox.Name = "shkafNumberTextBox";
      this.shkafNumberTextBox.ReadOnly = true;
      this.shkafNumberTextBox.Size = new System.Drawing.Size(155, 26);
      this.shkafNumberTextBox.TabIndex = 53;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(314, 284);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(169, 20);
      this.label9.TabIndex = 54;
      this.label9.Text = "Была ли неуплата:";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // isNonPayntedTextBox
      // 
      this.isNonPayntedTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.isNonPayntedTextBox.Location = new System.Drawing.Point(498, 278);
      this.isNonPayntedTextBox.Name = "isNonPayntedTextBox";
      this.isNonPayntedTextBox.ReadOnly = true;
      this.isNonPayntedTextBox.Size = new System.Drawing.Size(86, 26);
      this.isNonPayntedTextBox.TabIndex = 55;
      // 
      // installDateTextBox
      // 
      this.installDateTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.installDateTextBox.Location = new System.Drawing.Point(498, 196);
      this.installDateTextBox.Name = "installDateTextBox";
      this.installDateTextBox.ReadOnly = true;
      this.installDateTextBox.Size = new System.Drawing.Size(123, 26);
      this.installDateTextBox.TabIndex = 56;
      // 
      // poverkaDateTextBox
      // 
      this.poverkaDateTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.poverkaDateTextBox.Location = new System.Drawing.Point(498, 236);
      this.poverkaDateTextBox.Name = "poverkaDateTextBox";
      this.poverkaDateTextBox.ReadOnly = true;
      this.poverkaDateTextBox.Size = new System.Drawing.Size(121, 26);
      this.poverkaDateTextBox.TabIndex = 57;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(248, 318);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(238, 40);
      this.label10.TabIndex = 58;
      this.label10.Text = "Расход дневной электро-\r\nэнергии за текущий месяц:";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // currentDayEnergyTextBox
      // 
      this.currentDayEnergyTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.currentDayEnergyTextBox.Location = new System.Drawing.Point(498, 332);
      this.currentDayEnergyTextBox.Name = "currentDayEnergyTextBox";
      this.currentDayEnergyTextBox.ReadOnly = true;
      this.currentDayEnergyTextBox.Size = new System.Drawing.Size(103, 26);
      this.currentDayEnergyTextBox.TabIndex = 59;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(248, 369);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(238, 40);
      this.label11.TabIndex = 60;
      this.label11.Text = "Расход ночной электро-\r\nэнергии за текущий месяц:";
      this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(242, 426);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(244, 40);
      this.label12.TabIndex = 61;
      this.label12.Text = "Расход дневной электро-\r\nэнергии за прошлый месяц:";
      this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(248, 484);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(244, 40);
      this.label13.TabIndex = 62;
      this.label13.Text = "Расход ночной электро-\r\nэнергии за прошлый месяц:";
      this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // currentNightEnergyTextBox
      // 
      this.currentNightEnergyTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.currentNightEnergyTextBox.Location = new System.Drawing.Point(498, 383);
      this.currentNightEnergyTextBox.Name = "currentNightEnergyTextBox";
      this.currentNightEnergyTextBox.ReadOnly = true;
      this.currentNightEnergyTextBox.Size = new System.Drawing.Size(100, 26);
      this.currentNightEnergyTextBox.TabIndex = 63;
      // 
      // pastDayEnergyTextBox
      // 
      this.pastDayEnergyTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.pastDayEnergyTextBox.Location = new System.Drawing.Point(498, 440);
      this.pastDayEnergyTextBox.Name = "pastDayEnergyTextBox";
      this.pastDayEnergyTextBox.ReadOnly = true;
      this.pastDayEnergyTextBox.Size = new System.Drawing.Size(100, 26);
      this.pastDayEnergyTextBox.TabIndex = 64;
      // 
      // pastNightEnergyTextBox
      // 
      this.pastNightEnergyTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.pastNightEnergyTextBox.Location = new System.Drawing.Point(498, 491);
      this.pastNightEnergyTextBox.Name = "pastNightEnergyTextBox";
      this.pastNightEnergyTextBox.ReadOnly = true;
      this.pastNightEnergyTextBox.Size = new System.Drawing.Size(100, 26);
      this.pastNightEnergyTextBox.TabIndex = 65;
      // 
      // DeleteCounter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(737, 626);
      this.Controls.Add(this.pastNightEnergyTextBox);
      this.Controls.Add(this.pastDayEnergyTextBox);
      this.Controls.Add(this.currentNightEnergyTextBox);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.currentDayEnergyTextBox);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.poverkaDateTextBox);
      this.Controls.Add(this.installDateTextBox);
      this.Controls.Add(this.isNonPayntedTextBox);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.shkafNumberTextBox);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.deleteButton);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.telNumberTextBox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.ownerNameTextBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.counterNumberTextBox);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.checkedListBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "DeleteCounter";
      this.Text = "Удаление Счетчика";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteCounter_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckedListBox checkedListBox1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button deleteButton;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox telNumberTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox ownerNameTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox counterNumberTextBox;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox shkafNumberTextBox;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox isNonPayntedTextBox;
    private System.Windows.Forms.TextBox installDateTextBox;
    private System.Windows.Forms.TextBox poverkaDateTextBox;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox currentDayEnergyTextBox;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox currentNightEnergyTextBox;
    private System.Windows.Forms.TextBox pastDayEnergyTextBox;
    private System.Windows.Forms.TextBox pastNightEnergyTextBox;
  }
}