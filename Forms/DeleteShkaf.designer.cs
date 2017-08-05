namespace ArmenDiplom
{
  partial class DeleteShkaf
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
      this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.installerTextBox = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.addressTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.shkafNumberTextBox = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.installDateTextBox = new System.Windows.Forms.TextBox();
      this.poverkaDateTextBox = new System.Windows.Forms.TextBox();
      this.is5YearPoverkaTextBox = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.countersTextBox = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.maxCountersTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // checkedListBox1
      // 
      this.checkedListBox1.FormattingEnabled = true;
      this.checkedListBox1.Location = new System.Drawing.Point(12, 52);
      this.checkedListBox1.Name = "checkedListBox1";
      this.checkedListBox1.Size = new System.Drawing.Size(206, 361);
      this.checkedListBox1.TabIndex = 1;
      this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.Maroon;
      this.label1.Location = new System.Drawing.Point(8, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(216, 40);
      this.label1.TabIndex = 2;
      this.label1.Text = "Пометьте номера\r\n модулей для удаления:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Image = global::ArmenDiplom.Properties.Resources.delete_16x16;
      this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button1.Location = new System.Drawing.Point(235, 437);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(241, 60);
      this.button1.TabIndex = 3;
      this.button1.Text = "Удаление помеченных модулей";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.Maroon;
      this.label2.Location = new System.Drawing.Point(355, 19);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(212, 20);
      this.label2.TabIndex = 4;
      this.label2.Text = "Информация о модулей";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(247, 241);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(206, 40);
      this.label6.TabIndex = 24;
      this.label6.Text = "Максимальное \r\nколичество счетчиков:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // installerTextBox
      // 
      this.installerTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.installerTextBox.Location = new System.Drawing.Point(476, 195);
      this.installerTextBox.Name = "installerTextBox";
      this.installerTextBox.ReadOnly = true;
      this.installerTextBox.Size = new System.Drawing.Size(247, 26);
      this.installerTextBox.TabIndex = 23;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(310, 198);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(143, 20);
      this.label5.TabIndex = 22;
      this.label5.Text = "Кто установил?";
      // 
      // addressTextBox
      // 
      this.addressTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.addressTextBox.Location = new System.Drawing.Point(476, 163);
      this.addressTextBox.Name = "addressTextBox";
      this.addressTextBox.ReadOnly = true;
      this.addressTextBox.Size = new System.Drawing.Size(247, 26);
      this.addressTextBox.TabIndex = 21;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(386, 166);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(67, 20);
      this.label4.TabIndex = 20;
      this.label4.Text = "Адрес:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(322, 127);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(131, 20);
      this.label3.TabIndex = 18;
      this.label3.Text = "Дата поверки:";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(305, 87);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(148, 20);
      this.label11.TabIndex = 16;
      this.label11.Text = "Дата установки:";
      // 
      // shkafNumberTextBox
      // 
      this.shkafNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.shkafNumberTextBox.Location = new System.Drawing.Point(476, 49);
      this.shkafNumberTextBox.MaxLength = 6;
      this.shkafNumberTextBox.Name = "shkafNumberTextBox";
      this.shkafNumberTextBox.ReadOnly = true;
      this.shkafNumberTextBox.Size = new System.Drawing.Size(128, 26);
      this.shkafNumberTextBox.TabIndex = 15;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(316, 52);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(137, 20);
      this.label12.TabIndex = 14;
      this.label12.Text = "Номер модуля:";
      // 
      // installDateTextBox
      // 
      this.installDateTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.installDateTextBox.Location = new System.Drawing.Point(476, 84);
      this.installDateTextBox.Name = "installDateTextBox";
      this.installDateTextBox.ReadOnly = true;
      this.installDateTextBox.Size = new System.Drawing.Size(128, 26);
      this.installDateTextBox.TabIndex = 28;
      // 
      // poverkaDateTextBox
      // 
      this.poverkaDateTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.poverkaDateTextBox.Location = new System.Drawing.Point(476, 124);
      this.poverkaDateTextBox.Name = "poverkaDateTextBox";
      this.poverkaDateTextBox.ReadOnly = true;
      this.poverkaDateTextBox.Size = new System.Drawing.Size(128, 26);
      this.poverkaDateTextBox.TabIndex = 29;
      // 
      // is5YearPoverkaTextBox
      // 
      this.is5YearPoverkaTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.is5YearPoverkaTextBox.Location = new System.Drawing.Point(476, 357);
      this.is5YearPoverkaTextBox.Name = "is5YearPoverkaTextBox";
      this.is5YearPoverkaTextBox.ReadOnly = true;
      this.is5YearPoverkaTextBox.Size = new System.Drawing.Size(94, 26);
      this.is5YearPoverkaTextBox.TabIndex = 30;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(241, 347);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(212, 40);
      this.label13.TabIndex = 31;
      this.label13.Text = "Прошло ли 5 лет со\r\nдня последней поверки";
      this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // countersTextBox
      // 
      this.countersTextBox.Location = new System.Drawing.Point(476, 291);
      this.countersTextBox.Name = "countersTextBox";
      this.countersTextBox.Size = new System.Drawing.Size(67, 26);
      this.countersTextBox.TabIndex = 32;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(245, 297);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(208, 20);
      this.label14.TabIndex = 33;
      this.label14.Text = "Количество счетчиков:";
      // 
      // maxCountersTextBox
      // 
      this.maxCountersTextBox.Location = new System.Drawing.Point(476, 248);
      this.maxCountersTextBox.Name = "maxCountersTextBox";
      this.maxCountersTextBox.Size = new System.Drawing.Size(67, 26);
      this.maxCountersTextBox.TabIndex = 34;
      // 
      // DeleteShkaf
      // 
      this.ClientSize = new System.Drawing.Size(735, 528);
      this.Controls.Add(this.maxCountersTextBox);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.countersTextBox);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.is5YearPoverkaTextBox);
      this.Controls.Add(this.poverkaDateTextBox);
      this.Controls.Add(this.installDateTextBox);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.installerTextBox);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.addressTextBox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.shkafNumberTextBox);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.checkedListBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "DeleteShkaf";
      this.Text = "Удаление Модулей";
      this.Load += new System.EventHandler(this.DeleteShkaf_Load);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteShkaf_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckedListBox checkedListBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox installerTextBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox addressTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox shkafNumberTextBox;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox installDateTextBox;
    private System.Windows.Forms.TextBox poverkaDateTextBox;
    private System.Windows.Forms.TextBox is5YearPoverkaTextBox;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox countersTextBox;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.TextBox maxCountersTextBox;
  }
}