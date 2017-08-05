namespace ArmenDiplom
{
  partial class NewCounter
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
      this.label1 = new System.Windows.Forms.Label();
      this.counterNumberTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.shkafNumberComboBox = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.ownerNameTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.telNumberTextBox = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.installDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.errorNewShkaf = new System.Windows.Forms.ErrorProvider(this.components);
      this.createButton = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.poverkaCounterDateTimePicker = new System.Windows.Forms.DateTimePicker();
      ((System.ComponentModel.ISupportInitialize)(this.errorNewShkaf)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(106, 31);
      this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(155, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Номер Счетчика:";
      // 
      // counterNumberTextBox
      // 
      this.counterNumberTextBox.Location = new System.Drawing.Point(286, 28);
      this.counterNumberTextBox.MaxLength = 8;
      this.counterNumberTextBox.Name = "counterNumberTextBox";
      this.counterNumberTextBox.Size = new System.Drawing.Size(105, 26);
      this.counterNumberTextBox.TabIndex = 1;
      this.counterNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.counterNumberTextBox_Validating);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(128, 78);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(133, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Номер Шкафа:";
      // 
      // shkafNumberComboBox
      // 
      this.shkafNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.shkafNumberComboBox.FormattingEnabled = true;
      this.errorNewShkaf.SetIconPadding(this.shkafNumberComboBox, 10);
      this.shkafNumberComboBox.Location = new System.Drawing.Point(286, 70);
      this.shkafNumberComboBox.Name = "shkafNumberComboBox";
      this.shkafNumberComboBox.Size = new System.Drawing.Size(105, 28);
      this.shkafNumberComboBox.TabIndex = 3;
      this.shkafNumberComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.shkafNumberComboBox_Validating);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(137, 132);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(124, 20);
      this.label3.TabIndex = 4;
      this.label3.Text = "Имя Хозяина:";
      // 
      // ownerNameTextBox
      // 
      this.ownerNameTextBox.Location = new System.Drawing.Point(286, 126);
      this.ownerNameTextBox.MaxLength = 40;
      this.ownerNameTextBox.Name = "ownerNameTextBox";
      this.ownerNameTextBox.Size = new System.Drawing.Size(184, 26);
      this.ownerNameTextBox.TabIndex = 5;
      this.ownerNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ownerNameTextBox_Validating);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(2, 180);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(259, 20);
      this.label4.TabIndex = 6;
      this.label4.Text = "Телефонный Номер Хозяина:";
      // 
      // telNumberTextBox
      // 
      this.telNumberTextBox.Location = new System.Drawing.Point(286, 174);
      this.telNumberTextBox.Name = "telNumberTextBox";
      this.telNumberTextBox.Size = new System.Drawing.Size(129, 26);
      this.telNumberTextBox.TabIndex = 7;
      this.telNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telNumberTextBox_Validating);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(110, 229);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(151, 20);
      this.label5.TabIndex = 8;
      this.label5.Text = "Дата Установки:";
      // 
      // installDateTimePicker
      // 
      this.installDateTimePicker.Location = new System.Drawing.Point(286, 223);
      this.installDateTimePicker.Name = "installDateTimePicker";
      this.installDateTimePicker.Size = new System.Drawing.Size(299, 26);
      this.installDateTimePicker.TabIndex = 9;
      this.installDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.installDateTimePicker_Validating);
      // 
      // errorNewShkaf
      // 
      this.errorNewShkaf.ContainerControl = this;
      // 
      // createButton
      // 
      this.createButton.Image = global::ArmenDiplom.Properties.Resources.ATLSimple;
      this.createButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.createButton.Location = new System.Drawing.Point(216, 343);
      this.createButton.Name = "createButton";
      this.createButton.Size = new System.Drawing.Size(199, 39);
      this.createButton.TabIndex = 10;
      this.createButton.Text = "Создать Счетчик";
      this.createButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.createButton.UseVisualStyleBackColor = true;
      this.createButton.Click += new System.EventHandler(this.createButton_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(27, 281);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(234, 20);
      this.label6.TabIndex = 11;
      this.label6.Text = "Дата Последней Поверки:";
      // 
      // poverkaCounterDateTimePicker
      // 
      this.poverkaCounterDateTimePicker.Location = new System.Drawing.Point(286, 275);
      this.poverkaCounterDateTimePicker.Name = "poverkaCounterDateTimePicker";
      this.poverkaCounterDateTimePicker.Size = new System.Drawing.Size(299, 26);
      this.poverkaCounterDateTimePicker.TabIndex = 12;
      this.poverkaCounterDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.poverkaCounterDateTimePicker_Validating);
      // 
      // NewCounter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(663, 427);
      this.Controls.Add(this.poverkaCounterDateTimePicker);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.createButton);
      this.Controls.Add(this.installDateTimePicker);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.telNumberTextBox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.ownerNameTextBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.shkafNumberComboBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.counterNumberTextBox);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "NewCounter";
      this.Text = "Создание Счетчика";
      this.Load += new System.EventHandler(this.NewCounter_Load);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewCounter_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.errorNewShkaf)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox counterNumberTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox shkafNumberComboBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox ownerNameTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox telNumberTextBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DateTimePicker installDateTimePicker;
    private System.Windows.Forms.ErrorProvider errorNewShkaf;
    private System.Windows.Forms.Button createButton;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.DateTimePicker poverkaCounterDateTimePicker;
  }
}