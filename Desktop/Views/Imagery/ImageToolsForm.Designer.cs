namespace Desktop.Views.Imagery
{
  partial class ImageToolsForm
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
      spaceForm1 = new ReaLTaiizor.Forms.SpaceForm();
      splitContainer1 = new SplitContainer();
      tableLayoutPanel1 = new TableLayoutPanel();
      tilePlaygroundBtn = new ReaLTaiizor.Controls.SpaceButton();
      parseDyuvBtn = new ReaLTaiizor.Controls.SpaceButton();
      loadImageBtn = new ReaLTaiizor.Controls.SpaceButton();
      screenImageBtn = new ReaLTaiizor.Controls.SpaceButton();
      openFileDialog1 = new OpenFileDialog();
      spaceForm1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
      splitContainer1.Panel1.SuspendLayout();
      splitContainer1.SuspendLayout();
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
      spaceForm1.Location = new System.Drawing.Point(0, 0);
      spaceForm1.Margin = new Padding(2);
      spaceForm1.MinimumSize = new System.Drawing.Size(140, 15);
      spaceForm1.Movable = true;
      spaceForm1.Name = "spaceForm1";
      spaceForm1.NoRounding = false;
      spaceForm1.Padding = new Padding(4, 15, 4, 3);
      spaceForm1.Sizable = true;
      spaceForm1.Size = new System.Drawing.Size(776, 270);
      spaceForm1.SmartBounds = true;
      spaceForm1.StartPosition = FormStartPosition.WindowsDefaultLocation;
      spaceForm1.TabIndex = 0;
      spaceForm1.Text = "Image Tools";
      spaceForm1.TransparencyKey = System.Drawing.Color.Purple;
      spaceForm1.Transparent = false;
      // 
      // splitContainer1
      // 
      splitContainer1.Dock = DockStyle.Fill;
      splitContainer1.Location = new System.Drawing.Point(4, 15);
      splitContainer1.Margin = new Padding(2);
      splitContainer1.Name = "splitContainer1";
      splitContainer1.Orientation = Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
      splitContainer1.Size = new System.Drawing.Size(768, 252);
      splitContainer1.SplitterDistance = 45;
      splitContainer1.SplitterWidth = 2;
      splitContainer1.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 4;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006218F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9981251F));
      tableLayoutPanel1.Controls.Add(tilePlaygroundBtn, 0, 0);
      tableLayoutPanel1.Controls.Add(parseDyuvBtn, 1, 0);
      tableLayoutPanel1.Controls.Add(loadImageBtn, 0, 0);
      tableLayoutPanel1.Controls.Add(screenImageBtn, 2, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      tableLayoutPanel1.Margin = new Padding(2);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Size = new System.Drawing.Size(768, 45);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // tilePlaygroundBtn
      // 
      tilePlaygroundBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      tilePlaygroundBtn.Dock = DockStyle.Fill;
      tilePlaygroundBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      tilePlaygroundBtn.Image = null;
      tilePlaygroundBtn.Location = new System.Drawing.Point(199, 6);
      tilePlaygroundBtn.Margin = new Padding(7, 6, 7, 6);
      tilePlaygroundBtn.Name = "tilePlaygroundBtn";
      tilePlaygroundBtn.NoRounding = false;
      tilePlaygroundBtn.Size = new System.Drawing.Size(178, 33);
      tilePlaygroundBtn.TabIndex = 3;
      tilePlaygroundBtn.Text = "Tile Playground";
      tilePlaygroundBtn.TextAlignment = HorizontalAlignment.Center;
      tilePlaygroundBtn.Transparent = false;
      tilePlaygroundBtn.Click += tilePlaygroundBtn_Click;
      // 
      // parseDyuvBtn
      // 
      parseDyuvBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      parseDyuvBtn.Dock = DockStyle.Fill;
      parseDyuvBtn.Enabled = false;
      parseDyuvBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      parseDyuvBtn.Image = null;
      parseDyuvBtn.Location = new System.Drawing.Point(391, 6);
      parseDyuvBtn.Margin = new Padding(7, 6, 7, 6);
      parseDyuvBtn.Name = "parseDyuvBtn";
      parseDyuvBtn.NoRounding = false;
      parseDyuvBtn.Size = new System.Drawing.Size(178, 33);
      parseDyuvBtn.TabIndex = 2;
      parseDyuvBtn.Text = "DYUV Image";
      parseDyuvBtn.TextAlignment = HorizontalAlignment.Center;
      parseDyuvBtn.Transparent = false;
      parseDyuvBtn.Click += parseDyuvBtn_Click;
      // 
      // loadImageBtn
      // 
      loadImageBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      loadImageBtn.Dock = DockStyle.Fill;
      loadImageBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      loadImageBtn.Image = null;
      loadImageBtn.Location = new System.Drawing.Point(7, 6);
      loadImageBtn.Margin = new Padding(7, 6, 7, 6);
      loadImageBtn.Name = "loadImageBtn";
      loadImageBtn.NoRounding = false;
      loadImageBtn.Size = new System.Drawing.Size(178, 33);
      loadImageBtn.TabIndex = 1;
      loadImageBtn.Text = "Load Image File";
      loadImageBtn.TextAlignment = HorizontalAlignment.Center;
      loadImageBtn.Transparent = false;
      loadImageBtn.Click += loadImageBtn_Click;
      // 
      // screenImageBtn
      // 
      screenImageBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      screenImageBtn.Dock = DockStyle.Fill;
      screenImageBtn.Enabled = false;
      screenImageBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      screenImageBtn.Image = null;
      screenImageBtn.Location = new System.Drawing.Point(583, 6);
      screenImageBtn.Margin = new Padding(7, 6, 7, 6);
      screenImageBtn.Name = "screenImageBtn";
      screenImageBtn.NoRounding = false;
      screenImageBtn.Size = new System.Drawing.Size(178, 33);
      screenImageBtn.TabIndex = 0;
      screenImageBtn.Text = "Screen Image";
      screenImageBtn.TextAlignment = HorizontalAlignment.Center;
      screenImageBtn.Transparent = false;
      // 
      // openFileDialog1
      // 
      openFileDialog1.FileName = "openFileDialog1";
      // 
      // ImageToolsForm
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(776, 270);
      Controls.Add(spaceForm1);
      FormBorderStyle = FormBorderStyle.None;
      Margin = new Padding(2);
      MinimumSize = new System.Drawing.Size(140, 15);
      Name = "ImageToolsForm";
      Text = "ImageToolsForm";
      TransparencyKey = System.Drawing.Color.Purple;
      spaceForm1.ResumeLayout(false);
      splitContainer1.Panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
      splitContainer1.ResumeLayout(false);
      tableLayoutPanel1.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private ReaLTaiizor.Forms.SpaceForm spaceForm1;
    private SplitContainer splitContainer1;
    private TableLayoutPanel tableLayoutPanel1;
    private ReaLTaiizor.Controls.SpaceButton parseDyuvBtn;
    private ReaLTaiizor.Controls.SpaceButton loadImageBtn;
    private ReaLTaiizor.Controls.SpaceButton screenImageBtn;
    private OpenFileDialog openFileDialog1;
    private ReaLTaiizor.Controls.SpaceButton tilePlaygroundBtn;
  }
}