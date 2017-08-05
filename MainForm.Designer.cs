namespace ArmenDiplom
{
  partial class MainForm
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
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.shkafMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newShkafMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.updateShkafMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteShkafMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.poiskMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.obshieMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.schetchikiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newCounterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.changeCounterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteCounterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.inputMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.documentationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shkafMenuItem,
            this.poiskMenuItem,
            this.obshieMenuItem,
            this.schetchikiMenuItem,
            this.inputMenuItem,
            this.reportToolStripMenuItem,
            this.helpMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
      this.menuStrip1.Size = new System.Drawing.Size(891, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // shkafMenuItem
      // 
      this.shkafMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newShkafMenuItem,
            this.updateShkafMenuItem,
            this.deleteShkafMenuItem});
      this.shkafMenuItem.Image = global::ArmenDiplom.Properties.Resources.LOGGER;
      this.shkafMenuItem.Name = "shkafMenuItem";
      this.shkafMenuItem.Size = new System.Drawing.Size(105, 22);
      this.shkafMenuItem.Text = "Шкафы";
      // 
      // newShkafMenuItem
      // 
      this.newShkafMenuItem.Image = global::ArmenDiplom.Properties.Resources.NOTE11;
      this.newShkafMenuItem.Name = "newShkafMenuItem";
      this.newShkafMenuItem.Size = new System.Drawing.Size(214, 22);
      this.newShkafMenuItem.Text = "Создание";
      this.newShkafMenuItem.Click += new System.EventHandler(this.newShkafMenuItem_Click);
      // 
      // updateShkafMenuItem
      // 
      this.updateShkafMenuItem.Image = global::ArmenDiplom.Properties.Resources.SCDRESNS;
      this.updateShkafMenuItem.Name = "updateShkafMenuItem";
      this.updateShkafMenuItem.Size = new System.Drawing.Size(214, 22);
      this.updateShkafMenuItem.Text = "Корректировка";
      this.updateShkafMenuItem.Click += new System.EventHandler(this.updateShkafMenuItem_Click);
      // 
      // deleteShkafMenuItem
      // 
      this.deleteShkafMenuItem.Image = global::ArmenDiplom.Properties.Resources.delete_16x16;
      this.deleteShkafMenuItem.Name = "deleteShkafMenuItem";
      this.deleteShkafMenuItem.Size = new System.Drawing.Size(214, 22);
      this.deleteShkafMenuItem.Text = "Удаление";
      this.deleteShkafMenuItem.Click += new System.EventHandler(this.deleteShkafMenuItem_Click);
      // 
      // poiskMenuItem
      // 
      this.poiskMenuItem.Image = global::ArmenDiplom.Properties.Resources.EXPLORER;
      this.poiskMenuItem.Name = "poiskMenuItem";
      this.poiskMenuItem.Size = new System.Drawing.Size(90, 22);
      this.poiskMenuItem.Text = "Поиск";
      // 
      // obshieMenuItem
      // 
      this.obshieMenuItem.Image = global::ArmenDiplom.Properties.Resources.CHECKMRK;
      this.obshieMenuItem.Name = "obshieMenuItem";
      this.obshieMenuItem.Size = new System.Drawing.Size(190, 22);
      this.obshieMenuItem.Text = "Общие сведения";
      this.obshieMenuItem.Click += new System.EventHandler(this.obshieMenuItem_Click);
      // 
      // schetchikiMenuItem
      // 
      this.schetchikiMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCounterMenuItem,
            this.changeCounterMenuItem,
            this.deleteCounterMenuItem});
      this.schetchikiMenuItem.Image = global::ArmenDiplom.Properties.Resources.ATLSimple;
      this.schetchikiMenuItem.Name = "schetchikiMenuItem";
      this.schetchikiMenuItem.Size = new System.Drawing.Size(119, 22);
      this.schetchikiMenuItem.Text = "Счетчики";
      // 
      // newCounterMenuItem
      // 
      this.newCounterMenuItem.Image = global::ArmenDiplom.Properties.Resources.NOTE11;
      this.newCounterMenuItem.Name = "newCounterMenuItem";
      this.newCounterMenuItem.Size = new System.Drawing.Size(214, 22);
      this.newCounterMenuItem.Text = "Создание";
      this.newCounterMenuItem.Click += new System.EventHandler(this.newCounterMenuItem_Click);
      // 
      // changeCounterMenuItem
      // 
      this.changeCounterMenuItem.Image = global::ArmenDiplom.Properties.Resources.SCDRESNS;
      this.changeCounterMenuItem.Name = "changeCounterMenuItem";
      this.changeCounterMenuItem.Size = new System.Drawing.Size(214, 22);
      this.changeCounterMenuItem.Text = "Корректировка";
      this.changeCounterMenuItem.Click += new System.EventHandler(this.changeCounterMenuItem_Click);
      // 
      // deleteCounterMenuItem
      // 
      this.deleteCounterMenuItem.Image = global::ArmenDiplom.Properties.Resources.delete_16x16;
      this.deleteCounterMenuItem.Name = "deleteCounterMenuItem";
      this.deleteCounterMenuItem.Size = new System.Drawing.Size(214, 22);
      this.deleteCounterMenuItem.Text = "Удаление";
      this.deleteCounterMenuItem.Click += new System.EventHandler(this.deleteCounterMenuItem_Click);
      // 
      // inputMenuItem
      // 
      this.inputMenuItem.Image = global::ArmenDiplom.Properties.Resources.RCArrow_16x16;
      this.inputMenuItem.Name = "inputMenuItem";
      this.inputMenuItem.Size = new System.Drawing.Size(155, 22);
      this.inputMenuItem.Text = "Ввод данных";
      this.inputMenuItem.Click += new System.EventHandler(this.zagruzkaMenuItem_Click);
      // 
      // reportToolStripMenuItem
      // 
      this.reportToolStripMenuItem.Image = global::ArmenDiplom.Properties.Resources.DATABASE;
      this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
      this.reportToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
      this.reportToolStripMenuItem.Text = "Отчеты";
      // 
      // helpMenuItem
      // 
      this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationMenuItem,
            this.aboutMenuItem});
      this.helpMenuItem.Image = global::ArmenDiplom.Properties.Resources.Help_16x16;
      this.helpMenuItem.Name = "helpMenuItem";
      this.helpMenuItem.Size = new System.Drawing.Size(110, 22);
      this.helpMenuItem.Text = "Помощь";
      // 
      // documentationMenuItem
      // 
      this.documentationMenuItem.Image = global::ArmenDiplom.Properties.Resources.DRAG2PG;
      this.documentationMenuItem.Name = "documentationMenuItem";
      this.documentationMenuItem.Size = new System.Drawing.Size(206, 22);
      this.documentationMenuItem.Text = "Документация";
      // 
      // aboutMenuItem
      // 
      this.aboutMenuItem.Image = global::ArmenDiplom.Properties.Resources.forSkype;
      this.aboutMenuItem.Name = "aboutMenuItem";
      this.aboutMenuItem.Size = new System.Drawing.Size(206, 22);
      this.aboutMenuItem.Text = "О программе";
      this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(891, 816);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ООО \"Электросети\"";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem shkafMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newShkafMenuItem;
    private System.Windows.Forms.ToolStripMenuItem updateShkafMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteShkafMenuItem;
    private System.Windows.Forms.ToolStripMenuItem poiskMenuItem;
    private System.Windows.Forms.ToolStripMenuItem obshieMenuItem;
    private System.Windows.Forms.ToolStripMenuItem schetchikiMenuItem;
    private System.Windows.Forms.ToolStripMenuItem inputMenuItem;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newCounterMenuItem;
    private System.Windows.Forms.ToolStripMenuItem changeCounterMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteCounterMenuItem;
    private System.Windows.Forms.ToolStripMenuItem documentationMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
  }
}

