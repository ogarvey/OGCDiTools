using Desktop.Helpers;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace Desktop.Views.Imagery
{
  public partial class DYUVForm : Form
  {
    private byte[] _binFileBytes;
    private byte[] _dyuvBytes;
    public DYUVForm(byte[] binFile)
    {
      InitializeComponent();
      _binFileBytes = binFile;
      _dyuvBytes = GetDyuvBytes();
      DisplayDyuvImage();
    }

    private byte[] GetDyuvBytes()
    {
      var bytesToRead = 92160;
      if (_binFileBytes.Length == bytesToRead)
      {
        return _binFileBytes;
      }
      else
      {
        var (offset, toRead) = PromptForHexOffset();
        return _binFileBytes.Skip(offset).Take(toRead).ToArray();
      }
    }

    private void DisplayDyuvImage()
    {
      var bitmap = new Bitmap(384, 240);
      if (_dyuvBytes.Length / 384 != 240)
      {
        bitmap = Utilities.DecodeDYUVImage(_dyuvBytes, 384, _dyuvBytes.Length / 384);
      }
      else
      {
        bitmap = Utilities.DecodeDYUVImage(_dyuvBytes);
      }
      pictureBox1.Size = new Size(768, 560);
      pictureBox1.Image = BitmapHelper.Scale4(bitmap);
      pictureBox1.Visible = true;
    }

    private (int, int) PromptForHexOffset()
    {
      using (var dialog = new Form())
      {
        dialog.Text = "Enter Hex Offset and bytes to read";

        var label = new Label();
        label.Text = "Enter a hexadecimal offset:";
        label.Location = new Point(10, 10);
        label.AutoSize = true;
        dialog.Controls.Add(label);

        var numericUpDown = new NumericUpDown();
        numericUpDown.Hexadecimal = true;
        numericUpDown.Location = new Point(10, 40);
        numericUpDown.Maximum = decimal.MaxValue;
        dialog.Controls.Add(numericUpDown);

        var label2 = new Label();
        label2.Text = "Enter the bytes to read:";
        label2.Location = new Point(10, 80);
        label2.AutoSize = true;
        dialog.Controls.Add(label2);

        var numericUpDown2 = new NumericUpDown();
        numericUpDown2.Location = new Point(10, 110);
        numericUpDown2.Maximum = 92160;
        numericUpDown2.Value = 92160;
        dialog.Controls.Add(numericUpDown2);

        var okButton = new Button();
        okButton.Text = "OK";
        okButton.DialogResult = DialogResult.OK;
        okButton.Location = new Point(50, 140);
        dialog.Controls.Add(okButton);

        var cancelButton = new Button();
        cancelButton.Text = "Cancel";
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Location = new Point(110, 170);
        dialog.Controls.Add(cancelButton);

        dialog.AcceptButton = okButton;
        dialog.CancelButton = cancelButton;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
          return ((int)numericUpDown.Value, (int)numericUpDown2.Value);
        }
        else
        {
          return (0, 92160);
        }
      }
    }
  }
}
