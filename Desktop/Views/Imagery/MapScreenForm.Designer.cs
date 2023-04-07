using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace Desktop.Views
{
  partial class MapScreenForm
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
      panel1 = new Panel();
      tableLayoutPanel1 = new TableLayoutPanel();
      tableLayoutPanel2 = new TableLayoutPanel();
      exportAllBtn = new Button();
      createScreenBtn = new Button();
      exportScreenBtn = new Button();
      tableLayoutPanel1.SuspendLayout();
      tableLayoutPanel2.SuspendLayout();
      SuspendLayout();
      // 
      // panel1
      // 
      panel1.BackgroundImageLayout = ImageLayout.Stretch;
      panel1.Dock = DockStyle.Fill;
      panel1.Location = new Point(246, 2);
      panel1.Margin = new Padding(2);
      panel1.Name = "panel1";
      panel1.Size = new Size(1221, 816);
      panel1.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 2;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3333359F));
      tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
      tableLayoutPanel1.Controls.Add(panel1, 1, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new Point(0, 0);
      tableLayoutPanel1.Margin = new Padding(2);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Size = new Size(1469, 820);
      tableLayoutPanel1.TabIndex = 1;
      // 
      // tableLayoutPanel2
      // 
      tableLayoutPanel2.ColumnCount = 1;
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      tableLayoutPanel2.Controls.Add(exportAllBtn, 0, 2);
      tableLayoutPanel2.Controls.Add(createScreenBtn, 0, 1);
      tableLayoutPanel2.Controls.Add(exportScreenBtn, 0, 0);
      tableLayoutPanel2.Dock = DockStyle.Fill;
      tableLayoutPanel2.Location = new Point(2, 2);
      tableLayoutPanel2.Margin = new Padding(2);
      tableLayoutPanel2.Name = "tableLayoutPanel2";
      tableLayoutPanel2.RowCount = 4;
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0626545F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0626583F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0626583F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 24.8120327F));
      tableLayoutPanel2.Size = new Size(240, 816);
      tableLayoutPanel2.TabIndex = 1;
      // 
      // exportAllBtn
      // 
      exportAllBtn.Location = new Point(2, 410);
      exportAllBtn.Margin = new Padding(2);
      exportAllBtn.Name = "exportAllBtn";
      exportAllBtn.Size = new Size(192, 54);
      exportAllBtn.TabIndex = 3;
      exportAllBtn.Text = "Export All Maps";
      exportAllBtn.UseVisualStyleBackColor = true;
      exportAllBtn.Click += exportAllBtn_Click;
      // 
      // createScreenBtn
      // 
      createScreenBtn.Location = new Point(2, 206);
      createScreenBtn.Margin = new Padding(2);
      createScreenBtn.Name = "createScreenBtn";
      createScreenBtn.Size = new Size(192, 63);
      createScreenBtn.TabIndex = 1;
      createScreenBtn.Text = "Create Screen";
      createScreenBtn.UseVisualStyleBackColor = true;
      createScreenBtn.Click += createScreenBtn_Click;
      // 
      // exportScreenBtn
      // 
      exportScreenBtn.Location = new Point(2, 2);
      exportScreenBtn.Margin = new Padding(2);
      exportScreenBtn.Name = "exportScreenBtn";
      exportScreenBtn.Size = new Size(192, 68);
      exportScreenBtn.TabIndex = 2;
      exportScreenBtn.Text = "Export Screen";
      exportScreenBtn.UseVisualStyleBackColor = true;
      exportScreenBtn.Click += exportScreenBtn_Click;
      // 
      // MapScreenForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1469, 820);
      Controls.Add(tableLayoutPanel1);
      Margin = new Padding(2);
      Name = "MapScreenForm";
      Text = "MapScreenForm";
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel2.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private TableLayoutPanel tableLayoutPanel1;
    private Button createScreenBtn;
    private TableLayoutPanel tableLayoutPanel2;
    private Button exportScreenBtn;
    private Button exportAllBtn;
  }
}