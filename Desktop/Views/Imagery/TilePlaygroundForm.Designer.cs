namespace Desktop.Views.Imagery
{
  partial class TilePlaygroundForm
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
      clutComboBox = new ReaLTaiizor.Controls.MaterialComboBox();
      tableLayoutPanel1 = new TableLayoutPanel();
      tableLayoutPanel2 = new TableLayoutPanel();
      materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
      clutPalettePanel = new Panel();
      listView1 = new ListView();
      folderBrowserDialog1 = new FolderBrowserDialog();
      panel1 = new Panel();
      tableLayoutPanel1.SuspendLayout();
      tableLayoutPanel2.SuspendLayout();
      SuspendLayout();
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
      clutComboBox.Location = new System.Drawing.Point(2, 47);
      clutComboBox.Margin = new Padding(2);
      clutComboBox.MaxDropDownItems = 4;
      clutComboBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
      clutComboBox.Name = "clutComboBox";
      clutComboBox.Size = new System.Drawing.Size(371, 49);
      clutComboBox.StartIndex = 0;
      clutComboBox.TabIndex = 1;
      clutComboBox.SelectedIndexChanged += clutComboBox_SelectedIndexChanged;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 2;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
      tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
      tableLayoutPanel1.Controls.Add(clutPalettePanel, 1, 0);
      tableLayoutPanel1.Controls.Add(listView1, 0, 1);
      tableLayoutPanel1.Location = new System.Drawing.Point(8, 7);
      tableLayoutPanel1.Margin = new Padding(2);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 2;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
      tableLayoutPanel1.Size = new System.Drawing.Size(567, 639);
      tableLayoutPanel1.TabIndex = 2;
      // 
      // tableLayoutPanel2
      // 
      tableLayoutPanel2.ColumnCount = 1;
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.Controls.Add(clutComboBox, 0, 1);
      tableLayoutPanel2.Controls.Add(materialLabel1, 0, 0);
      tableLayoutPanel2.Dock = DockStyle.Fill;
      tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
      tableLayoutPanel2.Margin = new Padding(2);
      tableLayoutPanel2.Name = "tableLayoutPanel2";
      tableLayoutPanel2.RowCount = 2;
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.Size = new System.Drawing.Size(375, 91);
      tableLayoutPanel2.TabIndex = 0;
      // 
      // materialLabel1
      // 
      materialLabel1.AutoSize = true;
      materialLabel1.Depth = 0;
      materialLabel1.Dock = DockStyle.Fill;
      materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
      materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H3;
      materialLabel1.Location = new System.Drawing.Point(2, 0);
      materialLabel1.Margin = new Padding(2, 0, 2, 0);
      materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
      materialLabel1.Name = "materialLabel1";
      materialLabel1.Size = new System.Drawing.Size(371, 45);
      materialLabel1.TabIndex = 2;
      materialLabel1.Text = "Clut Selector";
      materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // clutPalettePanel
      // 
      clutPalettePanel.Dock = DockStyle.Fill;
      clutPalettePanel.Location = new System.Drawing.Point(381, 2);
      clutPalettePanel.Margin = new Padding(2);
      clutPalettePanel.Name = "clutPalettePanel";
      tableLayoutPanel1.SetRowSpan(clutPalettePanel, 2);
      clutPalettePanel.Size = new System.Drawing.Size(184, 635);
      clutPalettePanel.TabIndex = 4;
      // 
      // listView1
      // 
      listView1.Dock = DockStyle.Fill;
      listView1.FullRowSelect = true;
      listView1.GridLines = true;
      listView1.Location = new System.Drawing.Point(3, 98);
      listView1.MultiSelect = false;
      listView1.Name = "listView1";
      listView1.Size = new System.Drawing.Size(373, 538);
      listView1.TabIndex = 5;
      listView1.TileSize = new System.Drawing.Size(64, 64);
      listView1.UseCompatibleStateImageBehavior = false;
      listView1.View = View.List;
      listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
      // 
      // panel1
      // 
      panel1.AutoSize = true;
      panel1.Location = new System.Drawing.Point(581, 11);
      panel1.Name = "panel1";
      panel1.Size = new System.Drawing.Size(808, 636);
      panel1.TabIndex = 3;
      // 
      // TilePlaygroundForm
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(1398, 653);
      Controls.Add(panel1);
      Controls.Add(tableLayoutPanel1);
      Margin = new Padding(2);
      Name = "TilePlaygroundForm";
      Text = "TileEditorForm";
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel2.ResumeLayout(false);
      tableLayoutPanel2.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private ReaLTaiizor.Controls.MaterialComboBox clutComboBox;
    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
    private FolderBrowserDialog folderBrowserDialog1;
    private Panel clutPalettePanel;
    private ListView listView1;
    private Panel panel1;
  }
}