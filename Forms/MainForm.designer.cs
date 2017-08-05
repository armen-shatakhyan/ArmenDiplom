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
      this.components = new System.ComponentModel.Container();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.shkafMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newShkafMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.updateShkafMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteShkafMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.schetchikiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newCounterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.changeCounterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteCounterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.poiskMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.powerSearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.accessSearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.informationSearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.countersSearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.counterInformationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.inputMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fileInsertMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.accessInsertMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.documentationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shkafMenuItem,
            this.schetchikiMenuItem,
            this.poiskMenuItem,
            this.inputMenuItem,
            this.helpMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
      this.menuStrip1.Size = new System.Drawing.Size(1014, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // shkafMenuItem
      // 
      this.shkafMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newShkafMenuItem,
            this.updateShkafMenuItem,
            this.deleteShkafMenuItem});
      this.shkafMenuItem.Image = global::ArmenDiplom.Properties.Resources.LOGGER;
      this.shkafMenuItem.Name = "shkafMenuItem";
      this.shkafMenuItem.Size = new System.Drawing.Size(104, 22);
      this.shkafMenuItem.Text = "Модули";
      // 
      // newShkafMenuItem
      // 
      this.newShkafMenuItem.Image = global::ArmenDiplom.Properties.Resources.NOTE11;
      this.newShkafMenuItem.Name = "newShkafMenuItem";
      this.newShkafMenuItem.Size = new System.Drawing.Size(230, 22);
      this.newShkafMenuItem.Text = "Создание";
      this.newShkafMenuItem.Click += new System.EventHandler(this.newShkafMenuItem_Click);
      // 
      // updateShkafMenuItem
      // 
      this.updateShkafMenuItem.Image = global::ArmenDiplom.Properties.Resources.SCDRESNS;
      this.updateShkafMenuItem.Name = "updateShkafMenuItem";
      this.updateShkafMenuItem.Size = new System.Drawing.Size(230, 22);
      this.updateShkafMenuItem.Text = "Корректировка";
      this.updateShkafMenuItem.Click += new System.EventHandler(this.updateShkafMenuItem_Click);
      // 
      // deleteShkafMenuItem
      // 
      this.deleteShkafMenuItem.Image = global::ArmenDiplom.Properties.Resources.delete_16x16;
      this.deleteShkafMenuItem.Name = "deleteShkafMenuItem";
      this.deleteShkafMenuItem.Size = new System.Drawing.Size(230, 22);
      this.deleteShkafMenuItem.Text = "Удаление";
      this.deleteShkafMenuItem.Click += new System.EventHandler(this.deleteShkafMenuItem_Click);
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
      this.newCounterMenuItem.Size = new System.Drawing.Size(230, 22);
      this.newCounterMenuItem.Text = "Создание";
      this.newCounterMenuItem.Click += new System.EventHandler(this.newCounterMenuItem_Click);
      // 
      // changeCounterMenuItem
      // 
      this.changeCounterMenuItem.Image = global::ArmenDiplom.Properties.Resources.SCDRESNS;
      this.changeCounterMenuItem.Name = "changeCounterMenuItem";
      this.changeCounterMenuItem.Size = new System.Drawing.Size(230, 22);
      this.changeCounterMenuItem.Text = "Корректировка";
      this.changeCounterMenuItem.Click += new System.EventHandler(this.changeCounterMenuItem_Click);
      // 
      // deleteCounterMenuItem
      // 
      this.deleteCounterMenuItem.Image = global::ArmenDiplom.Properties.Resources.delete_16x16;
      this.deleteCounterMenuItem.Name = "deleteCounterMenuItem";
      this.deleteCounterMenuItem.Size = new System.Drawing.Size(230, 22);
      this.deleteCounterMenuItem.Text = "Удаление";
      this.deleteCounterMenuItem.Click += new System.EventHandler(this.deleteCounterMenuItem_Click);
      // 
      // poiskMenuItem
      // 
      this.poiskMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerSearchMenuItem,
            this.accessSearchMenuItem,
            this.informationSearchMenuItem,
            this.countersSearchMenuItem,
            this.counterInformationMenuItem});
      this.poiskMenuItem.Image = global::ArmenDiplom.Properties.Resources.EXPLORER;
      this.poiskMenuItem.Name = "poiskMenuItem";
      this.poiskMenuItem.Size = new System.Drawing.Size(167, 22);
      this.poiskMenuItem.Text = "Поиск/Отчеты";
      // 
      // powerSearchMenuItem
      // 
      this.powerSearchMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.powerSearchMenuItem.Name = "powerSearchMenuItem";
      this.powerSearchMenuItem.Size = new System.Drawing.Size(428, 22);
      this.powerSearchMenuItem.Text = "модулей с разряженными батарейками";
      this.powerSearchMenuItem.Click += new System.EventHandler(this.powerSearchMenuItem_Click);
      // 
      // accessSearchMenuItem
      // 
      this.accessSearchMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.accessSearchMenuItem.Name = "accessSearchMenuItem";
      this.accessSearchMenuItem.Size = new System.Drawing.Size(428, 22);
      this.accessSearchMenuItem.Text = "модулей с несанкционированным доступом";
      this.accessSearchMenuItem.Click += new System.EventHandler(this.accessSearchMenuItem_Click);
      // 
      // informationSearchMenuItem
      // 
      this.informationSearchMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.informationSearchMenuItem.Name = "informationSearchMenuItem";
      this.informationSearchMenuItem.Size = new System.Drawing.Size(428, 22);
      this.informationSearchMenuItem.Text = "модулей с непредоставленной информацией";
      this.informationSearchMenuItem.Click += new System.EventHandler(this.informationSearchMenuItem_Click);
      // 
      // countersSearchMenuItem
      // 
      this.countersSearchMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.countersSearchMenuItem.Name = "countersSearchMenuItem";
      this.countersSearchMenuItem.Size = new System.Drawing.Size(428, 22);
      this.countersSearchMenuItem.Text = "счетчиков с истекщим сроком поверки";
      this.countersSearchMenuItem.Click += new System.EventHandler(this.countersSearchMenuItem_Click);
      // 
      // counterInformationMenuItem
      // 
      this.counterInformationMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.counterInformationMenuItem.Name = "counterInformationMenuItem";
      this.counterInformationMenuItem.Size = new System.Drawing.Size(428, 22);
      this.counterInformationMenuItem.Text = "информации о счетчике";
      this.counterInformationMenuItem.Click += new System.EventHandler(this.counterInformationMenuItem_Click);
      // 
      // inputMenuItem
      // 
      this.inputMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileInsertMenuItem,
            this.accessInsertMenuItem});
      this.inputMenuItem.Image = global::ArmenDiplom.Properties.Resources.RCArrow_16x16;
      this.inputMenuItem.Name = "inputMenuItem";
      this.inputMenuItem.Size = new System.Drawing.Size(155, 22);
      this.inputMenuItem.Text = "Ввод данных";
      // 
      // fileInsertMenuItem
      // 
      this.fileInsertMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.fileInsertMenuItem.Name = "fileInsertMenuItem";
      this.fileInsertMenuItem.Size = new System.Drawing.Size(380, 22);
      this.fileInsertMenuItem.Text = "Ввод файлов";
      this.fileInsertMenuItem.Click += new System.EventHandler(this.fileInsertMenuItem_Click);
      // 
      // accessInsertMenuItem
      // 
      this.accessInsertMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.accessInsertMenuItem.Name = "accessInsertMenuItem";
      this.accessInsertMenuItem.Size = new System.Drawing.Size(380, 22);
      this.accessInsertMenuItem.Text = "Ввод несанкционированных доступов";
      this.accessInsertMenuItem.Click += new System.EventHandler(this.accessInsertMenuItem_Click);
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
      this.documentationMenuItem.Size = new System.Drawing.Size(222, 22);
      this.documentationMenuItem.Text = "Документация";
      this.documentationMenuItem.Click += new System.EventHandler(this.documentationMenuItem_Click);
      // 
      // aboutMenuItem
      // 
      this.aboutMenuItem.Image = global::ArmenDiplom.Properties.Resources.forSkype;
      this.aboutMenuItem.Name = "aboutMenuItem";
      this.aboutMenuItem.Size = new System.Drawing.Size(222, 22);
      this.aboutMenuItem.Text = "О программе";
      this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
      this.notifyIcon1.Text = "Yeah Baby";
      this.notifyIcon1.Visible = true;
      this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1014, 859);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ООО \"Электросети\"";
      this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.contextMenuStrip1.ResumeLayout(false);
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
    private System.Windows.Forms.ToolStripMenuItem schetchikiMenuItem;
    private System.Windows.Forms.ToolStripMenuItem inputMenuItem;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newCounterMenuItem;
    private System.Windows.Forms.ToolStripMenuItem changeCounterMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteCounterMenuItem;
    private System.Windows.Forms.ToolStripMenuItem documentationMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fileInsertMenuItem;
    private System.Windows.Forms.ToolStripMenuItem accessInsertMenuItem;
    private System.Windows.Forms.ToolStripMenuItem powerSearchMenuItem;
    private System.Windows.Forms.ToolStripMenuItem accessSearchMenuItem;
    private System.Windows.Forms.ToolStripMenuItem informationSearchMenuItem;
    private System.Windows.Forms.ToolStripMenuItem countersSearchMenuItem;
    private System.Windows.Forms.ToolStripMenuItem counterInformationMenuItem;
    private System.Windows.Forms.NotifyIcon notifyIcon1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
  }
}

