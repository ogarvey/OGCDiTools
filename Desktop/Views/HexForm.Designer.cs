namespace Desktop.Views
{
  partial class HexForm
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
      lblFilename = new Label();
      lblFileSize = new Label();
      dataGridView1 = new DataGridView();
      panel1 = new Panel();
      ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
      panel1.SuspendLayout();
      SuspendLayout();
      // 
      // lblFilename
      // 
      lblFilename.AutoSize = true;
      lblFilename.BackColor = SystemColors.ControlDark;
      lblFilename.Location = new Point(494, 18);
      lblFilename.Margin = new Padding(2, 0, 2, 0);
      lblFilename.Name = "lblFilename";
      lblFilename.Size = new Size(0, 20);
      lblFilename.TabIndex = 1;
      // 
      // lblFileSize
      // 
      lblFileSize.AutoSize = true;
      lblFileSize.Location = new Point(494, 46);
      lblFileSize.Margin = new Padding(2, 0, 2, 0);
      lblFileSize.Name = "lblFileSize";
      lblFileSize.Size = new Size(0, 20);
      lblFileSize.TabIndex = 2;
      // 
      // dataGridView1
      // 
      dataGridView1.AllowUserToAddRows = false;
      dataGridView1.AllowUserToDeleteRows = false;
      dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView1.Dock = DockStyle.Fill;
      dataGridView1.Location = new Point(0, 0);
      dataGridView1.Margin = new Padding(2, 2, 2, 2);
      dataGridView1.Name = "dataGridView1";
      dataGridView1.ReadOnly = true;
      dataGridView1.RowHeadersWidth = 62;
      dataGridView1.RowTemplate.Height = 33;
      dataGridView1.Size = new Size(1349, 1138);
      dataGridView1.TabIndex = 3;
      // 
      // panel1
      // 
      panel1.Controls.Add(dataGridView1);
      panel1.Dock = DockStyle.Left;
      panel1.Location = new Point(0, 0);
      panel1.Margin = new Padding(2, 2, 2, 2);
      panel1.Name = "panel1";
      panel1.Size = new Size(1349, 1138);
      panel1.TabIndex = 4;
      // 
      // HexForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoSizeMode = AutoSizeMode.GrowAndShrink;
      ClientSize = new Size(1890, 1138);
      Controls.Add(panel1);
      Controls.Add(lblFileSize);
      Controls.Add(lblFilename);
      Margin = new Padding(2, 2, 2, 2);
      Name = "HexForm";
      Text = "HexForm";
      Load += HexForm_Load;
      ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
      panel1.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private Label lblFilename;
    private Label lblFileSize;
    private DataGridView dataGridView1;
    private Panel panel1;
  }
}