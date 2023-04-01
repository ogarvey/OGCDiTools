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
      tableLayoutPanel1 = new TableLayoutPanel();
      previewAudioBtn = new Button();
      populateTileList = new Button();
      button1 = new Button();
      clutButton = new Button();
      exportTilesBtn = new Button();
      loadMapBtn = new Button();
      loadDYUVbtn = new Button();
      openFileDialog1 = new OpenFileDialog();
      folderBrowserDialog1 = new FolderBrowserDialog();
      clutPalettePanel = new Panel();
      potentialTileListView = new ListView();
      tileOutputPanel = new Panel();
      textBox1 = new TextBox();
      parseBytesBtn = new Button();
      pictureBox1 = new PictureBox();
      tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.AutoSize = true;
      tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      tableLayoutPanel1.ColumnCount = 1;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Controls.Add(previewAudioBtn, 0, 6);
      tableLayoutPanel1.Controls.Add(populateTileList, 0, 2);
      tableLayoutPanel1.Controls.Add(button1, 0, 0);
      tableLayoutPanel1.Controls.Add(clutButton, 0, 1);
      tableLayoutPanel1.Controls.Add(exportTilesBtn, 0, 3);
      tableLayoutPanel1.Controls.Add(loadMapBtn, 0, 4);
      tableLayoutPanel1.Controls.Add(loadDYUVbtn, 0, 5);
      tableLayoutPanel1.Dock = DockStyle.Left;
      tableLayoutPanel1.Location = new Point(0, 0);
      tableLayoutPanel1.Margin = new Padding(2);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 7;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28531F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2881641F));
      tableLayoutPanel1.Size = new Size(210, 1041);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // previewAudioBtn
      // 
      previewAudioBtn.Dock = DockStyle.Fill;
      previewAudioBtn.Location = new Point(3, 891);
      previewAudioBtn.Name = "previewAudioBtn";
      previewAudioBtn.Size = new Size(204, 147);
      previewAudioBtn.TabIndex = 7;
      previewAudioBtn.Text = "Preview Audio";
      previewAudioBtn.UseVisualStyleBackColor = true;
      previewAudioBtn.Click += previewAudioBtn_Click;
      // 
      // populateTileList
      // 
      populateTileList.Dock = DockStyle.Fill;
      populateTileList.Location = new Point(2, 298);
      populateTileList.Margin = new Padding(2);
      populateTileList.Name = "populateTileList";
      populateTileList.Size = new Size(206, 144);
      populateTileList.TabIndex = 3;
      populateTileList.Text = "Load Tiles";
      populateTileList.UseVisualStyleBackColor = true;
      populateTileList.Click += populateTileList_Click;
      // 
      // button1
      // 
      button1.Dock = DockStyle.Fill;
      button1.Location = new Point(2, 2);
      button1.Margin = new Padding(2);
      button1.Name = "button1";
      button1.Size = new Size(206, 144);
      button1.TabIndex = 1;
      button1.Text = "Load BIN File";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // clutButton
      // 
      clutButton.Dock = DockStyle.Fill;
      clutButton.Location = new Point(2, 150);
      clutButton.Margin = new Padding(2);
      clutButton.Name = "clutButton";
      clutButton.Size = new Size(206, 144);
      clutButton.TabIndex = 2;
      clutButton.Text = "Load CLUT Palette";
      clutButton.UseVisualStyleBackColor = true;
      clutButton.Click += clutButton_Click;
      // 
      // exportTilesBtn
      // 
      exportTilesBtn.Dock = DockStyle.Fill;
      exportTilesBtn.Location = new Point(2, 446);
      exportTilesBtn.Margin = new Padding(2);
      exportTilesBtn.Name = "exportTilesBtn";
      exportTilesBtn.Size = new Size(206, 144);
      exportTilesBtn.TabIndex = 4;
      exportTilesBtn.Text = "Export Tiles";
      exportTilesBtn.UseVisualStyleBackColor = true;
      exportTilesBtn.Click += exportTilesBtn_Click;
      // 
      // loadMapBtn
      // 
      loadMapBtn.Dock = DockStyle.Fill;
      loadMapBtn.Location = new Point(2, 594);
      loadMapBtn.Margin = new Padding(2);
      loadMapBtn.Name = "loadMapBtn";
      loadMapBtn.Size = new Size(206, 144);
      loadMapBtn.TabIndex = 5;
      loadMapBtn.Text = "Load Map Data";
      loadMapBtn.UseVisualStyleBackColor = true;
      loadMapBtn.Click += loadMapBtn_Click;
      // 
      // loadDYUVbtn
      // 
      loadDYUVbtn.Dock = DockStyle.Fill;
      loadDYUVbtn.Location = new Point(3, 743);
      loadDYUVbtn.Name = "loadDYUVbtn";
      loadDYUVbtn.Size = new Size(204, 142);
      loadDYUVbtn.TabIndex = 6;
      loadDYUVbtn.Text = "Load DYUV";
      loadDYUVbtn.UseVisualStyleBackColor = true;
      loadDYUVbtn.Click += loadDYUVbtn_Click;
      // 
      // openFileDialog1
      // 
      openFileDialog1.FileName = "openFileDialog1";
      // 
      // clutPalettePanel
      // 
      clutPalettePanel.Location = new Point(214, 2);
      clutPalettePanel.Margin = new Padding(2);
      clutPalettePanel.Name = "clutPalettePanel";
      clutPalettePanel.Size = new Size(210, 180);
      clutPalettePanel.TabIndex = 1;
      // 
      // potentialTileListView
      // 
      potentialTileListView.Activation = ItemActivation.OneClick;
      potentialTileListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      potentialTileListView.Location = new Point(428, 2);
      potentialTileListView.Margin = new Padding(2);
      potentialTileListView.Name = "potentialTileListView";
      potentialTileListView.Size = new Size(211, 857);
      potentialTileListView.TabIndex = 2;
      potentialTileListView.UseCompatibleStateImageBehavior = false;
      potentialTileListView.ItemActivate += tileSelected;
      // 
      // tileOutputPanel
      // 
      tileOutputPanel.Location = new Point(750, 7);
      tileOutputPanel.Margin = new Padding(2);
      tileOutputPanel.Name = "tileOutputPanel";
      tileOutputPanel.Size = new Size(210, 180);
      tileOutputPanel.TabIndex = 3;
      // 
      // textBox1
      // 
      textBox1.Location = new Point(752, 194);
      textBox1.Margin = new Padding(2);
      textBox1.Multiline = true;
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(204, 147);
      textBox1.TabIndex = 4;
      // 
      // parseBytesBtn
      // 
      parseBytesBtn.Location = new Point(752, 349);
      parseBytesBtn.Margin = new Padding(2);
      parseBytesBtn.Name = "parseBytesBtn";
      parseBytesBtn.Size = new Size(93, 33);
      parseBytesBtn.TabIndex = 5;
      parseBytesBtn.Text = "Parse Bytes";
      parseBytesBtn.UseVisualStyleBackColor = true;
      parseBytesBtn.Click += parseBytesBtn_Click;
      // 
      // pictureBox1
      // 
      pictureBox1.Anchor = AnchorStyles.None;
      pictureBox1.Location = new Point(1035, 7);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(857, 690);
      pictureBox1.TabIndex = 7;
      pictureBox1.TabStop = false;
      pictureBox1.Visible = false;
      // 
      // BINForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoSize = true;
      ClientSize = new Size(1904, 1041);
      Controls.Add(pictureBox1);
      Controls.Add(parseBytesBtn);
      Controls.Add(textBox1);
      Controls.Add(tileOutputPanel);
      Controls.Add(potentialTileListView);
      Controls.Add(clutPalettePanel);
      Controls.Add(tableLayoutPanel1);
      IsMdiContainer = true;
      Margin = new Padding(3, 2, 3, 2);
      Name = "BINForm";
      Text = "BINForm";
      tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
  }
}