namespace Desktop.Views
{
  partial class StreamingDyuvForm
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
      tableLayoutPanel1 = new TableLayoutPanel();
      streamFileBtn = new Button();
      pictureBox1 = new PictureBox();
      tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 2;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
      tableLayoutPanel1.Controls.Add(streamFileBtn, 0, 0);
      tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Size = new System.Drawing.Size(1487, 910);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // streamFileBtn
      // 
      streamFileBtn.Location = new System.Drawing.Point(3, 3);
      streamFileBtn.Name = "streamFileBtn";
      streamFileBtn.Size = new System.Drawing.Size(113, 69);
      streamFileBtn.TabIndex = 0;
      streamFileBtn.Text = "Stream File";
      streamFileBtn.UseVisualStyleBackColor = true;
      streamFileBtn.Click += streamFileBtn_Click;
      // 
      // pictureBox1
      // 
      pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
      pictureBox1.Dock = DockStyle.Fill;
      pictureBox1.Location = new System.Drawing.Point(151, 3);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new System.Drawing.Size(1333, 904);
      pictureBox1.TabIndex = 1;
      pictureBox1.TabStop = false;
      // 
      // StreamingDyuvForm
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(1487, 910);
      Controls.Add(tableLayoutPanel1);
      Name = "StreamingDyuvForm";
      Text = "StreamingDyuvForm";
      tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Button streamFileBtn;
    private PictureBox pictureBox1;
  }
}