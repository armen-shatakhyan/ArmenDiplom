namespace ArmenDiplom
{
    partial class NewShkaf
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
          this.shkafNumberTextBox = new System.Windows.Forms.TextBox();
          this.errorNewShkaf = new System.Windows.Forms.ErrorProvider(this.components);
          this.installShkafDateTimePicker = new System.Windows.Forms.DateTimePicker();
          this.poverkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
          this.addressTextBox = new System.Windows.Forms.TextBox();
          this.installerTextBox = new System.Windows.Forms.TextBox();
          this.password3TextBox = new System.Windows.Forms.TextBox();
          this.password2TextBox = new System.Windows.Forms.TextBox();
          this.password1TextBox = new System.Windows.Forms.TextBox();
          this.label2 = new System.Windows.Forms.Label();
          this.label3 = new System.Windows.Forms.Label();
          this.label4 = new System.Windows.Forms.Label();
          this.label5 = new System.Windows.Forms.Label();
          this.label6 = new System.Windows.Forms.Label();
          this.countersUpDown = new System.Windows.Forms.NumericUpDown();
          this.groupBox1 = new System.Windows.Forms.GroupBox();
          this.label10 = new System.Windows.Forms.Label();
          this.label9 = new System.Windows.Forms.Label();
          this.label8 = new System.Windows.Forms.Label();
          this.adminPasswordTextBox = new System.Windows.Forms.TextBox();
          this.label7 = new System.Windows.Forms.Label();
          this.createNewShkafButton = new System.Windows.Forms.Button();
          this.button1 = new System.Windows.Forms.Button();
          ((System.ComponentModel.ISupportInitialize)(this.errorNewShkaf)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.countersUpDown)).BeginInit();
          this.groupBox1.SuspendLayout();
          this.SuspendLayout();
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(25, 18);
          this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(212, 40);
          this.label1.TabIndex = 0;
          this.label1.Text = "Введите Номер Шкафа:\r\n(6-и значное число)";
          this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // shkafNumberTextBox
          // 
          this.errorNewShkaf.SetIconPadding(this.shkafNumberTextBox, 10);
          this.shkafNumberTextBox.Location = new System.Drawing.Point(274, 28);
          this.shkafNumberTextBox.Margin = new System.Windows.Forms.Padding(5);
          this.shkafNumberTextBox.MaxLength = 6;
          this.shkafNumberTextBox.Name = "shkafNumberTextBox";
          this.shkafNumberTextBox.Size = new System.Drawing.Size(217, 26);
          this.shkafNumberTextBox.TabIndex = 1;
          this.shkafNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.shkafNumberTextBox_Validating);
          // 
          // errorNewShkaf
          // 
          this.errorNewShkaf.ContainerControl = this;
          // 
          // installShkafDateTimePicker
          // 
          this.errorNewShkaf.SetIconPadding(this.installShkafDateTimePicker, 10);
          this.installShkafDateTimePicker.Location = new System.Drawing.Point(274, 86);
          this.installShkafDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
          this.installShkafDateTimePicker.Name = "installShkafDateTimePicker";
          this.installShkafDateTimePicker.Size = new System.Drawing.Size(295, 26);
          this.installShkafDateTimePicker.TabIndex = 3;
          this.installShkafDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.installShkafDateTimePicker_Validating);
          // 
          // poverkaDateTimePicker
          // 
          this.errorNewShkaf.SetIconPadding(this.poverkaDateTimePicker, 10);
          this.poverkaDateTimePicker.Location = new System.Drawing.Point(276, 148);
          this.poverkaDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
          this.poverkaDateTimePicker.Name = "poverkaDateTimePicker";
          this.poverkaDateTimePicker.Size = new System.Drawing.Size(293, 26);
          this.poverkaDateTimePicker.TabIndex = 6;
          this.poverkaDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.poverkaDateTimePicker_Validating);
          // 
          // addressTextBox
          // 
          this.errorNewShkaf.SetIconPadding(this.addressTextBox, 10);
          this.addressTextBox.Location = new System.Drawing.Point(276, 208);
          this.addressTextBox.Margin = new System.Windows.Forms.Padding(5);
          this.addressTextBox.MaxLength = 40;
          this.addressTextBox.Name = "addressTextBox";
          this.addressTextBox.Size = new System.Drawing.Size(216, 26);
          this.addressTextBox.TabIndex = 8;
          this.addressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addressTextBox_Validating);
          // 
          // installerTextBox
          // 
          this.errorNewShkaf.SetIconPadding(this.installerTextBox, 10);
          this.installerTextBox.Location = new System.Drawing.Point(276, 263);
          this.installerTextBox.Margin = new System.Windows.Forms.Padding(5);
          this.installerTextBox.MaxLength = 30;
          this.installerTextBox.Name = "installerTextBox";
          this.installerTextBox.Size = new System.Drawing.Size(217, 26);
          this.installerTextBox.TabIndex = 10;
          this.installerTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.installerTextBox_Validating);
          // 
          // password3TextBox
          // 
          this.password3TextBox.Enabled = false;
          this.errorNewShkaf.SetIconPadding(this.password3TextBox, 10);
          this.password3TextBox.Location = new System.Drawing.Point(303, 212);
          this.password3TextBox.Margin = new System.Windows.Forms.Padding(5);
          this.password3TextBox.MaxLength = 6;
          this.password3TextBox.Name = "password3TextBox";
          this.password3TextBox.Size = new System.Drawing.Size(157, 26);
          this.password3TextBox.TabIndex = 7;
          this.password3TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.password3TextBox_Validating);
          // 
          // password2TextBox
          // 
          this.password2TextBox.Enabled = false;
          this.errorNewShkaf.SetIconPadding(this.password2TextBox, 10);
          this.password2TextBox.Location = new System.Drawing.Point(303, 169);
          this.password2TextBox.Margin = new System.Windows.Forms.Padding(5);
          this.password2TextBox.MaxLength = 6;
          this.password2TextBox.Name = "password2TextBox";
          this.password2TextBox.Size = new System.Drawing.Size(157, 26);
          this.password2TextBox.TabIndex = 6;
          this.password2TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.password2TextBox_Validating);
          // 
          // password1TextBox
          // 
          this.password1TextBox.Enabled = false;
          this.errorNewShkaf.SetIconPadding(this.password1TextBox, 10);
          this.password1TextBox.Location = new System.Drawing.Point(303, 122);
          this.password1TextBox.Margin = new System.Windows.Forms.Padding(5);
          this.password1TextBox.MaxLength = 6;
          this.password1TextBox.Name = "password1TextBox";
          this.password1TextBox.Size = new System.Drawing.Size(157, 26);
          this.password1TextBox.TabIndex = 5;
          this.password1TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.password1TextBox_Validating);
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(9, 92);
          this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(228, 20);
          this.label2.TabIndex = 2;
          this.label2.Text = "Введите Дату Установки:";
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Location = new System.Drawing.Point(26, 148);
          this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(211, 20);
          this.label3.TabIndex = 5;
          this.label3.Text = "Введите Дату Поверки:";
          // 
          // label4
          // 
          this.label4.AutoSize = true;
          this.label4.Location = new System.Drawing.Point(158, 214);
          this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
          this.label4.Name = "label4";
          this.label4.Size = new System.Drawing.Size(79, 20);
          this.label4.TabIndex = 7;
          this.label4.Text = "Аддрес:";
          // 
          // label5
          // 
          this.label5.AutoSize = true;
          this.label5.Location = new System.Drawing.Point(91, 266);
          this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
          this.label5.Name = "label5";
          this.label5.Size = new System.Drawing.Size(146, 20);
          this.label5.TabIndex = 9;
          this.label5.Text = "Кто Установил?";
          // 
          // label6
          // 
          this.label6.AutoSize = true;
          this.label6.Location = new System.Drawing.Point(26, 329);
          this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
          this.label6.Name = "label6";
          this.label6.Size = new System.Drawing.Size(211, 20);
          this.label6.TabIndex = 11;
          this.label6.Text = "Количество Счетчиков:";
          // 
          // countersUpDown
          // 
          this.countersUpDown.Location = new System.Drawing.Point(276, 323);
          this.countersUpDown.Margin = new System.Windows.Forms.Padding(5);
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
          this.countersUpDown.Size = new System.Drawing.Size(75, 26);
          this.countersUpDown.TabIndex = 12;
          this.countersUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
          // 
          // groupBox1
          // 
          this.groupBox1.Controls.Add(this.button1);
          this.groupBox1.Controls.Add(this.password3TextBox);
          this.groupBox1.Controls.Add(this.password2TextBox);
          this.groupBox1.Controls.Add(this.password1TextBox);
          this.groupBox1.Controls.Add(this.label10);
          this.groupBox1.Controls.Add(this.label9);
          this.groupBox1.Controls.Add(this.label8);
          this.groupBox1.Controls.Add(this.adminPasswordTextBox);
          this.groupBox1.Controls.Add(this.label7);
          this.groupBox1.Location = new System.Drawing.Point(28, 375);
          this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
          this.groupBox1.Name = "groupBox1";
          this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
          this.groupBox1.Size = new System.Drawing.Size(503, 256);
          this.groupBox1.TabIndex = 13;
          this.groupBox1.TabStop = false;
          this.groupBox1.Text = "Пароли Шкафа";
          // 
          // label10
          // 
          this.label10.AutoSize = true;
          this.label10.Location = new System.Drawing.Point(10, 217);
          this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
          this.label10.Name = "label10";
          this.label10.Size = new System.Drawing.Size(288, 20);
          this.label10.TabIndex = 4;
          this.label10.Text = "3-ый Пароль (6-и значное число)";
          // 
          // label9
          // 
          this.label9.AutoSize = true;
          this.label9.Location = new System.Drawing.Point(10, 174);
          this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
          this.label9.Name = "label9";
          this.label9.Size = new System.Drawing.Size(288, 20);
          this.label9.TabIndex = 3;
          this.label9.Text = "2-ый Пароль (6-и значное число)";
          // 
          // label8
          // 
          this.label8.AutoSize = true;
          this.label8.Location = new System.Drawing.Point(10, 126);
          this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
          this.label8.Name = "label8";
          this.label8.Size = new System.Drawing.Size(288, 20);
          this.label8.TabIndex = 2;
          this.label8.Text = "1-ый Пароль (6-и значное число)";
          // 
          // adminPasswordTextBox
          // 
          this.adminPasswordTextBox.Location = new System.Drawing.Point(303, 80);
          this.adminPasswordTextBox.Margin = new System.Windows.Forms.Padding(5);
          this.adminPasswordTextBox.Name = "adminPasswordTextBox";
          this.adminPasswordTextBox.PasswordChar = '*';
          this.adminPasswordTextBox.Size = new System.Drawing.Size(157, 26);
          this.adminPasswordTextBox.TabIndex = 1;
          // 
          // label7
          // 
          this.label7.Location = new System.Drawing.Point(16, 40);
          this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
          this.label7.Name = "label7";
          this.label7.Size = new System.Drawing.Size(282, 71);
          this.label7.TabIndex = 0;
          this.label7.Text = "Чтобы задать пароли шкафа, нужно сначала ввести административный пароль ";
          this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // createNewShkafButton
          // 
          this.createNewShkafButton.Image = global::ArmenDiplom.Properties.Resources.LOGGER;
          this.createNewShkafButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
          this.createNewShkafButton.Location = new System.Drawing.Point(158, 641);
          this.createNewShkafButton.Margin = new System.Windows.Forms.Padding(5);
          this.createNewShkafButton.Name = "createNewShkafButton";
          this.createNewShkafButton.Size = new System.Drawing.Size(238, 48);
          this.createNewShkafButton.TabIndex = 4;
          this.createNewShkafButton.Text = "Создать Новый Шкаф";
          this.createNewShkafButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          this.createNewShkafButton.UseVisualStyleBackColor = true;
          this.createNewShkafButton.Click += new System.EventHandler(this.createNewShkafButton_Click);
          // 
          // button1
          // 
          this.button1.Image = global::ArmenDiplom.Properties.Resources.SECUR05;
          this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
          this.button1.Location = new System.Drawing.Point(317, 38);
          this.button1.Margin = new System.Windows.Forms.Padding(5);
          this.button1.Name = "button1";
          this.button1.Size = new System.Drawing.Size(132, 32);
          this.button1.TabIndex = 8;
          this.button1.Text = "Ввод";
          this.button1.UseVisualStyleBackColor = true;
          this.button1.Click += new System.EventHandler(this.button1_Click);
          // 
          // NewShkaf
          // 
          this.AcceptButton = this.createNewShkafButton;
          this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(623, 699);
          this.Controls.Add(this.groupBox1);
          this.Controls.Add(this.countersUpDown);
          this.Controls.Add(this.label6);
          this.Controls.Add(this.installerTextBox);
          this.Controls.Add(this.label5);
          this.Controls.Add(this.addressTextBox);
          this.Controls.Add(this.label4);
          this.Controls.Add(this.poverkaDateTimePicker);
          this.Controls.Add(this.label3);
          this.Controls.Add(this.createNewShkafButton);
          this.Controls.Add(this.installShkafDateTimePicker);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.shkafNumberTextBox);
          this.Controls.Add(this.label1);
          this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
          this.Margin = new System.Windows.Forms.Padding(5);
          this.Name = "NewShkaf";
          this.Text = "Создание Шкафа";
          this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewShkaf_FormClosed);
          ((System.ComponentModel.ISupportInitialize)(this.errorNewShkaf)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.countersUpDown)).EndInit();
          this.groupBox1.ResumeLayout(false);
          this.groupBox1.PerformLayout();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shkafNumberTextBox;
        private System.Windows.Forms.ErrorProvider errorNewShkaf;
        private System.Windows.Forms.DateTimePicker installShkafDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createNewShkafButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker poverkaDateTimePicker;
        private System.Windows.Forms.TextBox installerTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown countersUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adminPasswordTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox password1TextBox;
        private System.Windows.Forms.TextBox password3TextBox;
        private System.Windows.Forms.TextBox password2TextBox;
        private System.Windows.Forms.Button button1;
    }
}