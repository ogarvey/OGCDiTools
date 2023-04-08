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
      openFileDialog1 = new OpenFileDialog();
      folderBrowserDialog1 = new FolderBrowserDialog();
      clutPalettePanel = new Panel();
      potentialTileListView = new ListView();
      tileOutputPanel = new Panel();
      textBox1 = new TextBox();
      parseBytesBtn = new Button();
      dungeonTrackBar1 = new ReaLTaiizor.Controls.DungeonTrackBar();
      timer1 = new System.Windows.Forms.Timer(components);
      SuspendLayout();
      // 
      // openFileDialog1
      // 
      openFileDialog1.FileName = "openFileDialog1";
      // 
      // clutPalettePanel
      // 
      clutPalettePanel.Location = new Point(245, 2);
      clutPalettePanel.Margin = new Padding(2);
      clutPalettePanel.Name = "clutPalettePanel";
      clutPalettePanel.Size = new Size(240, 464);
      clutPalettePanel.TabIndex = 1;
      // 
      // potentialTileListView
      // 
      potentialTileListView.Activation = ItemActivation.OneClick;
      potentialTileListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      potentialTileListView.Location = new Point(489, 2);
      potentialTileListView.Margin = new Padding(2);
      potentialTileListView.Name = "potentialTileListView";
      potentialTileListView.Size = new Size(241, 1142);
      potentialTileListView.TabIndex = 2;
      potentialTileListView.UseCompatibleStateImageBehavior = false;
      potentialTileListView.ItemActivate += tileSelected;
      // 
      // tileOutputPanel
      // 
      tileOutputPanel.Location = new Point(857, 10);
      tileOutputPanel.Margin = new Padding(2);
      tileOutputPanel.Name = "tileOutputPanel";
      tileOutputPanel.Size = new Size(596, 547);
      tileOutputPanel.TabIndex = 3;
      // 
      // textBox1
      // 
      textBox1.Location = new Point(857, 577);
      textBox1.Margin = new Padding(2);
      textBox1.Multiline = true;
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(233, 194);
      textBox1.TabIndex = 4;
      // 
      // parseBytesBtn
      // 
      parseBytesBtn.Location = new Point(857, 784);
      parseBytesBtn.Margin = new Padding(2);
      parseBytesBtn.Name = "parseBytesBtn";
      parseBytesBtn.Size = new Size(106, 44);
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
      dungeonTrackBar1.Location = new Point(981, 1122);
      dungeonTrackBar1.Margin = new Padding(2);
      dungeonTrackBar1.Maximum = 10;
      dungeonTrackBar1.Minimum = 0;
      dungeonTrackBar1.MinimumSize = new Size(38, 18);
      dungeonTrackBar1.Name = "dungeonTrackBar1";
      dungeonTrackBar1.Size = new Size(652, 22);
      dungeonTrackBar1.TabIndex = 10;
      dungeonTrackBar1.Text = "dungeonTrackBar1";
      dungeonTrackBar1.ThumbBackColor = System.Drawing.Color.FromArgb(244, 244, 244);
      dungeonTrackBar1.ThumbBorderColor = System.Drawing.Color.FromArgb(180, 180, 180);
      dungeonTrackBar1.Value = 0;
      dungeonTrackBar1.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By1;
      dungeonTrackBar1.ValueToSet = 0F;
      // 
      // timer1
      // 
      timer1.Enabled = true;
      // 
      // BINForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoSize = true;
      ClientSize = new Size(2051, 1260);
      Controls.Add(dungeonTrackBar1);
      Controls.Add(parseBytesBtn);
      Controls.Add(textBox1);
      Controls.Add(tileOutputPanel);
      Controls.Add(potentialTileListView);
      Controls.Add(clutPalettePanel);
      IsMdiContainer = true;
      Margin = new Padding(3, 2, 3, 2);
      Name = "BINForm";
      Text = "BINForm";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private OpenFileDialog openFileDialog1;
    private FolderBrowserDialog folderBrowserDialog1;
    private Panel clutPalettePanel;
    private ListView potentialTileListView;
    private Panel tileOutputPanel;
    private TextBox textBox1;
    private Button parseBytesBtn;
    private PictureBox pictureBox1;
    private ReaLTaiizor.Controls.DungeonTrackBar dungeonTrackBar1;
    private System.Windows.Forms.Timer timer1;
  }
}