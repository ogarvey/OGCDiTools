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
      loadBinBtn = new ReaLTaiizor.Controls.SpaceButton();
      extractUsingDbBtn = new ReaLTaiizor.Controls.SpaceButton();
      folderBrowserDialog1 = new FolderBrowserDialog();
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
      mainDataNightForm.Margin = new Padding(3, 2, 3, 2);
      mainDataNightForm.MinimumSize = new System.Drawing.Size(175, 19);
      mainDataNightForm.Movable = true;
      mainDataNightForm.Name = "mainDataNightForm";
      mainDataNightForm.NoRounding = false;
      mainDataNightForm.Padding = new Padding(4, 19, 4, 4);
      mainDataNightForm.Sizable = true;
      mainDataNightForm.Size = new System.Drawing.Size(1408, 734);
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
      splitContainer1.Location = new System.Drawing.Point(4, 19);
      splitContainer1.Margin = new Padding(3, 2, 3, 2);
      splitContainer1.Name = "splitContainer1";
      splitContainer1.Orientation = Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
      splitContainer1.Size = new System.Drawing.Size(1400, 711);
      splitContainer1.SplitterDistance = 56;
      splitContainer1.SplitterWidth = 3;
      splitContainer1.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 3;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel1.Controls.Add(loadRTFBtn, 0, 0);
      tableLayoutPanel1.Controls.Add(loadBinBtn, 1, 0);
      tableLayoutPanel1.Controls.Add(extractUsingDbBtn, 2, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Size = new System.Drawing.Size(1400, 56);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // loadRTFBtn
      // 
      loadRTFBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      loadRTFBtn.Dock = DockStyle.Fill;
      loadRTFBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      loadRTFBtn.Image = null;
      loadRTFBtn.Location = new System.Drawing.Point(3, 2);
      loadRTFBtn.Margin = new Padding(3, 2, 3, 2);
      loadRTFBtn.Name = "loadRTFBtn";
      loadRTFBtn.NoRounding = false;
      loadRTFBtn.Size = new System.Drawing.Size(460, 52);
      loadRTFBtn.TabIndex = 0;
      loadRTFBtn.Text = "Load RTF File";
      loadRTFBtn.TextAlignment = HorizontalAlignment.Center;
      loadRTFBtn.Transparent = false;
      loadRTFBtn.Click += loadRTFBtn_Click;
      // 
      // loadBinBtn
      // 
      loadBinBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      loadBinBtn.Dock = DockStyle.Fill;
      loadBinBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      loadBinBtn.Image = null;
      loadBinBtn.Location = new System.Drawing.Point(469, 2);
      loadBinBtn.Margin = new Padding(3, 2, 3, 2);
      loadBinBtn.Name = "loadBinBtn";
      loadBinBtn.NoRounding = false;
      loadBinBtn.Size = new System.Drawing.Size(460, 52);
      loadBinBtn.TabIndex = 1;
      loadBinBtn.Text = "Load BIN File";
      loadBinBtn.TextAlignment = HorizontalAlignment.Center;
      loadBinBtn.Transparent = false;
      loadBinBtn.Click += loadBinForm_Click;
      // 
      // extractUsingDbBtn
      // 
      extractUsingDbBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      extractUsingDbBtn.Dock = DockStyle.Fill;
      extractUsingDbBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      extractUsingDbBtn.Image = null;
      extractUsingDbBtn.Location = new System.Drawing.Point(935, 2);
      extractUsingDbBtn.Margin = new Padding(3, 2, 3, 2);
      extractUsingDbBtn.Name = "extractUsingDbBtn";
      extractUsingDbBtn.NoRounding = false;
      extractUsingDbBtn.Size = new System.Drawing.Size(462, 52);
      extractUsingDbBtn.TabIndex = 2;
      extractUsingDbBtn.Text = "Extract Using Config DB";
      extractUsingDbBtn.TextAlignment = HorizontalAlignment.Center;
      extractUsingDbBtn.Transparent = false;
      extractUsingDbBtn.Click += extractUsingDbBtn_Click;
      // 
      // MainDataForm
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoScroll = true;
      ClientSize = new System.Drawing.Size(1408, 734);
      Controls.Add(mainDataNightForm);
      FormBorderStyle = FormBorderStyle.None;
      Margin = new Padding(3, 2, 3, 2);
      MinimumSize = new System.Drawing.Size(175, 19);
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
    private ReaLTaiizor.Controls.SpaceButton loadBinBtn;
    private ReaLTaiizor.Controls.SpaceButton extractUsingDbBtn;
    private FolderBrowserDialog folderBrowserDialog1;
  }
}