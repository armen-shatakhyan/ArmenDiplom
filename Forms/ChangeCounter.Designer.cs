namespace ArmenDiplom
{
  partial class ChangeCounter
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
      this.label6 = new System.Windows.Forms.Label();
      this.saveButton = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.telNumberTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.ownerNameTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.counterNumberTextBox = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.shkafComboBox = new System.Windows.Forms.ComboBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.installCounterDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.poverkaCounterDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.errorNewShkaf = new System.Windows.Forms.ErrorProvider(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.errorNewShkaf)).BeginInit();
      this.SuspendLayout();
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(247, 295);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(228, 20);
      this.label6.TabIndex = 78;
      this.label6.Text = "Дата последней поверки:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // saveButton
      // 
      this.saveButton.Image = global::ArmenDiplom.Properties.Resources.DISK04;
      this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.saveButton.Location = new System.Drawing.Point(342, 369);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(233, 65);
      this.saveButton.TabIndex = 77;
      this.saveButton.Text = "Сохранить изменения";
      this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(327, 255);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(148, 20);
      this.label5.TabIndex = 76;
      this.label5.Text = "Дата установки:";
      // 
      // telNumberTextBox
      // 
      this.errorNewShkaf.SetIconPadding(this.telNumberTextBox, 10);
      this.telNumberTextBox.Location = new System.Drawing.Point(487, 207);
      this.telNumberTextBox.Name = "telNumberTextBox";
      this.telNumberTextBox.Size = new System.Drawing.Size(129, 26);
      this.telNumberTextBox.TabIndex = 75;
      this.telNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telNumberTextBox_Validating);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(299, 213);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(176, 20);
      this.label4.TabIndex = 74;
      this.label4.Text = "Телефон абонента:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // ownerNameTextBox
      // 
      this.ownerNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.errorNewShkaf.SetIconPadding(this.ownerNameTextBox, 10);
      this.ownerNameTextBox.Location = new System.Drawing.Point(487, 167);
      this.ownerNameTextBox.MaxLength = 40;
      this.ownerNameTextBox.Name = "ownerNameTextBox";
      this.ownerNameTextBox.Size = new System.Drawing.Size(205, 26);
      this.ownerNameTextBox.TabIndex = 73;
      this.ownerNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ownerNameTextBox_Validating);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(389, 173);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(86, 20);
      this.label3.TabIndex = 72;
      this.label3.Text = "Абонент:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(338, 113);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(137, 20);
      this.label7.TabIndex = 71;
      this.label7.Text = "Номер модуля:";
      // 
      // counterNumberTextBox
      // 
      this.counterNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.errorNewShkaf.SetIconPadding(this.counterNumberTextBox, 10);
      this.counterNumberTextBox.Location = new System.Drawing.Point(487, 56);
      this.counterNumberTextBox.MaxLength = 7;
      this.counterNumberTextBox.Name = "counterNumberTextBox";
      this.counterNumberTextBox.Size = new System.Drawing.Size(129, 26);
      this.counterNumberTextBox.TabIndex = 70;
      this.counterNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.counterNumberTextBox_Validating);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(323, 59);
      this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(152, 20);
      this.label8.TabIndex = 69;
      this.label8.Text = "Номер счетчика:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.Maroon;
      this.label2.Location = new System.Drawing.Point(356, 19);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(217, 20);
      this.label2.TabIndex = 68;
      this.label2.Text = "Информация о счетчике";
      // 
      // shkafComboBox
      // 
      this.shkafComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.shkafComboBox.FormattingEnabled = true;
      this.shkafComboBox.Location = new System.Drawing.Point(487, 110);
      this.shkafComboBox.Name = "shkafComboBox";
      this.shkafComboBox.Size = new System.Drawing.Size(103, 28);
      this.shkafComboBox.TabIndex = 92;
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Location = new System.Drawing.Point(16, 59);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(209, 384);
      this.listBox1.TabIndex = 93;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // installCounterDateTimePicker
      // 
      this.errorNewShkaf.SetIconPadding(this.installCounterDateTimePicker, 10);
      this.installCounterDateTimePicker.Location = new System.Drawing.Point(487, 249);
      this.installCounterDateTimePicker.Name = "installCounterDateTimePicker";
      this.installCounterDateTimePicker.Size = new System.Drawing.Size(293, 26);
      this.installCounterDateTimePicker.TabIndex = 94;
      this.installCounterDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.installCounterDateTimePicker_Validating);
      // 
      // poverkaCounterDateTimePicker
      // 
      this.errorNewShkaf.SetIconPadding(this.poverkaCounterDateTimePicker, 10);
      this.poverkaCounterDateTimePicker.Location = new System.Drawing.Point(487, 289);
      this.poverkaCounterDateTimePicker.Name = "poverkaCounterDateTimePicker";
      this.poverkaCounterDateTimePicker.Size = new System.Drawing.Size(293, 26);
      this.poverkaCounterDateTimePicker.TabIndex = 95;
      this.poverkaCounterDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.poverkaCounterDateTimePicker_Validating);
      // 
      // errorNewShkaf
      // 
      this.errorNewShkaf.ContainerControl = this;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.Maroon;
      this.label1.Location = new System.Drawing.Point(13, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(212, 40);
      this.label1.TabIndex = 96;
      this.label1.Text = "Выберите необходимый\r\nсчетчик из списка";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label10.Location = new System.Drawing.Point(653, 99);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(197, 48);
      this.label10.TabIndex = 98;
      this.label10.Text = "(Список модулей с\r\nколичеством счетчиков \r\nне достигших максимума)";
      // 
      // ChangeCounter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(862, 503);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.poverkaCounterDateTimePicker);
      this.Controls.Add(this.installCounterDateTimePicker);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.shkafComboBox);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.telNumberTextBox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.ownerNameTextBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.counterNumberTextBox);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label2);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "ChangeCounter";
      this.Text = "Корректировка Счетчика";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeCounter_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.errorNewShkaf)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox telNumberTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox ownerNameTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox counterNumberTextBox;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox shkafComboBox;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.DateTimePicker installCounterDateTimePicker;
    private System.Windows.Forms.DateTimePicker poverkaCounterDateTimePicker;
    private System.Windows.Forms.ErrorProvider errorNewShkaf;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label10;
  }
}