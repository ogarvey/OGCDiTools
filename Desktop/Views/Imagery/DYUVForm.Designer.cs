namespace Desktop.Views.Imagery
{
  partial class DYUVForm
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
      exportImageBtn = new ReaLTaiizor.Controls.SpaceButton();
      changeOffsetBtn = new ReaLTaiizor.Controls.SpaceButton();
      pictureBox1 = new PictureBox();
      spaceForm1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
      splitContainer1.Panel1.SuspendLayout();
      splitContainer1.Panel2.SuspendLayout();
      splitContainer1.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // spaceForm1
      // 
      spaceForm1.AutoScroll = true;
      spaceForm1.BackColor = System.Drawing.Color.FromArgb(42, 42, 42);
      spaceForm1.BorderStyle = FormBorderStyle.None;
      spaceForm1.Controls.Add(splitContainer1);
      spaceForm1.Customization = "Kioq/yAgIP8qKir/Kioq/xwcHP/+/v7/Kysr/xkZGf8=";
      spaceForm1.Dock = DockStyle.Fill;
      spaceForm1.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      spaceForm1.Image = null;
      spaceForm1.Location = new System.Drawing.Point(0, 0);
      spaceForm1.MinimumSize = new System.Drawing.Size(200, 25);
      spaceForm1.Movable = true;
      spaceForm1.Name = "spaceForm1";
      spaceForm1.NoRounding = false;
      spaceForm1.Padding = new Padding(5, 25, 5, 5);
      spaceForm1.Sizable = true;
      spaceForm1.Size = new System.Drawing.Size(1381, 821);
      spaceForm1.SmartBounds = true;
      spaceForm1.StartPosition = FormStartPosition.WindowsDefaultLocation;
      spaceForm1.TabIndex = 0;
      spaceForm1.TransparencyKey = System.Drawing.Color.Purple;
      spaceForm1.Transparent = false;
      // 
      // splitContainer1
      // 
      splitContainer1.Dock = DockStyle.Fill;
      splitContainer1.FixedPanel = FixedPanel.Panel1;
      splitContainer1.Location = new System.Drawing.Point(5, 25);
      splitContainer1.Name = "splitContainer1";
      splitContainer1.Orientation = Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
      // 
      // splitContainer1.Panel2
      // 
      splitContainer1.Panel2.Controls.Add(pictureBox1);
      splitContainer1.Size = new System.Drawing.Size(1371, 791);
      splitContainer1.SplitterDistance = 80;
      splitContainer1.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 2;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.Controls.Add(exportImageBtn, 1, 0);
      tableLayoutPanel1.Controls.Add(changeOffsetBtn, 0, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.Size = new System.Drawing.Size(1371, 80);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // exportImageBtn
      // 
      exportImageBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      exportImageBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      exportImageBtn.Image = null;
      exportImageBtn.Location = new System.Drawing.Point(688, 3);
      exportImageBtn.Name = "exportImageBtn";
      exportImageBtn.NoRounding = false;
      exportImageBtn.Size = new System.Drawing.Size(180, 60);
      exportImageBtn.TabIndex = 1;
      exportImageBtn.Text = "Export Image";
      exportImageBtn.TextAlignment = HorizontalAlignment.Center;
      exportImageBtn.Transparent = false;
      exportImageBtn.Click += exportImageBtn_Click;
      // 
      // changeOffsetBtn
      // 
      changeOffsetBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      changeOffsetBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      changeOffsetBtn.Image = null;
      changeOffsetBtn.Location = new System.Drawing.Point(3, 3);
      changeOffsetBtn.Name = "changeOffsetBtn";
      changeOffsetBtn.NoRounding = false;
      changeOffsetBtn.Size = new System.Drawing.Size(180, 60);
      changeOffsetBtn.TabIndex = 0;
      changeOffsetBtn.Text = "Change Offset";
      changeOffsetBtn.TextAlignment = HorizontalAlignment.Center;
      changeOffsetBtn.Transparent = false;
      // 
      // pictureBox1
      // 
      pictureBox1.Dock = DockStyle.Fill;
      pictureBox1.InitialImage = null;
      pictureBox1.Location = new System.Drawing.Point(0, 0);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new System.Drawing.Size(1371, 707);
      pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
      pictureBox1.TabIndex = 0;
      pictureBox1.TabStop = false;
      // 
      // DYUVForm
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(1381, 821);
      Controls.Add(spaceForm1);
      FormBorderStyle = FormBorderStyle.None;
      Name = "DYUVForm";
      Text = "DYUVForm";
      TransparencyKey = System.Drawing.Color.Purple;
      spaceForm1.ResumeLayout(false);
      splitContainer1.Panel1.ResumeLayout(false);
      splitContainer1.Panel2.ResumeLayout(false);
      splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
      splitContainer1.ResumeLayout(false);
      tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private ReaLTaiizor.Forms.SpaceForm spaceForm1;
    private SplitContainer splitContainer1;
    private TableLayoutPanel tableLayoutPanel1;
    private ReaLTaiizor.Controls.SpaceButton exportImageBtn;
    private ReaLTaiizor.Controls.SpaceButton changeOffsetBtn;
    private PictureBox pictureBox1;
  }
}