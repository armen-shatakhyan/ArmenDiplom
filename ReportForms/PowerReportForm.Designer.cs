namespace ArmenDiplom
{
  partial class PowerReportForm
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
      this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
      this.powerReport1 = new ArmenDiplom.Reports.PowerReport();
      this.SuspendLayout();
      // 
      // crystalReportViewer1
      // 
      this.crystalReportViewer1.ActiveViewIndex = -1;
      this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
      this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(5);
      this.crystalReportViewer1.Name = "crystalReportViewer1";
      this.crystalReportViewer1.SelectionFormula = "";
      this.crystalReportViewer1.Size = new System.Drawing.Size(959, 663);
      this.crystalReportViewer1.TabIndex = 0;
      this.crystalReportViewer1.ViewTimeSelectionFormula = "";
      // 
      // PowerReportForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(959, 663);
      this.Controls.Add(this.crystalReportViewer1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "PowerReportForm";
      this.Text = "Отчет о модулях с Разряженной батарейкой";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PowerReportForm_FormClosed);
      this.ResumeLayout(false);

    }

    #endregion

    private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    private ArmenDiplom.Reports.PowerReport powerReport1;
  }
}