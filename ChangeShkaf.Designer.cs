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
      this.label7 = new System.Windows.Forms.Label();
      this.countersUpDown = new System.Windows.Forms.NumericUpDown();
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
      this.unAuthorizedComboBox = new System.Windows.Forms.ComboBox();
      this.is5YearPoverkaComboBox = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.countersUpDown)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorNewShkaf)).BeginInit();
      this.SuspendLayout();
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(207, 322);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(217, 40);
      this.label13.TabIndex = 57;
      this.label13.Text = "Прошло ли 5 лет со \r\nдня последней поверки:";
      this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(234, 271);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(180, 40);
      this.label7.TabIndex = 52;
      this.label7.Text = "Был ли несанкцио-\r\nнированный доступ:";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // countersUpDown
      // 
      this.countersUpDown.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.countersUpDown.Location = new System.Drawing.Point(430, 233);
      this.countersUpDown.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
      this.countersUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.countersUpDown.Name = "countersUpDown";
      this.countersUpDown.ReadOnly = true;
      this.countersUpDown.Size = new System.Drawing.Size(63, 26);
      this.countersUpDown.TabIndex = 51;
      this.countersUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(211, 239);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(208, 20);
      this.label6.TabIndex = 50;
      this.label6.Text = "Количество счетчиков:";
      // 
      // installerTextBox
      // 
      this.installerTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.errorNewShkaf.SetIconPadding(this.installerTextBox, 10);
      this.installerTextBox.Location = new System.Drawing.Point(430, 193);
      this.installerTextBox.MaxLength = 30;
      this.installerTextBox.Name = "installerTextBox";
      this.installerTextBox.Size = new System.Drawing.Size(265, 26);
      this.installerTextBox.TabIndex = 49;
      this.installerTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.installerTextBox_Validating);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(273, 196);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(138, 20);
      this.label5.TabIndex = 48;
      this.label5.Text = "Кто установил:";
      // 
      // addressTextBox
      // 
      this.addressTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.errorNewShkaf.SetIconPadding(this.addressTextBox, 10);
      this.addressTextBox.Location = new System.Drawing.Point(430, 156);
      this.addressTextBox.MaxLength = 40;
      this.addressTextBox.Name = "addressTextBox";
      this.addressTextBox.Size = new System.Drawing.Size(296, 26);
      this.addressTextBox.TabIndex = 47;
      this.addressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addressTextBox_Validating);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(343, 162);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(67, 20);
      this.label4.TabIndex = 46;
      this.label4.Text = "Адрес:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(285, 127);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(131, 20);
      this.label3.TabIndex = 45;
      this.label3.Text = "Дата поверки:";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(268, 87);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(148, 20);
      this.label11.TabIndex = 44;
      this.label11.Text = "Дата установки:";
      // 
      // shkafNumberTextBox
      // 
      this.shkafNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.errorNewShkaf.SetIconPadding(this.shkafNumberTextBox, 10);
      this.shkafNumberTextBox.Location = new System.Drawing.Point(430, 44);
      this.shkafNumberTextBox.MaxLength = 6;
      this.shkafNumberTextBox.Name = "shkafNumberTextBox";
      this.shkafNumberTextBox.ReadOnly = true;
      this.shkafNumberTextBox.Size = new System.Drawing.Size(128, 26);
      this.shkafNumberTextBox.TabIndex = 43;
      this.shkafNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.shkafNumberTextBox_Validating);
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(286, 50);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(133, 20);
      this.label12.TabIndex = 42;
      this.label12.Text = "Номер шкафа:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.Maroon;
      this.label2.Location = new System.Drawing.Point(427, 14);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(170, 20);
      this.label2.TabIndex = 38;
      this.label2.Text = "Параметры шкафа";
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
      this.saveButton.Text = "Сохранить Изменения";
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
      this.label1.Size = new System.Drawing.Size(215, 40);
      this.label1.TabIndex = 34;
      this.label1.Text = "Отметьте номер шкафа\r\n для изменения";
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
      this.groupBox1.Location = new System.Drawing.Point(219, 379);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
      this.groupBox1.Size = new System.Drawing.Size(476, 240);
      this.groupBox1.TabIndex = 61;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Пароли Шкафа";
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
      this.label14.Size = new System.Drawing.Size(286, 20);
      this.label14.TabIndex = 4;
      this.label14.Text = "3-ий Пароль (6-и значное число)";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(10, 158);
      this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(286, 20);
      this.label15.TabIndex = 3;
      this.label15.Text = "2-ой Пароль (6-и значное число)";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(8, 110);
      this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(288, 20);
      this.label16.TabIndex = 2;
      this.label16.Text = "1-ый Пароль (6-и значное число)";
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
      this.label17.Text = "Чтобы изменить пароли шкафа, надо сперва ввести \r\nадминистративный пароль";
      this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // installDateTimePicker
      // 
      this.installDateTimePicker.Location = new System.Drawing.Point(430, 87);
      this.installDateTimePicker.Name = "installDateTimePicker";
      this.installDateTimePicker.Size = new System.Drawing.Size(296, 26);
      this.installDateTimePicker.TabIndex = 62;
      this.installDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.installDateTimePicker_Validating);
      // 
      // poverkaDateTimePicker
      // 
      this.poverkaDateTimePicker.Location = new System.Drawing.Point(430, 124);
      this.poverkaDateTimePicker.Name = "poverkaDateTimePicker";
      this.poverkaDateTimePicker.Size = new System.Drawing.Size(296, 26);
      this.poverkaDateTimePicker.TabIndex = 63;
      this.poverkaDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.poverkaDateTimePicker_Validating);
      // 
      // errorNewShkaf
      // 
      this.errorNewShkaf.ContainerControl = this;
      // 
      // unAuthorizedComboBox
      // 
      this.unAuthorizedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.unAuthorizedComboBox.FormattingEnabled = true;
      this.unAuthorizedComboBox.Items.AddRange(new object[] {
            "Да",
            "Нет"});
      this.unAuthorizedComboBox.Location = new System.Drawing.Point(430, 283);
      this.unAuthorizedComboBox.Name = "unAuthorizedComboBox";
      this.unAuthorizedComboBox.Size = new System.Drawing.Size(78, 28);
      this.unAuthorizedComboBox.TabIndex = 66;
      // 
      // is5YearPoverkaComboBox
      // 
      this.is5YearPoverkaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.is5YearPoverkaComboBox.FormattingEnabled = true;
      this.is5YearPoverkaComboBox.Items.AddRange(new object[] {
            "Да",
            "Нет"});
      this.is5YearPoverkaComboBox.Location = new System.Drawing.Point(431, 329);
      this.is5YearPoverkaComboBox.Name = "is5YearPoverkaComboBox";
      this.is5YearPoverkaComboBox.Size = new System.Drawing.Size(79, 28);
      this.is5YearPoverkaComboBox.TabIndex = 67;
      // 
      // ChangeShkaf
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(757, 710);
      this.Controls.Add(this.is5YearPoverkaComboBox);
      this.Controls.Add(this.unAuthorizedComboBox);
      this.Controls.Add(this.poverkaDateTimePicker);
      this.Controls.Add(this.installDateTimePicker);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.countersUpDown);
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
      this.Text = "Изменение Шкафа";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeShkaf_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.countersUpDown)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorNewShkaf)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.NumericUpDown countersUpDown;
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
    private System.Windows.Forms.ComboBox unAuthorizedComboBox;
    private System.Windows.Forms.ComboBox is5YearPoverkaComboBox;
  }
}