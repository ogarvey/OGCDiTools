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
      spaceForm1 = new ReaLTaiizor.Forms.SpaceForm();
      splitContainer1 = new SplitContainer();
      nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
      tableLayoutPanel1 = new TableLayoutPanel();
      loadAudioFileBtn = new ReaLTaiizor.Controls.SpaceButton();
      playMonoBtn = new ReaLTaiizor.Controls.SpaceButton();
      playStereoBtn = new ReaLTaiizor.Controls.SpaceButton();
      trackBar1 = new ReaLTaiizor.Controls.TrackBar();
      spaceLabel1 = new ReaLTaiizor.Controls.SpaceLabel();
      spaceForm1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
      splitContainer1.Panel1.SuspendLayout();
      splitContainer1.Panel2.SuspendLayout();
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
      spaceForm1.Location = new System.Drawing.Point(0, 0);
      spaceForm1.MinimumSize = new System.Drawing.Size(200, 25);
      spaceForm1.Movable = true;
      spaceForm1.Name = "spaceForm1";
      spaceForm1.NoRounding = false;
      spaceForm1.Padding = new Padding(5, 25, 5, 5);
      spaceForm1.Sizable = true;
      spaceForm1.Size = new System.Drawing.Size(800, 450);
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
      splitContainer1.Location = new System.Drawing.Point(5, 25);
      splitContainer1.Name = "splitContainer1";
      splitContainer1.Orientation = Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      splitContainer1.Panel1.Controls.Add(nightPanel1);
      // 
      // splitContainer1.Panel2
      // 
      splitContainer1.Panel2.Controls.Add(spaceLabel1);
      splitContainer1.Panel2.Controls.Add(trackBar1);
      splitContainer1.Size = new System.Drawing.Size(790, 420);
      splitContainer1.TabIndex = 0;
      // 
      // nightPanel1
      // 
      nightPanel1.Controls.Add(tableLayoutPanel1);
      nightPanel1.Dock = DockStyle.Fill;
      nightPanel1.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
      nightPanel1.LeftSideColor = System.Drawing.Color.FromArgb(242, 93, 89);
      nightPanel1.Location = new System.Drawing.Point(0, 0);
      nightPanel1.Name = "nightPanel1";
      nightPanel1.RightSideColor = System.Drawing.Color.FromArgb(41, 44, 61);
      nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
      nightPanel1.Size = new System.Drawing.Size(790, 50);
      nightPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 3;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel1.Controls.Add(loadAudioFileBtn, 0, 0);
      tableLayoutPanel1.Controls.Add(playMonoBtn, 1, 0);
      tableLayoutPanel1.Controls.Add(playStereoBtn, 2, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
      tableLayoutPanel1.Size = new System.Drawing.Size(790, 50);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // loadAudioFileBtn
      // 
      loadAudioFileBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      loadAudioFileBtn.Dock = DockStyle.Fill;
      loadAudioFileBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      loadAudioFileBtn.Image = null;
      loadAudioFileBtn.Location = new System.Drawing.Point(10, 10);
      loadAudioFileBtn.Margin = new Padding(10);
      loadAudioFileBtn.Name = "loadAudioFileBtn";
      loadAudioFileBtn.NoRounding = false;
      loadAudioFileBtn.Size = new System.Drawing.Size(243, 30);
      loadAudioFileBtn.TabIndex = 0;
      loadAudioFileBtn.Text = "Load Audio File";
      loadAudioFileBtn.TextAlignment = HorizontalAlignment.Center;
      loadAudioFileBtn.Transparent = false;
      // 
      // playMonoBtn
      // 
      playMonoBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      playMonoBtn.Dock = DockStyle.Fill;
      playMonoBtn.Enabled = false;
      playMonoBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      playMonoBtn.Image = null;
      playMonoBtn.Location = new System.Drawing.Point(273, 10);
      playMonoBtn.Margin = new Padding(10);
      playMonoBtn.Name = "playMonoBtn";
      playMonoBtn.NoRounding = false;
      playMonoBtn.Size = new System.Drawing.Size(243, 30);
      playMonoBtn.TabIndex = 1;
      playMonoBtn.Text = "Play Mono";
      playMonoBtn.TextAlignment = HorizontalAlignment.Center;
      playMonoBtn.Transparent = false;
      // 
      // playStereoBtn
      // 
      playStereoBtn.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
      playStereoBtn.Dock = DockStyle.Fill;
      playStereoBtn.Enabled = false;
      playStereoBtn.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      playStereoBtn.Image = null;
      playStereoBtn.Location = new System.Drawing.Point(536, 10);
      playStereoBtn.Margin = new Padding(10);
      playStereoBtn.Name = "playStereoBtn";
      playStereoBtn.NoRounding = false;
      playStereoBtn.Size = new System.Drawing.Size(244, 30);
      playStereoBtn.TabIndex = 2;
      playStereoBtn.Text = "Play Stereo";
      playStereoBtn.TextAlignment = HorizontalAlignment.Center;
      playStereoBtn.Transparent = false;
      // 
      // trackBar1
      // 
      trackBar1.JumpToMouse = false;
      trackBar1.Location = new System.Drawing.Point(10, 38);
      trackBar1.Maximum = 10;
      trackBar1.Minimum = 0;
      trackBar1.MinimumSize = new System.Drawing.Size(47, 22);
      trackBar1.Name = "trackBar1";
      trackBar1.Size = new System.Drawing.Size(770, 22);
      trackBar1.TabIndex = 0;
      trackBar1.Text = "trackBar1";
      trackBar1.Value = 0;
      trackBar1.ValueDivison = ReaLTaiizor.Controls.TrackBar.ValueDivisor.By1;
      trackBar1.ValueToSet = 0F;
      // 
      // spaceLabel1
      // 
      spaceLabel1.Customization = "/v7+/yoqKv8=";
      spaceLabel1.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      spaceLabel1.Image = null;
      spaceLabel1.Location = new System.Drawing.Point(10, 3);
      spaceLabel1.Name = "spaceLabel1";
      spaceLabel1.NoRounding = false;
      spaceLabel1.Size = new System.Drawing.Size(94, 33);
      spaceLabel1.TabIndex = 1;
      spaceLabel1.Text = "spaceLabel1";
      spaceLabel1.TextAlignment = HorizontalAlignment.Center;
      spaceLabel1.Transparent = false;
      // 
      // AudioPlayerForm
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(800, 450);
      Controls.Add(spaceForm1);
      FormBorderStyle = FormBorderStyle.None;
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
      ResumeLayout(false);
    }

    #endregion

    private ReaLTaiizor.Forms.SpaceForm spaceForm1;
    private SplitContainer splitContainer1;
    private ReaLTaiizor.Controls.NightPanel nightPanel1;
    private TableLayoutPanel tableLayoutPanel1;
    private ReaLTaiizor.Controls.SpaceButton loadAudioFileBtn;
    private ReaLTaiizor.Controls.SpaceButton playMonoBtn;
    private ReaLTaiizor.Controls.SpaceButton playStereoBtn;
    private ReaLTaiizor.Controls.SpaceLabel spaceLabel1;
    private ReaLTaiizor.Controls.TrackBar trackBar1;
  }
}