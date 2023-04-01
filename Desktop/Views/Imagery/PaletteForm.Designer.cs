﻿namespace Desktop.Views.Imagery
{
  partial class PaletteForm
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
      tableLayoutPanel2 = new TableLayoutPanel();
      loadFileBtn = new Button();
      tableLayoutPanel1.SuspendLayout();
      tableLayoutPanel2.SuspendLayout();
      SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 2;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3864546F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.61355F));
      tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 2;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.Size = new System.Drawing.Size(1255, 768);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      tableLayoutPanel2.ColumnCount = 1;
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.Controls.Add(loadFileBtn, 0, 0);
      tableLayoutPanel2.Dock = DockStyle.Fill;
      tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
      tableLayoutPanel2.Name = "tableLayoutPanel2";
      tableLayoutPanel2.RowCount = 2;
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.Size = new System.Drawing.Size(162, 378);
      tableLayoutPanel2.TabIndex = 0;
      // 
      // loadFileBtn
      // 
      loadFileBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      loadFileBtn.Location = new System.Drawing.Point(25, 25);
      loadFileBtn.Margin = new Padding(25);
      loadFileBtn.Name = "loadFileBtn";
      loadFileBtn.Size = new System.Drawing.Size(112, 139);
      loadFileBtn.TabIndex = 0;
      loadFileBtn.Text = "Add Palette";
      loadFileBtn.UseVisualStyleBackColor = true;
      // 
      // PaletteForm
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(1255, 768);
      Controls.Add(tableLayoutPanel1);
      Name = "PaletteForm";
      Text = "PaletteForm";
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel2.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private Button loadFileBtn;
  }
}