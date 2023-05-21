using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace Desktop
{
  partial class MainWindow
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      spaceForm1 = new ReaLTaiizor.Forms.SpaceForm();
      splitContainer1 = new SplitContainer();
      nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
      tableLayoutPanel1 = new TableLayoutPanel();
      imgToolsBtn = new ReaLTaiizor.Controls.SpaceButton();
      exitBtn = new ReaLTaiizor.Controls.SpaceButton();
      dataToolsBtn = new ReaLTaiizor.Controls.SpaceButton();
      audioToolsBtn = new ReaLTaiizor.Controls.SpaceButton();
      spaceForm1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
      splitContainer1.Panel1.SuspendLayout();
      splitContainer1.SuspendLayout();
      nightPanel1.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // spaceForm1
      // 
      spaceForm1.BackColor = System.Drawing.Color.FromArgb(42, 42, 42);
      spaceForm1.BorderStyle = FormBorderStyle.None;
      spaceForm1.Controls.Add(splitContainer1);
      spaceForm1.Customization = "Kioq/yAgIP8qKir/Kioq/xwcHP/+/v7/Kysr/xkZGf8=";
      spaceForm1.Dock = DockStyle.Fill;
      spaceForm1.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      spaceForm1.Image = null;
      spaceForm1.Location = new Point(0, 0);
      spaceForm1.Margin = new Padding(4);
      spaceForm1.MinimumSize = new Size(250, 31);
      spaceForm1.Movable = true;
      spaceForm1.Name = "spaceForm1";
      spaceForm1.NoRounding = false;
      spaceForm1.Padding = new Padding(6, 31, 6, 6);
      spaceForm1.Sizable = true;
      spaceForm1.Size = new Size(2116, 1606);
      spaceForm1.SmartBounds = true;
      spaceForm1.StartPosition = FormStartPosition.CenterScreen;
      spaceForm1.TabIndex = 0;
      spaceForm1.Text = "OG CD-i Tools";
      spaceForm1.TransparencyKey = System.Drawing.Color.Purple;
      spaceForm1.Transparent = false;
      // 
      // splitContainer1
      // 
      splitContainer1.Dock = DockStyle.Fill;
      splitContainer1.Location = new Point(6, 31);
      splitContainer1.Margin = new Padding(4);
      splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      splitContainer1.Panel1.Controls.Add(nightPanel1);
      splitContainer1.Size = new Size(2104, 1569);
      splitContainer1.SplitterDistance = 516;
      splitContainer1.SplitterWidth = 5;
      splitContainer1.TabIndex = 0;
      // 
      // nightPanel1
      // 
      nightPanel1.AutoScroll = true;
      nightPanel1.Controls.Add(tableLayoutPanel1);
      nightPanel1.Dock = DockStyle.Fill;
      nightPanel1.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
      nightPanel1.LeftSideColor = System.Drawing.Color.FromArgb(242, 93, 89);
      nightPanel1.Location = new Point(0, 0);
      nightPanel1.Margin = new Padding(4);
      nightPanel1.Name = "nightPanel1";
      nightPanel1.RightSideColor = System.Drawing.Color.FromArgb(41, 44, 61);
      nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
      nightPanel1.Size = new Size(516, 1569);
      nightPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
      tableLayoutPanel1.ColumnCount = 1;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Controls.Add(imgToolsBtn, 0, 1);
      tableLayoutPanel1.Controls.Add(exitBtn, 0, 3);
      tableLayoutPanel1.Controls.Add(dataToolsBtn, 0, 0);
      tableLayoutPanel1.Controls.Add(audioToolsBtn, 0, 2);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new Point(0, 0);
      tableLayoutPanel1.Margin = new Padding(4);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 4;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33444F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33445F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33112F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
      tableLayoutPanel1.Size = new Size(516, 1569);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // imgToolsBtn
      // 
      imgToolsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      imgToolsBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      imgToolsBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      imgToolsBtn.Image = null;
      imgToolsBtn.Location = new Point(62, 700);
      imgToolsBtn.Margin = new Padding(62, 219, 62, 219);
      imgToolsBtn.Name = "imgToolsBtn";
      imgToolsBtn.NoRounding = false;
      imgToolsBtn.Size = new Size(392, 43);
      imgToolsBtn.TabIndex = 2;
      imgToolsBtn.Text = "Image Tools";
      imgToolsBtn.TextAlignment = HorizontalAlignment.Center;
      imgToolsBtn.Transparent = false;
      imgToolsBtn.Click += imageToolsBtn_Click;
      // 
      // exitBtn
      // 
      exitBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      exitBtn.Dock = DockStyle.Fill;
      exitBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      exitBtn.Image = null;
      exitBtn.Location = new Point(4, 1447);
      exitBtn.Margin = new Padding(4);
      exitBtn.Name = "exitBtn";
      exitBtn.NoRounding = false;
      exitBtn.Size = new Size(508, 118);
      exitBtn.TabIndex = 1;
      exitBtn.Text = "Quit";
      exitBtn.TextAlignment = HorizontalAlignment.Center;
      exitBtn.Transparent = false;
      exitBtn.Click += exitBtn_Click;
      // 
      // dataToolsBtn
      // 
      dataToolsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      dataToolsBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      dataToolsBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      dataToolsBtn.Image = null;
      dataToolsBtn.Location = new Point(62, 219);
      dataToolsBtn.Margin = new Padding(62, 219, 62, 219);
      dataToolsBtn.Name = "dataToolsBtn";
      dataToolsBtn.NoRounding = false;
      dataToolsBtn.Size = new Size(392, 43);
      dataToolsBtn.TabIndex = 0;
      dataToolsBtn.Text = "Data Tools";
      dataToolsBtn.TextAlignment = HorizontalAlignment.Center;
      dataToolsBtn.Transparent = false;
      dataToolsBtn.Click += spaceButton1_Click;
      // 
      // audioToolsBtn
      // 
      audioToolsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      audioToolsBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      audioToolsBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      audioToolsBtn.Image = null;
      audioToolsBtn.Location = new Point(62, 1181);
      audioToolsBtn.Margin = new Padding(62, 219, 62, 219);
      audioToolsBtn.Name = "audioToolsBtn";
      audioToolsBtn.NoRounding = false;
      audioToolsBtn.Size = new Size(392, 43);
      audioToolsBtn.TabIndex = 3;
      audioToolsBtn.Text = "Audio Tools";
      audioToolsBtn.TextAlignment = HorizontalAlignment.Center;
      audioToolsBtn.Transparent = false;
      audioToolsBtn.Click += audioToolsBtn_Click;
      // 
      // MainWindow
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(2116, 1606);
      Controls.Add(spaceForm1);
      FormBorderStyle = FormBorderStyle.None;
      Margin = new Padding(2);
      MinimumSize = new Size(250, 31);
      Name = "MainWindow";
      ShowIcon = false;
      StartPosition = FormStartPosition.CenterScreen;
      Text = "themeForm1";
      TransparencyKey = System.Drawing.Color.Purple;
      spaceForm1.ResumeLayout(false);
      splitContainer1.Panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
      splitContainer1.ResumeLayout(false);
      nightPanel1.ResumeLayout(false);
      tableLayoutPanel1.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private ReaLTaiizor.Forms.SpaceForm spaceForm1;
    private SplitContainer splitContainer1;
    private ReaLTaiizor.Controls.NightPanel nightPanel1;
    private TableLayoutPanel tableLayoutPanel1;
    private ReaLTaiizor.Controls.SpaceButton dataToolsBtn;
    private ReaLTaiizor.Controls.SpaceButton imgToolsBtn;
    private ReaLTaiizor.Controls.SpaceButton exitBtn;
    private ReaLTaiizor.Controls.SpaceButton audioToolsBtn;
  }
}