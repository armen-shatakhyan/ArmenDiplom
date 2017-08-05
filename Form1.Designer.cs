namespace ArmenDiplom
{
  partial class Form1
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
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.shkafMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.созданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.корректировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.удалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.poiskMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.obshieMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.schetchikiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.inputMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shkafMenuItem,
            this.poiskMenuItem,
            this.obshieMenuItem,
            this.schetchikiMenuItem,
            this.inputMenuItem,
            this.reportToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(746, 24);
        this.menuStrip1.TabIndex = 0;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // shkafMenuItem
        // 
        this.shkafMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеToolStripMenuItem,
            this.корректировкаToolStripMenuItem,
            this.удалениеToolStripMenuItem});
        this.shkafMenuItem.Name = "shkafMenuItem";
        this.shkafMenuItem.Size = new System.Drawing.Size(57, 20);
        this.shkafMenuItem.Text = "Шкафы";
        // 
        // созданиеToolStripMenuItem
        // 
        this.созданиеToolStripMenuItem.Name = "созданиеToolStripMenuItem";
        this.созданиеToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
        this.созданиеToolStripMenuItem.Text = "Создание";
        // 
        // корректировкаToolStripMenuItem
        // 
        this.корректировкаToolStripMenuItem.Name = "корректировкаToolStripMenuItem";
        this.корректировкаToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
        this.корректировкаToolStripMenuItem.Text = "Корректировка";
        // 
        // удалениеToolStripMenuItem
        // 
        this.удалениеToolStripMenuItem.Name = "удалениеToolStripMenuItem";
        this.удалениеToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
        this.удалениеToolStripMenuItem.Text = "Удаление";
        // 
        // poiskMenuItem
        // 
        this.poiskMenuItem.Name = "poiskMenuItem";
        this.poiskMenuItem.Size = new System.Drawing.Size(49, 20);
        this.poiskMenuItem.Text = "Поиск";
        // 
        // obshieMenuItem
        // 
        this.obshieMenuItem.Name = "obshieMenuItem";
        this.obshieMenuItem.Size = new System.Drawing.Size(105, 20);
        this.obshieMenuItem.Text = "Общие сведения";
        // 
        // schetchikiMenuItem
        // 
        this.schetchikiMenuItem.Name = "schetchikiMenuItem";
        this.schetchikiMenuItem.Size = new System.Drawing.Size(68, 20);
        this.schetchikiMenuItem.Text = "Счетчики";
        // 
        // inputMenuItem
        // 
        this.inputMenuItem.Name = "inputMenuItem";
        this.inputMenuItem.Size = new System.Drawing.Size(87, 20);
        this.inputMenuItem.Text = "Вход Данных";
        this.inputMenuItem.Click += new System.EventHandler(this.zagruzkaMenuItem_Click);
        // 
        // openFileDialog1
        // 
        this.openFileDialog1.FileName = "openFileDialog1";
        // 
        // reportToolStripMenuItem
        // 
        this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
        this.reportToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
        this.reportToolStripMenuItem.Text = "Отчеты";
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(746, 469);
        this.Controls.Add(this.menuStrip1);
        this.IsMdiContainer = true;
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "Form1";
        this.Text = "ООО Электросети";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem shkafMenuItem;
    private System.Windows.Forms.ToolStripMenuItem созданиеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem корректировкаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem удалениеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem poiskMenuItem;
    private System.Windows.Forms.ToolStripMenuItem obshieMenuItem;
    private System.Windows.Forms.ToolStripMenuItem schetchikiMenuItem;
    private System.Windows.Forms.ToolStripMenuItem inputMenuItem;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
  }
}

