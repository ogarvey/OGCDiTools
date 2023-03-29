using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace Desktop.Views
{
  partial class RTFForm
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
      openFileDialog1 = new OpenFileDialog();
      folderBrowserDialog1 = new FolderBrowserDialog();
      button1 = new Button();
      button2 = new Button();
      hexButton = new Button();
      groupBox1 = new GroupBox();
      lblDataSectors = new Label();
      lblAudioSectors = new Label();
      lblVideoSectors = new Label();
      lblTotalRecords = new Label();
      lblTotalSectors = new Label();
      groupBox1.SuspendLayout();
      SuspendLayout();
      // 
      // openFileDialog1
      // 
      openFileDialog1.FileName = "openFileDialog1";
      // 
      // button1
      // 
      button1.Location = new Point(12, 12);
      button1.Name = "button1";
      button1.Size = new Size(213, 61);
      button1.TabIndex = 0;
      button1.Text = "Load RTF File";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // button2
      // 
      button2.Location = new Point(12, 79);
      button2.Name = "button2";
      button2.Size = new Size(213, 61);
      button2.TabIndex = 1;
      button2.Text = "Load RTF Folder";
      button2.UseVisualStyleBackColor = true;
      button2.Click += button2_Click;
      // 
      // hexButton
      // 
      hexButton.Location = new Point(12, 146);
      hexButton.Name = "hexButton";
      hexButton.Size = new Size(213, 61);
      hexButton.TabIndex = 2;
      hexButton.Text = "Show Hex View";
      hexButton.UseVisualStyleBackColor = true;
      hexButton.Click += hexButton_Click;
      // 
      // groupBox1
      // 
      groupBox1.Controls.Add(lblDataSectors);
      groupBox1.Controls.Add(lblAudioSectors);
      groupBox1.Controls.Add(lblVideoSectors);
      groupBox1.Controls.Add(lblTotalRecords);
      groupBox1.Controls.Add(lblTotalSectors);
      groupBox1.Location = new Point(11, 228);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(214, 482);
      groupBox1.TabIndex = 3;
      groupBox1.TabStop = false;
      groupBox1.Text = "groupBox1";
      // 
      // lblDataSectors
      // 
      lblDataSectors.AutoSize = true;
      lblDataSectors.Location = new Point(8, 110);
      lblDataSectors.Name = "lblDataSectors";
      lblDataSectors.Size = new Size(96, 20);
      lblDataSectors.TabIndex = 4;
      lblDataSectors.Text = "Data Sectors:";
      // 
      // lblAudioSectors
      // 
      lblAudioSectors.AutoSize = true;
      lblAudioSectors.Location = new Point(8, 90);
      lblAudioSectors.Name = "lblAudioSectors";
      lblAudioSectors.Size = new Size(104, 20);
      lblAudioSectors.TabIndex = 3;
      lblAudioSectors.Text = "Audio Sectors:";
      // 
      // lblVideoSectors
      // 
      lblVideoSectors.AutoSize = true;
      lblVideoSectors.Location = new Point(8, 70);
      lblVideoSectors.Name = "lblVideoSectors";
      lblVideoSectors.Size = new Size(103, 20);
      lblVideoSectors.TabIndex = 2;
      lblVideoSectors.Text = "Video Sectors:";
      // 
      // lblTotalRecords
      // 
      lblTotalRecords.AutoSize = true;
      lblTotalRecords.Location = new Point(8, 50);
      lblTotalRecords.Name = "lblTotalRecords";
      lblTotalRecords.Size = new Size(106, 20);
      lblTotalRecords.TabIndex = 1;
      lblTotalRecords.Text = "Total Records: ";
      // 
      // lblTotalSectors
      // 
      lblTotalSectors.AutoSize = true;
      lblTotalSectors.Location = new Point(8, 30);
      lblTotalSectors.Name = "lblTotalSectors";
      lblTotalSectors.Size = new Size(97, 20);
      lblTotalSectors.TabIndex = 0;
      lblTotalSectors.Text = "Total Sectors:";
      // 
      // RTFForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1535, 718);
      Controls.Add(groupBox1);
      Controls.Add(hexButton);
      Controls.Add(button2);
      Controls.Add(button1);
      Name = "RTFForm";
      Text = "RTFForm";
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private OpenFileDialog openFileDialog1;
    private FolderBrowserDialog folderBrowserDialog1;
    private Button button1;
    private Button button2;
    private Button hexButton;
    private GroupBox groupBox1;
    private Label lblDataSectors;
    private Label lblAudioSectors;
    private Label lblVideoSectors;
    private Label lblTotalRecords;
    private Label lblTotalSectors;
  }
}