namespace Desktop.Views.Data
{
  partial class MainDataForm
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
      mainDataNightForm = new ReaLTaiizor.Forms.SpaceForm();
      splitContainer1 = new SplitContainer();
      tableLayoutPanel1 = new TableLayoutPanel();
      loadRTFBtn = new ReaLTaiizor.Controls.SpaceButton();
      spaceButton2 = new ReaLTaiizor.Controls.SpaceButton();
      spaceButton3 = new ReaLTaiizor.Controls.SpaceButton();
      mainDataNightForm.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
      splitContainer1.Panel1.SuspendLayout();
      splitContainer1.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // mainDataNightForm
      // 
      mainDataNightForm.BackColor = System.Drawing.Color.FromArgb(42, 42, 42);
      mainDataNightForm.BorderStyle = FormBorderStyle.None;
      mainDataNightForm.Controls.Add(splitContainer1);
      mainDataNightForm.Customization = "Kioq/yAgIP8qKir/Kioq/xwcHP/+/v7/Kysr/xkZGf8=";
      mainDataNightForm.Dock = DockStyle.Fill;
      mainDataNightForm.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      mainDataNightForm.Image = null;
      mainDataNightForm.Location = new System.Drawing.Point(0, 0);
      mainDataNightForm.MinimumSize = new System.Drawing.Size(200, 25);
      mainDataNightForm.Movable = true;
      mainDataNightForm.Name = "mainDataNightForm";
      mainDataNightForm.NoRounding = false;
      mainDataNightForm.Padding = new Padding(5, 25, 5, 5);
      mainDataNightForm.Sizable = true;
      mainDataNightForm.Size = new System.Drawing.Size(1609, 978);
      mainDataNightForm.SmartBounds = true;
      mainDataNightForm.StartPosition = FormStartPosition.CenterScreen;
      mainDataNightForm.TabIndex = 0;
      mainDataNightForm.Text = "Data Tools";
      mainDataNightForm.TransparencyKey = System.Drawing.Color.Purple;
      mainDataNightForm.Transparent = false;
      // 
      // splitContainer1
      // 
      splitContainer1.Dock = DockStyle.Fill;
      splitContainer1.Location = new System.Drawing.Point(5, 25);
      splitContainer1.Name = "splitContainer1";
      splitContainer1.Orientation = Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
      splitContainer1.Size = new System.Drawing.Size(1599, 948);
      splitContainer1.SplitterDistance = 75;
      splitContainer1.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 3;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel1.Controls.Add(loadRTFBtn, 0, 0);
      tableLayoutPanel1.Controls.Add(spaceButton2, 1, 0);
      tableLayoutPanel1.Controls.Add(spaceButton3, 2, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Size = new System.Drawing.Size(1599, 75);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // loadRTFBtn
      // 
      loadRTFBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      loadRTFBtn.Dock = DockStyle.Fill;
      loadRTFBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      loadRTFBtn.Image = null;
      loadRTFBtn.Location = new System.Drawing.Point(3, 3);
      loadRTFBtn.Name = "loadRTFBtn";
      loadRTFBtn.NoRounding = false;
      loadRTFBtn.Size = new System.Drawing.Size(526, 69);
      loadRTFBtn.TabIndex = 0;
      loadRTFBtn.Text = "Load RTF File";
      loadRTFBtn.TextAlignment = HorizontalAlignment.Center;
      loadRTFBtn.Transparent = false;
      loadRTFBtn.Click += loadRTFBtn_Click;
      // 
      // spaceButton2
      // 
      spaceButton2.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      spaceButton2.Dock = DockStyle.Fill;
      spaceButton2.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      spaceButton2.Image = null;
      spaceButton2.Location = new System.Drawing.Point(535, 3);
      spaceButton2.Name = "spaceButton2";
      spaceButton2.NoRounding = false;
      spaceButton2.Size = new System.Drawing.Size(526, 69);
      spaceButton2.TabIndex = 1;
      spaceButton2.Text = "Load BIN File";
      spaceButton2.TextAlignment = HorizontalAlignment.Center;
      spaceButton2.Transparent = false;
      // 
      // spaceButton3
      // 
      spaceButton3.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      spaceButton3.Dock = DockStyle.Fill;
      spaceButton3.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      spaceButton3.Image = null;
      spaceButton3.Location = new System.Drawing.Point(1067, 3);
      spaceButton3.Name = "spaceButton3";
      spaceButton3.NoRounding = false;
      spaceButton3.Size = new System.Drawing.Size(529, 69);
      spaceButton3.TabIndex = 2;
      spaceButton3.Text = "spaceButton3";
      spaceButton3.TextAlignment = HorizontalAlignment.Center;
      spaceButton3.Transparent = false;
      // 
      // MainDataForm
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoScroll = true;
      ClientSize = new System.Drawing.Size(1609, 978);
      Controls.Add(mainDataNightForm);
      FormBorderStyle = FormBorderStyle.None;
      MaximumSize = new System.Drawing.Size(2560, 1540);
      Name = "MainDataForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "MainDataForm";
      TransparencyKey = System.Drawing.Color.Purple;
      mainDataNightForm.ResumeLayout(false);
      splitContainer1.Panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
      splitContainer1.ResumeLayout(false);
      tableLayoutPanel1.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private ReaLTaiizor.Forms.SpaceForm mainDataNightForm;
    private SplitContainer splitContainer1;
    private TableLayoutPanel tableLayoutPanel1;
    private ReaLTaiizor.Controls.SpaceButton loadRTFBtn;
    private ReaLTaiizor.Controls.SpaceButton spaceButton2;
    private ReaLTaiizor.Controls.SpaceButton spaceButton3;
  }
}