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
      SuspendLayout();
      // 
      // spaceForm1
      // 
      spaceForm1.BackColor = System.Drawing.Color.FromArgb(42, 42, 42);
      spaceForm1.BorderStyle = FormBorderStyle.None;
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
      spaceForm1.Text = "spaceForm1";
      spaceForm1.TransparencyKey = System.Drawing.Color.Purple;
      spaceForm1.Transparent = false;
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
      ResumeLayout(false);
    }

    #endregion

    private ReaLTaiizor.Forms.SpaceForm spaceForm1;
  }
}