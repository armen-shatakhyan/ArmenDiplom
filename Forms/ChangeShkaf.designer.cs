namespace ArmenDiplom
{
  partial class ChangeShkaf
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
      this.label13 = new System.Windows.Forms.Label();
      this.maxCountersUpDown = new System.Windows.Forms.NumericUpDown();
      this.label6 = new System.Windows.Forms.Label();
      this.installerTextBox = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.addressTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.shkafNumberTextBox = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.saveButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.vvodButton = new System.Windows.Forms.Button();
      this.password3TextBox = new System.Windows.Forms.TextBox();
      this.password2TextBox = new System.Windows.Forms.TextBox();
      this.password1TextBox = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.adminPasswordTextBox = new System.Windows.Forms.TextBox();
      this.label17 = new System.Windows.Forms.Label();
      this.installDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.poverkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.errorNewShkaf = new System.Windows.Forms.ErrorProvider(this.components);
      this.label7 = new System.Windows.Forms.Label();
      this.countersTextBox = new System.Windows.Forms.TextBox();
      this.is5YearPoverkaTextBox = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.maxCountersUpDown)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorNewShkaf)).BeginInit();
      this.SuspendLayout();
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(203, 350);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(217, 40);
      this.label13.TabIndex = 57;
      this.label13.Text = "Прошло ли 5 лет со \r\nдня последней поверки:";
      this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // maxCountersUpDown
      // 
      this.maxCountersUpDown.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.errorNewShkaf.SetIconPadding(this.maxCountersUpDown, 10);
      this.maxCountersUpDown.Location = new System.Drawing.Point(431, 254);
      this.maxCountersUpDown.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
      this.maxCountersUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.maxCountersUpDown.Name = "maxCountersUpDown";
      this.maxCountersUpDown.Size = new System.Drawing.Size(63, 26);
      this.maxCountersUpDown.TabIndex = 51;
      this.maxCountersUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.maxCountersUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.maxCountersUpDown_Validating);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(240, 252);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(180, 40);
      this.label6.TabIndex = 50;
      this.label6.Text = "Количество макси-\r\nмальных счетчиков:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // installerTextBox
      // 
      this.installerTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.errorNewShkaf.SetIconPadding(this.installerTextBox, 10);
      this.installerTextBox.Location = new System.Drawing.Point(431, 214);
      this.installerTextBox.MaxLength = 30;
      this.installerTextBox.Name = "installerTextBox";
      this.installerTextBox.Size = new System.Drawing.Size(265, 26);
      this.installerTextBox.TabIndex = 49;
      this.installerTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.installerTextBox_Validating);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(282, 217);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(138, 20);
      this.label5.TabIndex = 48;
      this.label5.Text = "Кто установил:";
      // 
      // addressTextBox
      // 
      this.addressTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.errorNewShkaf.SetIconPadding(this.addressTextBox, 10);
      this.addressTextBox.Location = new System.Drawing.Point(431, 174);
      this.addressTextBox.MaxLength = 40;
      this.addressTextBox.Name = "addressTextBox";
      this.addressTextBox.Size = new System.Drawing.Size(296, 26);
      this.addressTextBox.TabIndex = 47;
      this.addressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addressTextBox_Validating);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(353, 180);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(67, 20);
      this.label4.TabIndex = 46;
      this.label4.Text = "Адрес:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(271, 124);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(149, 40);
      this.label3.TabIndex = 45;
      this.label3.Text = "Дата последней\r\nповерки:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(272, 87);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(148, 20);
      this.label11.TabIndex = 44;
      this.label11.Text = "Дата установки:";
      // 
      // shkafNumberTextBox
      // 
      this.shkafNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.errorNewShkaf.SetIconPadding(this.shkafNumberTextBox, 10);
      this.shkafNumberTextBox.Location = new System.Drawing.Point(431, 44);
      this.shkafNumberTextBox.MaxLength = 6;
      this.shkafNumberTextBox.Name = "shkafNumberTextBox";
      this.shkafNumberTextBox.Size = new System.Drawing.Size(128, 26);
      this.shkafNumberTextBox.TabIndex = 43;
      this.shkafNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.shkafNumberTextBox_Validating);
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(288, 50);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(132, 20);
      this.label12.TabIndex = 42;
      this.label12.Text = "Номер модуля";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.Maroon;
      this.label2.Location = new System.Drawing.Point(427, 14);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(174, 20);
      this.label2.TabIndex = 38;
      this.label2.Text = "Параметры модуля";
      // 
      // saveButton
      // 
      this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.saveButton.Image = global::ArmenDiplom.Properties.Resources.DISK04;
      this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.saveButton.Location = new System.Drawing.Point(259, 638);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(224, 60);
      this.saveButton.TabIndex = 36;
      this.saveButton.Text = "Сохранить изменения";
      this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.Maroon;
      this.label1.Location = new System.Drawing.Point(8, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(219, 40);
      this.label1.TabIndex = 34;
      this.label1.Text = "Отметьте номер модуля\r\n для изменения";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Location = new System.Drawing.Point(12, 67);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(189, 564);
      this.listBox1.TabIndex = 58;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.vvodButton);
      this.groupBox1.Controls.Add(this.password3TextBox);
      this.groupBox1.Controls.Add(this.password2TextBox);
      this.groupBox1.Controls.Add(this.password1TextBox);
      this.groupBox1.Controls.Add(this.label14);
      this.groupBox1.Controls.Add(this.label15);
      this.groupBox1.Controls.Add(this.label16);
      this.groupBox1.Controls.Add(this.adminPasswordTextBox);
      this.groupBox1.Controls.Add(this.label17);
      this.groupBox1.Location = new System.Drawing.Point(220, 395);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
      this.groupBox1.Size = new System.Drawing.Size(476, 232);
      this.groupBox1.TabIndex = 61;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Пароли модуля";
      // 
      // vvodButton
      // 
      this.vvodButton.Location = new System.Drawing.Point(317, 22);
      this.vvodButton.Margin = new System.Windows.Forms.Padding(5);
      this.vvodButton.Name = "vvodButton";
      this.vvodButton.Size = new System.Drawing.Size(132, 32);
      this.vvodButton.TabIndex = 8;
      this.vvodButton.Text = "Ввод";
      this.vvodButton.UseVisualStyleBackColor = true;
      this.vvodButton.Click += new System.EventHandler(this.vvodButton_Click);
      // 
      // password3TextBox
      // 
      this.password3TextBox.Enabled = false;
      this.errorNewShkaf.SetIconPadding(this.password3TextBox, 10);
      this.password3TextBox.Location = new System.Drawing.Point(303, 196);
      this.password3TextBox.Margin = new System.Windows.Forms.Padding(5);
      this.password3TextBox.MaxLength = 6;
      this.password3TextBox.Name = "password3TextBox";
      this.password3TextBox.Size = new System.Drawing.Size(100, 26);
      this.password3TextBox.TabIndex = 7;
      this.password3TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.password3TextBox_Validating);
      // 
      // password2TextBox
      // 
      this.password2TextBox.Enabled = false;
      this.errorNewShkaf.SetIconPadding(this.password2TextBox, 10);
      this.password2TextBox.Location = new System.Drawing.Point(303, 153);
      this.password2TextBox.Margin = new System.Windows.Forms.Padding(5);
      this.password2TextBox.MaxLength = 6;
      this.password2TextBox.Name = "password2TextBox";
      this.password2TextBox.Size = new System.Drawing.Size(100, 26);
      this.password2TextBox.TabIndex = 6;
      this.password2TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.password2TextBox_Validating);
      // 
      // password1TextBox
      // 
      this.password1TextBox.Enabled = false;
      this.errorNewShkaf.SetIconPadding(this.password1TextBox, 10);
      this.password1TextBox.Location = new System.Drawing.Point(303, 106);
      this.password1TextBox.Margin = new System.Windows.Forms.Padding(5);
      this.password1TextBox.MaxLength = 6;
      this.password1TextBox.Name = "password1TextBox";
      this.password1TextBox.Size = new System.Drawing.Size(100, 26);
      this.password1TextBox.TabIndex = 5;
      this.password1TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.password1TextBox_Validating);
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(10, 201);
      this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(283, 20);
      this.label14.TabIndex = 4;
      this.label14.Text = "3-ий пароль (6-и значное число)";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(10, 158);
      this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(283, 20);
      this.label15.TabIndex = 3;
      this.label15.Text = "2-ой пароль (6-и значное число)";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(8, 110);
      this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(285, 20);
      this.label16.TabIndex = 2;
      this.label16.Text = "1-ый пароль (6-и значное число)";
      // 
      // adminPasswordTextBox
      // 
      this.adminPasswordTextBox.Location = new System.Drawing.Point(303, 64);
      this.adminPasswordTextBox.Margin = new System.Windows.Forms.Padding(5);
      this.adminPasswordTextBox.Name = "adminPasswordTextBox";
      this.adminPasswordTextBox.PasswordChar = '*';
      this.adminPasswordTextBox.Size = new System.Drawing.Size(157, 26);
      this.adminPasswordTextBox.TabIndex = 1;
      // 
      // label17
      // 
      this.label17.Location = new System.Drawing.Point(14, 24);
      this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(282, 71);
      this.label17.TabIndex = 0;
      this.label17.Text = "Чтобы изменить пароли\r\nмодуля, надо сперва ввести\r\nадминистративный пароль";
      this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // installDateTimePicker
      // 
      this.errorNewShkaf.SetIconPadding(this.installDateTimePicker, 10);
      this.installDateTimePicker.Location = new System.Drawing.Point(431, 87);
      this.installDateTimePicker.Name = "installDateTimePicker";
      this.installDateTimePicker.Size = new System.Drawing.Size(296, 26);
      this.installDateTimePicker.TabIndex = 62;
      this.installDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.installDateTimePicker_Validating);
      // 
      // poverkaDateTimePicker
      // 
      this.errorNewShkaf.SetIconPadding(this.poverkaDateTimePicker, 10);
      this.poverkaDateTimePicker.Location = new System.Drawing.Point(431, 131);
      this.poverkaDateTimePicker.Name = "poverkaDateTimePicker";
      this.poverkaDateTimePicker.Size = new System.Drawing.Size(296, 26);
      this.poverkaDateTimePicker.TabIndex = 63;
      this.poverkaDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.poverkaDateTimePicker_Validating);
      // 
      // errorNewShkaf
      // 
      this.errorNewShkaf.ContainerControl = this;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(254, 305);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(166, 40);
      this.label7.TabIndex = 68;
      this.label7.Text = "Количество имею-\r\nщихся счетчиков:";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // countersTextBox
      // 
      this.countersTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.countersTextBox.Location = new System.Drawing.Point(431, 309);
      this.countersTextBox.Name = "countersTextBox";
      this.countersTextBox.ReadOnly = true;
      this.countersTextBox.Size = new System.Drawing.Size(78, 26);
      this.countersTextBox.TabIndex = 69;
      // 
      // is5YearPoverkaTextBox
      // 
      this.is5YearPoverkaTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.is5YearPoverkaTextBox.Location = new System.Drawing.Point(431, 362);
      this.is5YearPoverkaTextBox.Name = "is5YearPoverkaTextBox";
      this.is5YearPoverkaTextBox.ReadOnly = true;
      this.is5YearPoverkaTextBox.Size = new System.Drawing.Size(77, 26);
      this.is5YearPoverkaTextBox.TabIndex = 70;
      // 
      // ChangeShkaf
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(774, 710);
      this.Controls.Add(this.is5YearPoverkaTextBox);
      this.Controls.Add(this.countersTextBox);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.poverkaDateTimePicker);
      this.Controls.Add(this.installDateTimePicker);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.maxCountersUpDown);
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
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "ChangeShkaf";
      this.Text = "Изменение модуля";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeShkaf_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.maxCountersUpDown)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorNewShkaf)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.NumericUpDown maxCountersUpDown;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox installerTextBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox addressTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox shkafNumberTextBox;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button vvodButton;
    private System.Windows.Forms.TextBox password3TextBox;
    private System.Windows.Forms.TextBox password2TextBox;
    private System.Windows.Forms.TextBox password1TextBox;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.TextBox adminPasswordTextBox;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.DateTimePicker installDateTimePicker;
    private System.Windows.Forms.DateTimePicker poverkaDateTimePicker;
    private System.Windows.Forms.ErrorProvider errorNewShkaf;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox countersTextBox;
    private System.Windows.Forms.TextBox is5YearPoverkaTextBox;
  }
}