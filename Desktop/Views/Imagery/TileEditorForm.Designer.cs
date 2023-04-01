namespace Desktop.Views.Imagery
{
  partial class TileEditorForm
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
      screenTileListView = new ReaLTaiizor.Controls.MaterialListView();
      clutComboBox = new ReaLTaiizor.Controls.MaterialComboBox();
      tableLayoutPanel1 = new TableLayoutPanel();
      screenTileTabControl = new ReaLTaiizor.Controls.MaterialTabControl();
      screenTileTab = new TabPage();
      spriteTileTab = new TabPage();
      tableLayoutPanel2 = new TableLayoutPanel();
      materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
      tableLayoutPanel1.SuspendLayout();
      screenTileTabControl.SuspendLayout();
      screenTileTab.SuspendLayout();
      tableLayoutPanel2.SuspendLayout();
      SuspendLayout();
      // 
      // screenTileListView
      // 
      screenTileListView.AutoSizeTable = false;
      screenTileListView.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
      screenTileListView.BorderStyle = BorderStyle.None;
      screenTileListView.Depth = 0;
      screenTileListView.Dock = DockStyle.Fill;
      screenTileListView.FullRowSelect = true;
      screenTileListView.Location = new System.Drawing.Point(3, 3);
      screenTileListView.Margin = new Padding(6);
      screenTileListView.MinimumSize = new System.Drawing.Size(200, 100);
      screenTileListView.MouseLocation = new System.Drawing.Point(-1, -1);
      screenTileListView.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      screenTileListView.Name = "screenTileListView";
      screenTileListView.OwnerDraw = true;
      screenTileListView.Size = new System.Drawing.Size(419, 856);
      screenTileListView.TabIndex = 0;
      screenTileListView.UseCompatibleStateImageBehavior = false;
      screenTileListView.View = View.Details;
      // 
      // clutComboBox
      // 
      clutComboBox.AutoResize = false;
      clutComboBox.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
      clutComboBox.Depth = 0;
      clutComboBox.Dock = DockStyle.Fill;
      clutComboBox.DrawMode = DrawMode.OwnerDrawVariable;
      clutComboBox.DropDownHeight = 174;
      clutComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      clutComboBox.DropDownWidth = 121;
      clutComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
      clutComboBox.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
      clutComboBox.FormattingEnabled = true;
      clutComboBox.IntegralHeight = false;
      clutComboBox.ItemHeight = 43;
      clutComboBox.Location = new System.Drawing.Point(3, 79);
      clutComboBox.MaxDropDownItems = 4;
      clutComboBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      clutComboBox.Name = "clutComboBox";
      clutComboBox.Size = new System.Drawing.Size(427, 49);
      clutComboBox.StartIndex = 0;
      clutComboBox.TabIndex = 1;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 1;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Controls.Add(screenTileTabControl, 0, 1);
      tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
      tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 2;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
      tableLayoutPanel1.Size = new System.Drawing.Size(439, 1065);
      tableLayoutPanel1.TabIndex = 2;
      // 
      // screenTileTabControl
      // 
      screenTileTabControl.Controls.Add(screenTileTab);
      screenTileTabControl.Controls.Add(spriteTileTab);
      screenTileTabControl.Depth = 0;
      screenTileTabControl.Dock = DockStyle.Fill;
      screenTileTabControl.Location = new System.Drawing.Point(3, 162);
      screenTileTabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
      screenTileTabControl.Multiline = true;
      screenTileTabControl.Name = "screenTileTabControl";
      screenTileTabControl.SelectedIndex = 0;
      screenTileTabControl.Size = new System.Drawing.Size(433, 900);
      screenTileTabControl.TabIndex = 3;
      // 
      // screenTileTab
      // 
      screenTileTab.Controls.Add(screenTileListView);
      screenTileTab.Location = new System.Drawing.Point(4, 34);
      screenTileTab.Name = "screenTileTab";
      screenTileTab.Padding = new Padding(3);
      screenTileTab.Size = new System.Drawing.Size(425, 862);
      screenTileTab.TabIndex = 0;
      screenTileTab.Text = "Screen Tiles";
      screenTileTab.UseVisualStyleBackColor = true;
      // 
      // spriteTileTab
      // 
      spriteTileTab.Location = new System.Drawing.Point(4, 34);
      spriteTileTab.Name = "spriteTileTab";
      spriteTileTab.Padding = new Padding(3);
      spriteTileTab.Size = new System.Drawing.Size(425, 862);
      spriteTileTab.TabIndex = 1;
      spriteTileTab.Text = "Sprite Tiles";
      spriteTileTab.UseVisualStyleBackColor = true;
      // 
      // tableLayoutPanel2
      // 
      tableLayoutPanel2.ColumnCount = 1;
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.Controls.Add(clutComboBox, 0, 1);
      tableLayoutPanel2.Controls.Add(materialLabel1, 0, 0);
      tableLayoutPanel2.Dock = DockStyle.Fill;
      tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
      tableLayoutPanel2.Name = "tableLayoutPanel2";
      tableLayoutPanel2.RowCount = 2;
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.Size = new System.Drawing.Size(433, 153);
      tableLayoutPanel2.TabIndex = 0;
      // 
      // materialLabel1
      // 
      materialLabel1.AutoSize = true;
      materialLabel1.Depth = 0;
      materialLabel1.Dock = DockStyle.Fill;
      materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
      materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H3;
      materialLabel1.Location = new System.Drawing.Point(3, 0);
      materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
      materialLabel1.Name = "materialLabel1";
      materialLabel1.Size = new System.Drawing.Size(427, 76);
      materialLabel1.TabIndex = 2;
      materialLabel1.Text = "Clut Selector";
      materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // TileEditorForm
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(1997, 1089);
      Controls.Add(tableLayoutPanel1);
      Name = "TileEditorForm";
      Text = "TileEditorForm";
      tableLayoutPanel1.ResumeLayout(false);
      screenTileTabControl.ResumeLayout(false);
      screenTileTab.ResumeLayout(false);
      tableLayoutPanel2.ResumeLayout(false);
      tableLayoutPanel2.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private ReaLTaiizor.Controls.MaterialListView screenTileListView;
    private ReaLTaiizor.Controls.MaterialComboBox clutComboBox;
    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
    private ReaLTaiizor.Controls.MaterialTabControl screenTileTabControl;
    private TabPage screenTileTab;
    private TabPage spriteTileTab;
  }
}