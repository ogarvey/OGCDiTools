namespace Desktop.Views.Audio
{
  partial class AudioPlayerForm
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
      components = new System.ComponentModel.Container();
      spaceForm1 = new ReaLTaiizor.Forms.SpaceForm();
      splitContainer1 = new SplitContainer();
      nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
      tableLayoutPanel1 = new TableLayoutPanel();
      loadAudioFileBtn = new ReaLTaiizor.Controls.SpaceButton();
      playMonoBtn = new ReaLTaiizor.Controls.SpaceButton();
      tableLayoutPanel2 = new TableLayoutPanel();
      groupBox1 = new GroupBox();
      isMonoStereoChkbox = new CheckBox();
      groupBox2 = new GroupBox();
      highFreqRadio = new RadioButton();
      lowFreqRadio = new RadioButton();
      groupBox3 = new GroupBox();
      eightBitsRadio = new RadioButton();
      fourBpsRadio = new RadioButton();
      spaceLabel1 = new ReaLTaiizor.Controls.SpaceLabel();
      trackBar1 = new ReaLTaiizor.Controls.TrackBar();
      openFileDialog1 = new OpenFileDialog();
      timer1 = new System.Windows.Forms.Timer(components);
      exportAudioBtn = new ReaLTaiizor.Controls.SpaceButton();
      spaceForm1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
      splitContainer1.Panel1.SuspendLayout();
      splitContainer1.Panel2.SuspendLayout();
      splitContainer1.SuspendLayout();
      nightPanel1.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      tableLayoutPanel2.SuspendLayout();
      groupBox1.SuspendLayout();
      groupBox2.SuspendLayout();
      groupBox3.SuspendLayout();
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
      spaceForm1.Margin = new Padding(4);
      spaceForm1.MinimumSize = new System.Drawing.Size(250, 31);
      spaceForm1.Movable = true;
      spaceForm1.Name = "spaceForm1";
      spaceForm1.NoRounding = false;
      spaceForm1.Padding = new Padding(6, 31, 6, 6);
      spaceForm1.Sizable = true;
      spaceForm1.Size = new System.Drawing.Size(1000, 562);
      spaceForm1.SmartBounds = true;
      spaceForm1.StartPosition = FormStartPosition.WindowsDefaultLocation;
      spaceForm1.TabIndex = 0;
      spaceForm1.Text = "Audio Tools";
      spaceForm1.TransparencyKey = System.Drawing.Color.Purple;
      spaceForm1.Transparent = false;
      // 
      // splitContainer1
      // 
      splitContainer1.Dock = DockStyle.Fill;
      splitContainer1.Location = new System.Drawing.Point(6, 31);
      splitContainer1.Margin = new Padding(4);
      splitContainer1.Name = "splitContainer1";
      splitContainer1.Orientation = Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      splitContainer1.Panel1.Controls.Add(nightPanel1);
      // 
      // splitContainer1.Panel2
      // 
      splitContainer1.Panel2.Controls.Add(exportAudioBtn);
      splitContainer1.Panel2.Controls.Add(spaceLabel1);
      splitContainer1.Panel2.Controls.Add(trackBar1);
      splitContainer1.Size = new System.Drawing.Size(988, 525);
      splitContainer1.SplitterDistance = 262;
      splitContainer1.SplitterWidth = 5;
      splitContainer1.TabIndex = 0;
      // 
      // nightPanel1
      // 
      nightPanel1.Controls.Add(tableLayoutPanel1);
      nightPanel1.Dock = DockStyle.Fill;
      nightPanel1.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
      nightPanel1.LeftSideColor = System.Drawing.Color.FromArgb(64, 64, 64);
      nightPanel1.Location = new System.Drawing.Point(0, 0);
      nightPanel1.Margin = new Padding(4);
      nightPanel1.Name = "nightPanel1";
      nightPanel1.RightSideColor = System.Drawing.Color.FromArgb(41, 44, 61);
      nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
      nightPanel1.Size = new System.Drawing.Size(988, 262);
      nightPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
      tableLayoutPanel1.ColumnCount = 3;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel1.Controls.Add(loadAudioFileBtn, 0, 0);
      tableLayoutPanel1.Controls.Add(playMonoBtn, 1, 0);
      tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      tableLayoutPanel1.Margin = new Padding(4);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 262F));
      tableLayoutPanel1.Size = new System.Drawing.Size(988, 262);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // loadAudioFileBtn
      // 
      loadAudioFileBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      loadAudioFileBtn.Dock = DockStyle.Top;
      loadAudioFileBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      loadAudioFileBtn.Image = null;
      loadAudioFileBtn.Location = new System.Drawing.Point(12, 12);
      loadAudioFileBtn.Margin = new Padding(12);
      loadAudioFileBtn.Name = "loadAudioFileBtn";
      loadAudioFileBtn.NoRounding = false;
      loadAudioFileBtn.Size = new System.Drawing.Size(305, 238);
      loadAudioFileBtn.TabIndex = 0;
      loadAudioFileBtn.Text = "Load Audio File";
      loadAudioFileBtn.TextAlignment = HorizontalAlignment.Center;
      loadAudioFileBtn.Transparent = false;
      loadAudioFileBtn.Click += loadAudioFileBtn_Click;
      // 
      // playMonoBtn
      // 
      playMonoBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      playMonoBtn.Dock = DockStyle.Fill;
      playMonoBtn.Enabled = false;
      playMonoBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      playMonoBtn.Image = null;
      playMonoBtn.Location = new System.Drawing.Point(341, 12);
      playMonoBtn.Margin = new Padding(12);
      playMonoBtn.Name = "playMonoBtn";
      playMonoBtn.NoRounding = false;
      playMonoBtn.Size = new System.Drawing.Size(305, 238);
      playMonoBtn.TabIndex = 1;
      playMonoBtn.Text = "Play Audio";
      playMonoBtn.TextAlignment = HorizontalAlignment.Center;
      playMonoBtn.Transparent = false;
      playMonoBtn.Click += playMonoBtn_Click;
      // 
      // tableLayoutPanel2
      // 
      tableLayoutPanel2.ColumnCount = 1;
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
      tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
      tableLayoutPanel2.Controls.Add(groupBox3, 0, 2);
      tableLayoutPanel2.Dock = DockStyle.Fill;
      tableLayoutPanel2.Location = new System.Drawing.Point(661, 3);
      tableLayoutPanel2.Name = "tableLayoutPanel2";
      tableLayoutPanel2.RowCount = 3;
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel2.Size = new System.Drawing.Size(324, 256);
      tableLayoutPanel2.TabIndex = 2;
      // 
      // groupBox1
      // 
      groupBox1.Controls.Add(isMonoStereoChkbox);
      groupBox1.Dock = DockStyle.Fill;
      groupBox1.Location = new System.Drawing.Point(3, 3);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new System.Drawing.Size(318, 79);
      groupBox1.TabIndex = 0;
      groupBox1.TabStop = false;
      groupBox1.Text = "Mono / Stereo";
      // 
      // isMonoStereoChkbox
      // 
      isMonoStereoChkbox.AutoSize = true;
      isMonoStereoChkbox.Location = new System.Drawing.Point(6, 37);
      isMonoStereoChkbox.Name = "isMonoStereoChkbox";
      isMonoStereoChkbox.Size = new System.Drawing.Size(109, 22);
      isMonoStereoChkbox.TabIndex = 0;
      isMonoStereoChkbox.Text = "Is Stereo";
      isMonoStereoChkbox.UseVisualStyleBackColor = true;
      isMonoStereoChkbox.CheckedChanged += isMonoStereoChkbox_CheckedChanged;
      // 
      // groupBox2
      // 
      groupBox2.Controls.Add(highFreqRadio);
      groupBox2.Controls.Add(lowFreqRadio);
      groupBox2.Dock = DockStyle.Fill;
      groupBox2.Location = new System.Drawing.Point(3, 88);
      groupBox2.Name = "groupBox2";
      groupBox2.Size = new System.Drawing.Size(318, 79);
      groupBox2.TabIndex = 1;
      groupBox2.TabStop = false;
      groupBox2.Text = "Frequency";
      // 
      // highFreqRadio
      // 
      highFreqRadio.AutoSize = true;
      highFreqRadio.Location = new System.Drawing.Point(171, 26);
      highFreqRadio.Name = "highFreqRadio";
      highFreqRadio.Size = new System.Drawing.Size(107, 22);
      highFreqRadio.TabIndex = 1;
      highFreqRadio.TabStop = true;
      highFreqRadio.Text = "37.8 KHz";
      highFreqRadio.UseVisualStyleBackColor = true;
      highFreqRadio.CheckedChanged += highFreqRadio_CheckedChanged;
      // 
      // lowFreqRadio
      // 
      lowFreqRadio.AutoSize = true;
      lowFreqRadio.Location = new System.Drawing.Point(6, 26);
      lowFreqRadio.Name = "lowFreqRadio";
      lowFreqRadio.Size = new System.Drawing.Size(107, 22);
      lowFreqRadio.TabIndex = 0;
      lowFreqRadio.TabStop = true;
      lowFreqRadio.Text = "18.9 KHz";
      lowFreqRadio.UseVisualStyleBackColor = true;
      lowFreqRadio.CheckedChanged += lowFreqRadio_CheckedChanged;
      // 
      // groupBox3
      // 
      groupBox3.Controls.Add(eightBitsRadio);
      groupBox3.Controls.Add(fourBpsRadio);
      groupBox3.Dock = DockStyle.Fill;
      groupBox3.Location = new System.Drawing.Point(3, 173);
      groupBox3.Name = "groupBox3";
      groupBox3.Size = new System.Drawing.Size(318, 80);
      groupBox3.TabIndex = 2;
      groupBox3.TabStop = false;
      groupBox3.Text = "Bits Per Sample";
      // 
      // eightBitsRadio
      // 
      eightBitsRadio.AutoSize = true;
      eightBitsRadio.Location = new System.Drawing.Point(171, 34);
      eightBitsRadio.Name = "eightBitsRadio";
      eightBitsRadio.Size = new System.Drawing.Size(80, 22);
      eightBitsRadio.TabIndex = 1;
      eightBitsRadio.TabStop = true;
      eightBitsRadio.Text = "8 bits";
      eightBitsRadio.UseVisualStyleBackColor = true;
      eightBitsRadio.CheckedChanged += eightBitsRadio_CheckedChanged;
      // 
      // fourBpsRadio
      // 
      fourBpsRadio.AutoSize = true;
      fourBpsRadio.Location = new System.Drawing.Point(15, 34);
      fourBpsRadio.Name = "fourBpsRadio";
      fourBpsRadio.Size = new System.Drawing.Size(81, 22);
      fourBpsRadio.TabIndex = 0;
      fourBpsRadio.TabStop = true;
      fourBpsRadio.Text = "4 Bits";
      fourBpsRadio.UseVisualStyleBackColor = true;
      fourBpsRadio.CheckedChanged += fourBpsRadio_CheckedChanged;
      // 
      // spaceLabel1
      // 
      spaceLabel1.Customization = "/v7+/yoqKv8=";
      spaceLabel1.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      spaceLabel1.Image = null;
      spaceLabel1.Location = new System.Drawing.Point(12, 4);
      spaceLabel1.Margin = new Padding(4);
      spaceLabel1.Name = "spaceLabel1";
      spaceLabel1.NoRounding = false;
      spaceLabel1.Size = new System.Drawing.Size(118, 41);
      spaceLabel1.TabIndex = 1;
      spaceLabel1.Text = "spaceLabel1";
      spaceLabel1.TextAlignment = HorizontalAlignment.Center;
      spaceLabel1.Transparent = false;
      // 
      // trackBar1
      // 
      trackBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      trackBar1.JumpToMouse = false;
      trackBar1.Location = new System.Drawing.Point(12, 48);
      trackBar1.Margin = new Padding(4);
      trackBar1.Maximum = 10;
      trackBar1.Minimum = 0;
      trackBar1.MinimumSize = new System.Drawing.Size(59, 28);
      trackBar1.Name = "trackBar1";
      trackBar1.Size = new System.Drawing.Size(962, 28);
      trackBar1.TabIndex = 0;
      trackBar1.Text = "trackBar1";
      trackBar1.Value = 0;
      trackBar1.ValueDivison = ReaLTaiizor.Controls.TrackBar.ValueDivisor.By1;
      trackBar1.ValueToSet = 0F;
      trackBar1.ValueChanged += trackBar1_ValueChanged;
      // 
      // openFileDialog1
      // 
      openFileDialog1.FileName = "openFileDialog1";
      // 
      // timer1
      // 
      timer1.Enabled = true;
      timer1.Interval = 1000;
      timer1.Tick += timer_Tick;
      // 
      // exportAudioBtn
      // 
      exportAudioBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      exportAudioBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      exportAudioBtn.Image = null;
      exportAudioBtn.Location = new System.Drawing.Point(12, 199);
      exportAudioBtn.Name = "exportAudioBtn";
      exportAudioBtn.NoRounding = false;
      exportAudioBtn.Size = new System.Drawing.Size(209, 53);
      exportAudioBtn.TabIndex = 2;
      exportAudioBtn.Text = "Export Audio";
      exportAudioBtn.TextAlignment = HorizontalAlignment.Center;
      exportAudioBtn.Transparent = false;
      exportAudioBtn.Click += exportAudioBtn_Click;
      // 
      // AudioPlayerForm
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(1000, 562);
      Controls.Add(spaceForm1);
      FormBorderStyle = FormBorderStyle.None;
      Margin = new Padding(4);
      MinimumSize = new System.Drawing.Size(250, 31);
      Name = "AudioPlayerForm";
      Text = "AudioPlayerForm";
      TransparencyKey = System.Drawing.Color.Purple;
      spaceForm1.ResumeLayout(false);
      splitContainer1.Panel1.ResumeLayout(false);
      splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
      splitContainer1.ResumeLayout(false);
      nightPanel1.ResumeLayout(false);
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel2.ResumeLayout(false);
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      groupBox2.ResumeLayout(false);
      groupBox2.PerformLayout();
      groupBox3.ResumeLayout(false);
      groupBox3.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private ReaLTaiizor.Forms.SpaceForm spaceForm1;
    private OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Timer timer1;
    private SplitContainer splitContainer1;
    private ReaLTaiizor.Controls.NightPanel nightPanel1;
    private TableLayoutPanel tableLayoutPanel1;
    private ReaLTaiizor.Controls.SpaceButton loadAudioFileBtn;
    private ReaLTaiizor.Controls.SpaceButton playMonoBtn;
    private ReaLTaiizor.Controls.SpaceLabel spaceLabel1;
    private ReaLTaiizor.Controls.TrackBar trackBar1;
    private TableLayoutPanel tableLayoutPanel2;
    private GroupBox groupBox1;
    private CheckBox isMonoStereoChkbox;
    private GroupBox groupBox2;
    private RadioButton highFreqRadio;
    private RadioButton lowFreqRadio;
    private GroupBox groupBox3;
    private RadioButton eightBitsRadio;
    private RadioButton fourBpsRadio;
    private ReaLTaiizor.Controls.SpaceButton exportAudioBtn;
  }
}