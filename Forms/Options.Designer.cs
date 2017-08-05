namespace ArmenDiplom
{
  partial class Options
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
      this.label2 = new System.Windows.Forms.Label();
      this.beginDayUpDown = new System.Windows.Forms.NumericUpDown();
      this.endDayUpDown = new System.Windows.Forms.NumericUpDown();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.cenaDayTextBox = new System.Windows.Forms.TextBox();
      this.cenaNightTextBox = new System.Windows.Forms.TextBox();
      this.optionsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.saveButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.beginDayUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.endDayUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.optionsErrorProvider)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(25, 31);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(270, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Начальный час дневного тарифа:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(37, 78);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(258, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Конечный час дневного тарифа:";
      // 
      // beginDayUpDown
      // 
      this.optionsErrorProvider.SetIconPadding(this.beginDayUpDown, 10);
      this.beginDayUpDown.Location = new System.Drawing.Point(313, 25);
      this.beginDayUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.beginDayUpDown.Name = "beginDayUpDown";
      this.beginDayUpDown.Size = new System.Drawing.Size(67, 26);
      this.beginDayUpDown.TabIndex = 4;
      this.beginDayUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.beginDayUpDown_Validating);
      // 
      // endDayUpDown
      // 
      this.optionsErrorProvider.SetIconPadding(this.endDayUpDown, 10);
      this.endDayUpDown.Location = new System.Drawing.Point(313, 72);
      this.endDayUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.endDayUpDown.Name = "endDayUpDown";
      this.endDayUpDown.Size = new System.Drawing.Size(67, 26);
      this.endDayUpDown.TabIndex = 5;
      this.endDayUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.endDayUpDown_Validating);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 127);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(283, 20);
      this.label5.TabIndex = 8;
      this.label5.Text = "Цена дневного тарифа (арм. драм):";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(23, 177);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(272, 20);
      this.label6.TabIndex = 9;
      this.label6.Text = "Цена ночного тарифа (арм. драм):";
      // 
      // cenaDayTextBox
      // 
      this.optionsErrorProvider.SetIconPadding(this.cenaDayTextBox, 10);
      this.cenaDayTextBox.Location = new System.Drawing.Point(313, 121);
      this.cenaDayTextBox.Name = "cenaDayTextBox";
      this.cenaDayTextBox.Size = new System.Drawing.Size(100, 26);
      this.cenaDayTextBox.TabIndex = 10;
      this.cenaDayTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cenaDayTextBox_Validating);
      // 
      // cenaNightTextBox
      // 
      this.optionsErrorProvider.SetIconPadding(this.cenaNightTextBox, 10);
      this.cenaNightTextBox.Location = new System.Drawing.Point(313, 176);
      this.cenaNightTextBox.Name = "cenaNightTextBox";
      this.cenaNightTextBox.Size = new System.Drawing.Size(100, 26);
      this.cenaNightTextBox.TabIndex = 11;
      this.cenaNightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cenaNightTextBox_Validating);
      // 
      // optionsErrorProvider
      // 
      this.optionsErrorProvider.ContainerControl = this;
      // 
      // saveButton
      // 
      this.saveButton.Image = global::ArmenDiplom.Properties.Resources.DISK04;
      this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.saveButton.Location = new System.Drawing.Point(131, 228);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(207, 36);
      this.saveButton.TabIndex = 12;
      this.saveButton.Text = "Сохранить Изменения";
      this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // Options
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(469, 308);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.cenaNightTextBox);
      this.Controls.Add(this.cenaDayTextBox);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.endDayUpDown);
      this.Controls.Add(this.beginDayUpDown);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Options";
      this.Text = "Общие Сведения";
      this.Load += new System.EventHandler(this.Options_Load);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.beginDayUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.endDayUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.optionsErrorProvider)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown beginDayUpDown;
    private System.Windows.Forms.NumericUpDown endDayUpDown;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox cenaDayTextBox;
    private System.Windows.Forms.TextBox cenaNightTextBox;
    private System.Windows.Forms.ErrorProvider optionsErrorProvider;
    private System.Windows.Forms.Button saveButton;
  }
}