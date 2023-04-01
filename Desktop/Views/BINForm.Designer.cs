using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace Desktop.Views
{
  partial class BINForm
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
      tableLayoutPanel1 = new TableLayoutPanel();
      populateTileList = new Button();
      button1 = new Button();
      clutButton = new Button();
      exportTilesBtn = new Button();
      loadMapBtn = new Button();
      loadDYUVbtn = new Button();
      tableLayoutPanel2 = new TableLayoutPanel();
      previewAudioBtn = new Button();
      stopAudioBtn = new Button();
      openFileDialog1 = new OpenFileDialog();
      folderBrowserDialog1 = new FolderBrowserDialog();
      clutPalettePanel = new Panel();
      potentialTileListView = new ListView();
      tileOutputPanel = new Panel();
      textBox1 = new TextBox();
      parseBytesBtn = new Button();
      dungeonTrackBar1 = new ReaLTaiizor.Controls.DungeonTrackBar();
      timer1 = new System.Windows.Forms.Timer(components);
      tableLayoutPanel1.SuspendLayout();
      tableLayoutPanel2.SuspendLayout();
      SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.AutoSize = true;
      tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      tableLayoutPanel1.ColumnCount = 1;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Controls.Add(populateTileList, 0, 2);
      tableLayoutPanel1.Controls.Add(button1, 0, 0);
      tableLayoutPanel1.Controls.Add(clutButton, 0, 1);
      tableLayoutPanel1.Controls.Add(exportTilesBtn, 0, 3);
      tableLayoutPanel1.Controls.Add(loadMapBtn, 0, 4);
      tableLayoutPanel1.Controls.Add(loadDYUVbtn, 0, 5);
      tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 6);
      tableLayoutPanel1.Dock = DockStyle.Left;
      tableLayoutPanel1.Location = new Point(0, 0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 7;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28531F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2881641F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
      tableLayoutPanel1.Size = new Size(300, 1735);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // populateTileList
      // 
      populateTileList.Dock = DockStyle.Fill;
      populateTileList.Location = new Point(3, 497);
      populateTileList.Name = "populateTileList";
      populateTileList.Size = new Size(294, 241);
      populateTileList.TabIndex = 3;
      populateTileList.Text = "Load Tiles";
      populateTileList.UseVisualStyleBackColor = true;
      populateTileList.Click += populateTileList_Click;
      // 
      // button1
      // 
      button1.Dock = DockStyle.Fill;
      button1.Location = new Point(3, 3);
      button1.Name = "button1";
      button1.Size = new Size(294, 241);
      button1.TabIndex = 1;
      button1.Text = "Load BIN File";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // clutButton
      // 
      clutButton.Dock = DockStyle.Fill;
      clutButton.Location = new Point(3, 250);
      clutButton.Name = "clutButton";
      clutButton.Size = new Size(294, 241);
      clutButton.TabIndex = 2;
      clutButton.Text = "Load CLUT Palette";
      clutButton.UseVisualStyleBackColor = true;
      clutButton.Click += clutButton_Click;
      // 
      // exportTilesBtn
      // 
      exportTilesBtn.Dock = DockStyle.Fill;
      exportTilesBtn.Location = new Point(3, 744);
      exportTilesBtn.Name = "exportTilesBtn";
      exportTilesBtn.Size = new Size(294, 241);
      exportTilesBtn.TabIndex = 4;
      exportTilesBtn.Text = "Export Tiles";
      exportTilesBtn.UseVisualStyleBackColor = true;
      exportTilesBtn.Click += exportTilesBtn_Click;
      // 
      // loadMapBtn
      // 
      loadMapBtn.Dock = DockStyle.Fill;
      loadMapBtn.Location = new Point(3, 991);
      loadMapBtn.Name = "loadMapBtn";
      loadMapBtn.Size = new Size(294, 241);
      loadMapBtn.TabIndex = 5;
      loadMapBtn.Text = "Load Map Data";
      loadMapBtn.UseVisualStyleBackColor = true;
      loadMapBtn.Click += loadMapBtn_Click;
      // 
      // loadDYUVbtn
      // 
      loadDYUVbtn.Dock = DockStyle.Fill;
      loadDYUVbtn.Location = new Point(4, 1240);
      loadDYUVbtn.Margin = new Padding(4, 5, 4, 5);
      loadDYUVbtn.Name = "loadDYUVbtn";
      loadDYUVbtn.Size = new Size(292, 237);
      loadDYUVbtn.TabIndex = 6;
      loadDYUVbtn.Text = "Load DYUV";
      loadDYUVbtn.UseVisualStyleBackColor = true;
      loadDYUVbtn.Click += loadDYUVbtn_Click;
      // 
      // tableLayoutPanel2
      // 
      tableLayoutPanel2.ColumnCount = 2;
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
      tableLayoutPanel2.Controls.Add(previewAudioBtn, 0, 0);
      tableLayoutPanel2.Controls.Add(stopAudioBtn, 1, 0);
      tableLayoutPanel2.Dock = DockStyle.Fill;
      tableLayoutPanel2.Location = new Point(3, 1485);
      tableLayoutPanel2.Name = "tableLayoutPanel2";
      tableLayoutPanel2.RowCount = 1;
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel2.Size = new Size(294, 247);
      tableLayoutPanel2.TabIndex = 7;
      // 
      // previewAudioBtn
      // 
      previewAudioBtn.Dock = DockStyle.Fill;
      previewAudioBtn.Location = new Point(4, 5);
      previewAudioBtn.Margin = new Padding(4, 5, 4, 5);
      previewAudioBtn.Name = "previewAudioBtn";
      previewAudioBtn.Size = new Size(139, 237);
      previewAudioBtn.TabIndex = 7;
      previewAudioBtn.Text = "Preview Audio";
      previewAudioBtn.UseVisualStyleBackColor = true;
      previewAudioBtn.Click += previewAudioBtn_Click;
      // 
      // stopAudioBtn
      // 
      stopAudioBtn.Dock = DockStyle.Fill;
      stopAudioBtn.Location = new Point(150, 3);
      stopAudioBtn.Name = "stopAudioBtn";
      stopAudioBtn.Size = new Size(141, 241);
      stopAudioBtn.TabIndex = 8;
      stopAudioBtn.Text = "Stop Audio";
      stopAudioBtn.UseVisualStyleBackColor = true;
      stopAudioBtn.Click += stopAudioBtn_Click;
      // 
      // openFileDialog1
      // 
      openFileDialog1.FileName = "openFileDialog1";
      // 
      // clutPalettePanel
      // 
      clutPalettePanel.Location = new Point(306, 3);
      clutPalettePanel.Name = "clutPalettePanel";
      clutPalettePanel.Size = new Size(300, 580);
      clutPalettePanel.TabIndex = 1;
      // 
      // potentialTileListView
      // 
      potentialTileListView.Activation = ItemActivation.OneClick;
      potentialTileListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      potentialTileListView.Location = new Point(611, 3);
      potentialTileListView.Name = "potentialTileListView";
      potentialTileListView.Size = new Size(300, 1426);
      potentialTileListView.TabIndex = 2;
      potentialTileListView.UseCompatibleStateImageBehavior = false;
      potentialTileListView.ItemActivate += tileSelected;
      // 
      // tileOutputPanel
      // 
      tileOutputPanel.Location = new Point(1071, 12);
      tileOutputPanel.Name = "tileOutputPanel";
      tileOutputPanel.Size = new Size(745, 684);
      tileOutputPanel.TabIndex = 3;
      // 
      // textBox1
      // 
      textBox1.Location = new Point(1071, 721);
      textBox1.Multiline = true;
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(290, 242);
      textBox1.TabIndex = 4;
      // 
      // parseBytesBtn
      // 
      parseBytesBtn.Location = new Point(1071, 980);
      parseBytesBtn.Name = "parseBytesBtn";
      parseBytesBtn.Size = new Size(133, 55);
      parseBytesBtn.TabIndex = 5;
      parseBytesBtn.Text = "Parse Bytes";
      parseBytesBtn.UseVisualStyleBackColor = true;
      parseBytesBtn.Click += parseBytesBtn_Click;
      // 
      // dungeonTrackBar1
      // 
      dungeonTrackBar1.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
      dungeonTrackBar1.DrawValueString = false;
      dungeonTrackBar1.EmptyBackColor = System.Drawing.Color.FromArgb(221, 221, 221);
      dungeonTrackBar1.FillBackColor = System.Drawing.Color.FromArgb(217, 99, 50);
      dungeonTrackBar1.JumpToMouse = false;
      dungeonTrackBar1.Location = new Point(1302, 1310);
      dungeonTrackBar1.Maximum = 10;
      dungeonTrackBar1.Minimum = 0;
      dungeonTrackBar1.MinimumSize = new Size(47, 22);
      dungeonTrackBar1.Name = "dungeonTrackBar1";
      dungeonTrackBar1.Size = new Size(815, 22);
      dungeonTrackBar1.TabIndex = 10;
      dungeonTrackBar1.Text = "dungeonTrackBar1";
      dungeonTrackBar1.ThumbBackColor = System.Drawing.Color.FromArgb(244, 244, 244);
      dungeonTrackBar1.ThumbBorderColor = System.Drawing.Color.FromArgb(180, 180, 180);
      dungeonTrackBar1.Value = 0;
      dungeonTrackBar1.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By1;
      dungeonTrackBar1.ValueToSet = 0F;
      dungeonTrackBar1.ValueChanged += dungeonTrackBar1_ValueChanged;
      // 
      // timer1
      // 
      timer1.Enabled = true;
      timer1.Tick += timer_Tick;
      // 
      // BINForm
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoSize = true;
      ClientSize = new Size(2720, 1735);
      Controls.Add(dungeonTrackBar1);
      Controls.Add(parseBytesBtn);
      Controls.Add(textBox1);
      Controls.Add(tileOutputPanel);
      Controls.Add(potentialTileListView);
      Controls.Add(clutPalettePanel);
      Controls.Add(tableLayoutPanel1);
      IsMdiContainer = true;
      Margin = new Padding(4, 3, 4, 3);
      Name = "BINForm";
      Text = "BINForm";
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel2.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private OpenFileDialog openFileDialog1;
    private FolderBrowserDialog folderBrowserDialog1;
    private Button button1;
    private Button clutButton;
    private Panel clutPalettePanel;
    private ListView potentialTileListView;
    private Button populateTileList;
    private Panel tileOutputPanel;
    private Button exportTilesBtn;
    private TextBox textBox1;
    private Button parseBytesBtn;
    private Button loadMapBtn;
    private Button loadDYUVbtn;
    private PictureBox pictureBox1;
    private Button previewAudioBtn;
    private TableLayoutPanel tableLayoutPanel2;
    private Button stopAudioBtn;
    private ReaLTaiizor.Controls.DungeonTrackBar dungeonTrackBar1;
    private System.Windows.Forms.Timer timer1;
  }
}