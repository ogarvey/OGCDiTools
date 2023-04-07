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
      spaceForm1 = new ReaLTaiizor.Forms.SpaceForm();
      tableLayoutPanel1 = new TableLayoutPanel();
      tableLayoutPanel2 = new TableLayoutPanel();
      spaceLabel1 = new ReaLTaiizor.Controls.SpaceLabel();
      spaceLabel2 = new ReaLTaiizor.Controls.SpaceLabel();
      spaceLabel3 = new ReaLTaiizor.Controls.SpaceLabel();
      spaceLabel4 = new ReaLTaiizor.Controls.SpaceLabel();
      spaceLabel5 = new ReaLTaiizor.Controls.SpaceLabel();
      spaceLabel6 = new ReaLTaiizor.Controls.SpaceLabel();
      totalSectorsLabel = new ReaLTaiizor.Controls.SpaceLabel();
      totalRecordsLabel = new ReaLTaiizor.Controls.SpaceLabel();
      totalVideoLabel = new ReaLTaiizor.Controls.SpaceLabel();
      totalMonoLabel = new ReaLTaiizor.Controls.SpaceLabel();
      totalStereoLabel = new ReaLTaiizor.Controls.SpaceLabel();
      totalDataLabel = new ReaLTaiizor.Controls.SpaceLabel();
      spaceForm1.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      tableLayoutPanel2.SuspendLayout();
      SuspendLayout();
      // 
      // openFileDialog1
      // 
      openFileDialog1.FileName = "openFileDialog1";
      // 
      // spaceForm1
      // 
      spaceForm1.BackColor = System.Drawing.Color.FromArgb(42, 42, 42);
      spaceForm1.BorderStyle = FormBorderStyle.None;
      spaceForm1.Controls.Add(tableLayoutPanel1);
      spaceForm1.Customization = "Kioq/yAgIP8qKir/Kioq/xwcHP/+/v7/Kysr/xkZGf8=";
      spaceForm1.Dock = DockStyle.Fill;
      spaceForm1.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
      spaceForm1.Image = null;
      spaceForm1.Location = new Point(0, 0);
      spaceForm1.MinimumSize = new Size(200, 25);
      spaceForm1.Movable = true;
      spaceForm1.Name = "spaceForm1";
      spaceForm1.NoRounding = false;
      spaceForm1.Padding = new Padding(5, 25, 5, 5);
      spaceForm1.Sizable = true;
      spaceForm1.Size = new Size(1535, 718);
      spaceForm1.SmartBounds = true;
      spaceForm1.StartPosition = FormStartPosition.WindowsDefaultLocation;
      spaceForm1.TabIndex = 0;
      spaceForm1.Text = "RTF Tools";
      spaceForm1.TransparencyKey = System.Drawing.Color.Purple;
      spaceForm1.Transparent = false;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 2;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.8160133F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.18399F));
      tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new Point(5, 25);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Size = new Size(1525, 688);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      tableLayoutPanel2.ColumnCount = 2;
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.14041F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.8595924F));
      tableLayoutPanel2.Controls.Add(spaceLabel1, 0, 0);
      tableLayoutPanel2.Controls.Add(spaceLabel2, 0, 1);
      tableLayoutPanel2.Controls.Add(spaceLabel3, 0, 2);
      tableLayoutPanel2.Controls.Add(spaceLabel4, 0, 3);
      tableLayoutPanel2.Controls.Add(spaceLabel5, 0, 4);
      tableLayoutPanel2.Controls.Add(spaceLabel6, 0, 5);
      tableLayoutPanel2.Controls.Add(totalSectorsLabel, 1, 0);
      tableLayoutPanel2.Controls.Add(totalRecordsLabel, 1, 1);
      tableLayoutPanel2.Controls.Add(totalVideoLabel, 1, 2);
      tableLayoutPanel2.Controls.Add(totalMonoLabel, 1, 3);
      tableLayoutPanel2.Controls.Add(totalStereoLabel, 1, 4);
      tableLayoutPanel2.Controls.Add(totalDataLabel, 1, 5);
      tableLayoutPanel2.Dock = DockStyle.Fill;
      tableLayoutPanel2.Location = new Point(3, 3);
      tableLayoutPanel2.Name = "tableLayoutPanel2";
      tableLayoutPanel2.RowCount = 6;
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
      tableLayoutPanel2.Size = new Size(479, 682);
      tableLayoutPanel2.TabIndex = 0;
      // 
      // spaceLabel1
      // 
      spaceLabel1.Customization = "/v7+/yoqKv8=";
      spaceLabel1.Dock = DockStyle.Fill;
      spaceLabel1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
      spaceLabel1.Image = null;
      spaceLabel1.Location = new Point(3, 3);
      spaceLabel1.Name = "spaceLabel1";
      spaceLabel1.NoRounding = false;
      spaceLabel1.Size = new Size(267, 107);
      spaceLabel1.TabIndex = 0;
      spaceLabel1.Text = "Total Sectors";
      spaceLabel1.TextAlignment = HorizontalAlignment.Center;
      spaceLabel1.Transparent = false;
      // 
      // spaceLabel2
      // 
      spaceLabel2.Customization = "/v7+/yoqKv8=";
      spaceLabel2.Dock = DockStyle.Fill;
      spaceLabel2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
      spaceLabel2.Image = null;
      spaceLabel2.Location = new Point(3, 116);
      spaceLabel2.Name = "spaceLabel2";
      spaceLabel2.NoRounding = false;
      spaceLabel2.Size = new Size(267, 107);
      spaceLabel2.TabIndex = 1;
      spaceLabel2.Text = "Total Records";
      spaceLabel2.TextAlignment = HorizontalAlignment.Center;
      spaceLabel2.Transparent = false;
      // 
      // spaceLabel3
      // 
      spaceLabel3.Customization = "/v7+/yoqKv8=";
      spaceLabel3.Dock = DockStyle.Fill;
      spaceLabel3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
      spaceLabel3.Image = null;
      spaceLabel3.Location = new Point(3, 229);
      spaceLabel3.Name = "spaceLabel3";
      spaceLabel3.NoRounding = false;
      spaceLabel3.Size = new Size(267, 107);
      spaceLabel3.TabIndex = 2;
      spaceLabel3.Text = "Total Video Sectors";
      spaceLabel3.TextAlignment = HorizontalAlignment.Center;
      spaceLabel3.Transparent = false;
      // 
      // spaceLabel4
      // 
      spaceLabel4.Customization = "/v7+/yoqKv8=";
      spaceLabel4.Dock = DockStyle.Fill;
      spaceLabel4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
      spaceLabel4.Image = null;
      spaceLabel4.Location = new Point(3, 342);
      spaceLabel4.Name = "spaceLabel4";
      spaceLabel4.NoRounding = false;
      spaceLabel4.Size = new Size(267, 107);
      spaceLabel4.TabIndex = 3;
      spaceLabel4.Text = "Total Mono Sectors";
      spaceLabel4.TextAlignment = HorizontalAlignment.Center;
      spaceLabel4.Transparent = false;
      // 
      // spaceLabel5
      // 
      spaceLabel5.Customization = "/v7+/yoqKv8=";
      spaceLabel5.Dock = DockStyle.Fill;
      spaceLabel5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
      spaceLabel5.Image = null;
      spaceLabel5.Location = new Point(3, 455);
      spaceLabel5.Name = "spaceLabel5";
      spaceLabel5.NoRounding = false;
      spaceLabel5.Size = new Size(267, 107);
      spaceLabel5.TabIndex = 4;
      spaceLabel5.Text = "Total Stereo Sectors";
      spaceLabel5.TextAlignment = HorizontalAlignment.Center;
      spaceLabel5.Transparent = false;
      // 
      // spaceLabel6
      // 
      spaceLabel6.Customization = "/v7+/yoqKv8=";
      spaceLabel6.Dock = DockStyle.Fill;
      spaceLabel6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
      spaceLabel6.Image = null;
      spaceLabel6.Location = new Point(3, 568);
      spaceLabel6.Name = "spaceLabel6";
      spaceLabel6.NoRounding = false;
      spaceLabel6.Size = new Size(267, 111);
      spaceLabel6.TabIndex = 5;
      spaceLabel6.Text = "Total Data Sectors";
      spaceLabel6.TextAlignment = HorizontalAlignment.Center;
      spaceLabel6.Transparent = false;
      // 
      // totalSectorsLabel
      // 
      totalSectorsLabel.Customization = "/v7+/yoqKv8=";
      totalSectorsLabel.Dock = DockStyle.Fill;
      totalSectorsLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
      totalSectorsLabel.Image = null;
      totalSectorsLabel.Location = new Point(276, 3);
      totalSectorsLabel.Name = "totalSectorsLabel";
      totalSectorsLabel.NoRounding = false;
      totalSectorsLabel.Size = new Size(200, 107);
      totalSectorsLabel.TabIndex = 6;
      totalSectorsLabel.TextAlignment = HorizontalAlignment.Center;
      totalSectorsLabel.Transparent = false;
      // 
      // totalRecordsLabel
      // 
      totalRecordsLabel.Customization = "/v7+/yoqKv8=";
      totalRecordsLabel.Dock = DockStyle.Fill;
      totalRecordsLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
      totalRecordsLabel.Image = null;
      totalRecordsLabel.Location = new Point(276, 116);
      totalRecordsLabel.Name = "totalRecordsLabel";
      totalRecordsLabel.NoRounding = false;
      totalRecordsLabel.Size = new Size(200, 107);
      totalRecordsLabel.TabIndex = 7;
      totalRecordsLabel.TextAlignment = HorizontalAlignment.Center;
      totalRecordsLabel.Transparent = false;
      // 
      // totalVideoLabel
      // 
      totalVideoLabel.Customization = "/v7+/yoqKv8=";
      totalVideoLabel.Dock = DockStyle.Fill;
      totalVideoLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
      totalVideoLabel.Image = null;
      totalVideoLabel.Location = new Point(276, 229);
      totalVideoLabel.Name = "totalVideoLabel";
      totalVideoLabel.NoRounding = false;
      totalVideoLabel.Size = new Size(200, 107);
      totalVideoLabel.TabIndex = 8;
      totalVideoLabel.TextAlignment = HorizontalAlignment.Center;
      totalVideoLabel.Transparent = false;
      // 
      // totalMonoLabel
      // 
      totalMonoLabel.Customization = "/v7+/yoqKv8=";
      totalMonoLabel.Dock = DockStyle.Fill;
      totalMonoLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
      totalMonoLabel.Image = null;
      totalMonoLabel.Location = new Point(276, 342);
      totalMonoLabel.Name = "totalMonoLabel";
      totalMonoLabel.NoRounding = false;
      totalMonoLabel.Size = new Size(200, 107);
      totalMonoLabel.TabIndex = 9;
      totalMonoLabel.TextAlignment = HorizontalAlignment.Center;
      totalMonoLabel.Transparent = false;
      // 
      // totalStereoLabel
      // 
      totalStereoLabel.Customization = "/v7+/yoqKv8=";
      totalStereoLabel.Dock = DockStyle.Fill;
      totalStereoLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
      totalStereoLabel.Image = null;
      totalStereoLabel.Location = new Point(276, 455);
      totalStereoLabel.Name = "totalStereoLabel";
      totalStereoLabel.NoRounding = false;
      totalStereoLabel.Size = new Size(200, 107);
      totalStereoLabel.TabIndex = 10;
      totalStereoLabel.TextAlignment = HorizontalAlignment.Center;
      totalStereoLabel.Transparent = false;
      // 
      // totalDataLabel
      // 
      totalDataLabel.Customization = "/v7+/yoqKv8=";
      totalDataLabel.Dock = DockStyle.Fill;
      totalDataLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
      totalDataLabel.Image = null;
      totalDataLabel.Location = new Point(276, 568);
      totalDataLabel.Name = "totalDataLabel";
      totalDataLabel.NoRounding = false;
      totalDataLabel.Size = new Size(200, 111);
      totalDataLabel.TabIndex = 11;
      totalDataLabel.TextAlignment = HorizontalAlignment.Center;
      totalDataLabel.Transparent = false;
      // 
      // RTFForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1535, 718);
      Controls.Add(spaceForm1);
      FormBorderStyle = FormBorderStyle.None;
      Name = "RTFForm";
      Text = "RTFForm";
      TransparencyKey = System.Drawing.Color.Purple;
      spaceForm1.ResumeLayout(false);
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel2.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private OpenFileDialog openFileDialog1;
    private FolderBrowserDialog folderBrowserDialog1;
    private ReaLTaiizor.Forms.SpaceForm spaceForm1;
    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private ReaLTaiizor.Controls.SpaceLabel spaceLabel1;
    private ReaLTaiizor.Controls.SpaceLabel spaceLabel2;
    private ReaLTaiizor.Controls.SpaceLabel spaceLabel3;
    private ReaLTaiizor.Controls.SpaceLabel spaceLabel4;
    private ReaLTaiizor.Controls.SpaceLabel spaceLabel5;
    private ReaLTaiizor.Controls.SpaceLabel spaceLabel6;
    private ReaLTaiizor.Controls.SpaceLabel totalSectorsLabel;
    private ReaLTaiizor.Controls.SpaceLabel totalRecordsLabel;
    private ReaLTaiizor.Controls.SpaceLabel totalVideoLabel;
    private ReaLTaiizor.Controls.SpaceLabel totalMonoLabel;
    private ReaLTaiizor.Controls.SpaceLabel totalStereoLabel;
    private ReaLTaiizor.Controls.SpaceLabel totalDataLabel;
  }
}