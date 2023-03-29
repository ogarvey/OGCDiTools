namespace Desktop
{
  partial class MainWindow
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      rtfButton = new Button();
      binButton = new Button();
      SuspendLayout();
      // 
      // rtfButton
      // 
      rtfButton.Location = new Point(30, 22);
      rtfButton.Margin = new Padding(2);
      rtfButton.Name = "rtfButton";
      rtfButton.Size = new Size(193, 80);
      rtfButton.TabIndex = 0;
      rtfButton.Text = "RTF Tools";
      rtfButton.UseVisualStyleBackColor = true;
      rtfButton.Click += button1_Click;
      // 
      // binButton
      // 
      binButton.Location = new Point(30, 107);
      binButton.Name = "binButton";
      binButton.Size = new Size(193, 80);
      binButton.TabIndex = 1;
      binButton.Text = "BIN Tools";
      binButton.UseVisualStyleBackColor = true;
      binButton.Click += button2_Click;
      // 
      // MainWindow
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1242, 591);
      Controls.Add(binButton);
      Controls.Add(rtfButton);
      Margin = new Padding(2);
      Name = "MainWindow";
      Text = "OG CD-i Tools";
      ResumeLayout(false);
    }

    #endregion

    private Button rtfButton;
    private Button binButton;
  }
}